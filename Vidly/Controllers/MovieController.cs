using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)  
        {

            if(movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var dbMovie = _context.Movies.Single(c => c.Id == movie.Id);
                dbMovie.Id = movie.Id;
                dbMovie.Name = movie.Name;
                dbMovie.ReleaseDate = movie.ReleaseDate;
                dbMovie.Genre = movie.Genre;
                dbMovie.NumberInStock += 1;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }
        /// //////////////////////////////////////////////////////////////
         public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == Id);

            if( movie == null)
            {
                return HttpNotFound();
            }

            return View("MovieForm", movie);

        } 

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