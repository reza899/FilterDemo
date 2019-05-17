using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilterDemo.Models;
using FilterDemo.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace FilterDemo.Controllers
{
    [BindProperties]
    public class HomeController : Controller
    {
        private readonly MovieDbContext context;
        public IFormFile MovieImage { get; set; }

        public HomeController(MovieDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var movies = context.Movies.AsEnumerable();
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            var movie = context.Movies.Where(m => m.Id == id).SingleOrDefault();
            if (movie.MovieImage != null)
                ViewData["img"] = "data:image/jpeg;base64," + Convert.ToBase64String(movie.MovieImage);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            context.Entry(movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            if (movie.MovieImage == null)
            {
                using (var stream = new MemoryStream())
                {
                    MovieImage.CopyTo(stream);
                    stream.Position = 0;
                    movie.MovieImage = stream.ToArray();
                }
            }
           
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Movie movie)
        {
            context.Entry(movie).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            using (var stream = new MemoryStream())
            {
                MovieImage.CopyTo(stream);
                stream.Position = 0;
                movie.MovieImage = stream.ToArray();
            }
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var movie = context.Movies.FirstOrDefault(m => m.Id == id);
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
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
