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
                    PlotDsc = "A young man is devoted to protecting his loved...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."

                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Knives Out",
                    imgUrl = "/images/02.jpg",
                    PlotDsc = "The circumstances surrounding the death...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                 
                    TotalCapacity = 150,
                    Title = "Midsommar",
                    imgUrl = "/images/03.jpg",
                    PlotDsc = "A couple travel to Sweden to visit their friend's rural...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Tenet",
                    imgUrl = "/images/04.jpg",
                    PlotDsc = "A secret agent embarks on a dangerous, time-bending...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Inception",
                    imgUrl = "/images/05.jpg",
                    PlotDsc = "Cobb steals information from his targets by entering...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."

                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Joker",
                    imgUrl = "/images/06.jpg",
                    PlotDsc = "Arthur Fleck, a party clown, leads an impoverished life ...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Zodiac",
                    imgUrl = "/images/07.jpg",
                    PlotDsc = "Robert Graysmith, a cartoonist by profession...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                  
                    TotalCapacity = 150,
                    Title = "The Boyz",
                    imgUrl = "/images/08.jpg",
                    PlotDsc = "Superheroes are often as popular as celebrities...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });

                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Raised by wolves",
                    imgUrl = "/images/09.jpg",
                    PlotDsc = "Two androids are tasked with raising human children...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Cobra Kai",
                    imgUrl = "/images/10.jpg",
                    PlotDsc = "Thirty four years after events of the 1984 All Valley...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Godfather",
                    imgUrl = "/images/11.jpg",
                    PlotDsc = "The Godfather is a 1972 American crime film ...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Her",
                    imgUrl = "/images/12.jpg",
                    PlotDsc = "Theodore Twombly, an introverted writer, buys an ...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Midway",
                    imgUrl = "/images/13.jpg",
                    PlotDsc = "Centers on the Battle of Midway, a clash between...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "21 Bridges",
                    imgUrl = "/images/14.jpg",
                    PlotDsc = "After uncovering a massive conspiracy, an embattled... ",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Interstellar",
                    imgUrl = "/images/15.jpg",
                    PlotDsc = "In the future, where Earth is becoming uninhabitable...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Dark Knight",
                    imgUrl = "/images/16.jpg",
                    PlotDsc = "After Gordon, Dent and Batman begin an assault on...",
                    FullPlotDsc = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."
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
