using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System;

namespace Vidly.Controllers 
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres

            };

            return View("MovieForm", viewModel);
        }


        [HttpPost]
        public ActionResult Save(Movie movie)  
        {
            var newMovie = _context.Movies.FirstOrDefault(c => c.Name == movie.Name);

            if (newMovie == null)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                newMovie.NumberInStock += movie.NumberInStock;
                DateTime Time = DateTime.Now;
                newMovie.DateAdded = Time;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }
        /// //////////////////////////////////////////////////////////////
        

      /*    // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        } */
    }
}