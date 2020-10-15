using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DBContext _context;

        public MoviesController(DBContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            List<Movie> movies = await _context.Movie.ToListAsync();
            if (movies.Count == 0)
            {
                List<Movie> movieList = new List<Movie>();
                movieList.Add(new Movie
                {
                    TotalCapacity = 150,
                    Title = "The Devil All the time",
                    imgUrl = "/images/01.jpg",
                    PlotDsc = "breif plot descriptions"

                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Knives Out",
                    imgUrl = "/images/02.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                 
                    TotalCapacity = 150,
                    Title = "Midsommar",
                    imgUrl = "/images/03.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Tenet",
                    imgUrl = "/images/04.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Tenet",
                    imgUrl = "/images/05.jpg",
                    PlotDsc = "breif plot descriptions"

                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Inception",
                    imgUrl = "/images/06.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Joker",
                    imgUrl = "/images/07.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                  
                    TotalCapacity = 150,
                    Title = "Zodiac",
                    imgUrl = "/images/08.jpg",
                    PlotDsc = "breif plot descriptions"
                });

                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Boyz",
                    imgUrl = "/images/09.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Raised by wolves",
                    imgUrl = "/images/10.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Cobra Kai",
                    imgUrl = "/images/11.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Godfather",
                    imgUrl = "/images/12.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "After the colided",
                    imgUrl = "/images/13.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Midway",
                    imgUrl = "/images/14.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Interstellar",
                    imgUrl = "/images/15.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Dark Knight",
                    imgUrl = "/images/16.jpg",
                    PlotDsc = "breif plot descriptions"
                });
                await _context.Movie.AddRangeAsync(movieList);
                await _context.SaveChangesAsync();
                return View(movieList);
            }
            return View(movies);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            var model = new DetailViewModel
            {
                Movie = movie
            };
            return View(model);
        }

        public async Task<IActionResult> Book(int id)
        {
            string Message = "";
            Movie movie = await _context.Movie.Where(movie => movie.Id == id).FirstAsync();
            if (movie.BookedCapacity < movie.TotalCapacity)
            {
                movie.BookedCapacity = movie.BookedCapacity + 1;
                _context.SaveChanges();
                Message = "Movie booked successfully";
            }
            else
            {
                Message = "No vacancy";
            }
            var model = new DetailViewModel
            {
                Message = Message,
                Movie = movie
            };
            return View("Details",model);
        }




        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,TotalCapacity,BookedCapacity,imgUrl,PlotDsc")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,TotalCapacity,BookedCapacity,imgUrl,PlotDsc")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
