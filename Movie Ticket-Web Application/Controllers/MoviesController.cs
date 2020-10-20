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
                    FullPlotDsc = "A young man is devoted to protecting his loved ones in a town full of corruption and sinister characters."

                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Knives Out",
                    imgUrl = "/images/02.jpg",
                    PlotDsc = "The circumstances surrounding the death...",
                    FullPlotDsc = "The circumstances surrounding the death of crime novelist Harlan Thrombey are mysterious, but there's one thing that renowned Detective Benoit Blanc knows for sure -- everyone in the wildly dysfunctional Thrombey family is a suspect. Now, Blanc must sift through a web of lies and red herrings to uncover the truth."
                });
                movieList.Add(new Movie
                {
                 
                    TotalCapacity = 150,
                    Title = "Midsommar",
                    imgUrl = "/images/03.jpg",
                    PlotDsc = "A couple travel to Sweden to visit their friend's rural...",
                    FullPlotDsc = "A couple travel to Sweden to visit their friend's rural hometown for its fabled midsummer festival, but what begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Tenet",
                    imgUrl = "/images/04.jpg",
                    PlotDsc = "A secret agent embarks on a dangerous, time-bending...",
                    FullPlotDsc = "A secret agent embarks on a dangerous, time-bending mission to prevent the start of World War III."
                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Inception",
                    imgUrl = "/images/05.jpg",
                    PlotDsc = "Cobb steals information from his targets by entering...",
                    FullPlotDsc = "Cobb steals information from his targets by entering their dreams. Saito offers to wipe clean Cobb's criminal history as payment for performing an inception on his sick competitor's son."

                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Joker",
                    imgUrl = "/images/06.jpg",
                    PlotDsc = "Arthur Fleck, a party clown, leads an impoverished life ...",
                    FullPlotDsc = "Arthur Fleck, a party clown, leads an impoverished life with his ailing mother. However, when society shuns him and brands him as a freak, he decides to embrace the life of crime and chaos."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Zodiac",
                    imgUrl = "/images/07.jpg",
                    PlotDsc = "Robert Graysmith, a cartoonist by profession...",
                    FullPlotDsc = "Robert Graysmith, a cartoonist by profession, finds himself obsessively thinking about the Zodiac killer. He uses his puzzle-solving abilities to get closer to revealing the identity of the killer."
                });
                movieList.Add(new Movie
                {
                  
                    TotalCapacity = 150,
                    Title = "The Boyz",
                    imgUrl = "/images/08.jpg",
                    PlotDsc = "Superheroes are often as popular as celebrities...",
                    FullPlotDsc = "Superheroes are often as popular as celebrities, as influential as politicians, and sometimes even as revered as gods. But that's when they're using their powers for good. What happens when the heroes go rogue and start abusing their powers? When it's the powerless against the super powerful, the Boys head out on a heroic quest to expose the truth about the Seven and Vought, the multibillion-dollar conglomerate that manages the superheroes and covers up their dirty secrets. Based on the comic book series of the same name."
                });

                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Raised by wolves",
                    imgUrl = "/images/09.jpg",
                    PlotDsc = "Two androids are tasked with raising human children...",
                    FullPlotDsc = "Two androids are tasked with raising human children on a mysterious virgin planet; as the human colony threatens to be torn apart by religious differences, the androids learn that controlling the beliefs of humans is a treacherous and difficult task."
                });
                movieList.Add(new Movie
                {
                   
                    TotalCapacity = 150,
                    Title = "Cobra Kai",
                    imgUrl = "/images/10.jpg",
                    PlotDsc = "Thirty four years after events of the 1984 All Valley...",
                    FullPlotDsc = "Thirty four years after events of the 1984 All Valley Karate Tournament, a down-and-out Johnny Lawrence seeks redemption by reopening the infamous Cobra Kai dojo, reigniting his rivalry with a now successful Daniel LaRusso."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Godfather",
                    imgUrl = "/images/11.jpg",
                    PlotDsc = "The Godfather is a 1972 American crime film ...",
                    FullPlotDsc = "The Godfather is a 1972 American crime film directed by Francis Ford Coppola who co-wrote the screenplay with Mario Puzo, based on Puzo's best-selling 1969 novel of the same name."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Her",
                    imgUrl = "/images/12.jpg",
                    PlotDsc = "Theodore Twombly, an introverted writer, buys an ...",
                    FullPlotDsc = "Theodore Twombly, an introverted writer, buys an Artificial Intelligence system to help him write. However, when he finds out about the AI's ability to learn and adapt, he falls in love with it."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Midway",
                    imgUrl = "/images/13.jpg",
                    PlotDsc = "Centers on the Battle of Midway, a clash between...",
                    FullPlotDsc = "On Dec. 7, 1941, Japanese forces launch a devastating attack on Pearl Harbor, the U.S. naval base in Hawaii. Six months later, the Battle of Midway commences on June 4, 1942, as the Japanese navy once again plans a strike against American ships in the Pacific. For the next three days, the U.S. Navy and a squad of brave fighter pilots engage the enemy in one of the most important and decisive battles of World War II."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "21 Bridges",
                    imgUrl = "/images/14.jpg",
                    PlotDsc = "After uncovering a massive conspiracy, an embattled... ",
                    FullPlotDsc = "After uncovering a massive conspiracy, an embattled NYPD detective joins a citywide manhunt for two young cop killers. As the night unfolds, he soon becomes unsure of who to pursue -- and who's in pursuit of him. When the search intensifies, authorities decide to take extreme measures by closing all of Manhattan's 21 bridges to prevent the suspects from escaping."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "Interstellar",
                    imgUrl = "/images/15.jpg",
                    PlotDsc = "In the future, where Earth is becoming uninhabitable...",
                    FullPlotDsc = "In the future, where Earth is becoming uninhabitable, farmer and ex-NASA pilot Cooper is asked to pilot a spacecraft along with a team of researchers to find a new planet for humans."
                });
                movieList.Add(new Movie
                {
                    
                    TotalCapacity = 150,
                    Title = "The Dark Knight",
                    imgUrl = "/images/16.jpg",
                    PlotDsc = "After Gordon, Dent and Batman begin an assault on...",
                    FullPlotDsc = "After Gordon, Dent and Batman begin an assault on Gotham's organised crime, the mobs hire the Joker, a psychopathic criminal mastermind who offers to kill Batman and bring the city to its knees."
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
            Reservation StoringMovie = new Reservation();
            Users StoringUser = new Users();

        
            Movie movie = await _context.Movie.Where(movie => movie.Id == id).FirstAsync();
            if (movie.BookedCapacity < movie.TotalCapacity)
            {
                StoringUser.UserId = _context.Users.Where(m => m.UserName == "Admin").First().UserId;
                movie.BookedCapacity = movie.BookedCapacity + 1;
                StoringMovie.Mid = movie.Id;
                StoringMovie.Uid = StoringUser.UserId;
                Message = "Movie booked successfully";
                await _context.Reservation.AddAsync(StoringMovie);
                         _context.SaveChanges();
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
