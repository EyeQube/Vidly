using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.Api
{
    //[Authorize(Roles = RoleName.CanManageMovies)]
    public class MoviesController : ApiController
    {
        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //get moviesList  api/Movies
        [AllowAnonymous]
        public IHttpActionResult GetMovies()
        {
            var movieDtos = _context.Movies
                .Include(c => c.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDtos);
        }

        //get movie    api/Movies/1
        [AllowAnonymous]
        public IHttpActionResult GetMovie(int id)
        {

            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();


            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }
        // ////////////////////////////////////////////////////////////////////////////////////////////////////
       
        //Post api/Movies/
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateMovie(MovieDto movieDto) 
        {

            if (!ModelState.IsValid)
                return BadRequest();

            var movieCreate = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movieCreate);
            _context.SaveChanges();

            movieDto.Id = movieCreate.Id;

            return Created(new Uri(Request.RequestUri + "/" + movieCreate.Id), movieDto);
        }


        //Put api/Movies/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void UpdateMovie(int id, MovieDto movieDto)  
        {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var _movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (_movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            Mapper.Map(movieDto, _movie);

            _context.SaveChanges(); 

        }


        //Delete   api/Movies/1 
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void DeleteMovie(int id) 
        {
           var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movie);

            _context.SaveChanges();
        }


    }
}
