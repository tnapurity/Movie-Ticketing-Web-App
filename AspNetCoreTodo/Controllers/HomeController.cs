using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie
            {
                Id = 1,
                TotalCapacity = 150,
                Title = "The Devil All the time",
                imgUrl="/images/01.jpg",
                PlotDsc="breif plot descriptions"
                
            });
            movieList.Add(new Movie
            {
                Id = 2,
                TotalCapacity = 150,
                Title = "Knives Out",
                imgUrl = "/images/02.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 3,
                TotalCapacity = 150,
                Title = "Midsommar",
                imgUrl = "/images/03.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 4,
                TotalCapacity = 150,
                Title = "Tenet",
                imgUrl = "/images/04.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 5,
                TotalCapacity = 150,
                Title = "Tenet",
                imgUrl = "/images/05.jpg",
                PlotDsc = "breif plot descriptions"

            });
            movieList.Add(new Movie
            {
                Id = 6,
                TotalCapacity = 150,
                Title = "Inception",
                imgUrl = "/images/06.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 7,
                TotalCapacity = 150,
                Title = "Joker",
                imgUrl = "/images/07.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 8,
                TotalCapacity = 150,
                Title = "Zodiac",
                imgUrl = "/images/08.jpg",
                PlotDsc = "breif plot descriptions"
            });

            movieList.Add(new Movie
            {
                Id = 9,
                TotalCapacity = 150,
                Title = "The Boyz",
                imgUrl = "/images/09.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 10,
                TotalCapacity = 150,
                Title = "Raised by wolves",
                imgUrl = "/images/10.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 11,
                TotalCapacity = 150,
                Title = "Cobra Kai",
                imgUrl = "/images/11.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 12,
                TotalCapacity = 150,
                Title = "The Godfather",
                imgUrl = "/images/12.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 13,
                TotalCapacity = 150,
                Title = "After the colided",
                imgUrl = "/images/13.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 14,
                TotalCapacity = 150,
                Title = "Midway",
                imgUrl = "/images/14.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 15,
                TotalCapacity = 150,
                Title = "Interstellar",
                imgUrl = "/images/15.jpg",
                PlotDsc = "breif plot descriptions"
            });
            movieList.Add(new Movie
            {
                Id = 16,
                TotalCapacity = 150,
                Title = "The Dark Knight",
                imgUrl = "/images/16.jpg",
                PlotDsc = "breif plot descriptions"
            });

            return View(movieList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
