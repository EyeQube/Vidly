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
            // var movies = _context.Movies.Include(c => c.Genre).ToList();

            //return View(movies);
            return View();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        public ActionResult Edit(int id)
        {

            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

                /*MovieFormViewModel viewModel = new MovieFormViewModel(movie)
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    ReleaseDate = movie.ReleaseDate,
                    NumberInStock = movie.NumberInStock,
                    GenreId = movie.GenreId,
                    Genres = _context.Genres.ToList()
                }; */
            

            return View("MovieForm", viewModel);
        }


        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = genres

            };

            return View("MovieForm", viewModel);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)  
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }


            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var newMovie = _context.Movies.Single(c => c.Id == movie.Id);
                newMovie.Name = movie.Name;
                newMovie.ReleaseDate = movie.ReleaseDate;
                newMovie.GenreId = movie.GenreId;
                newMovie.NumberInStock = movie.NumberInStock;
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