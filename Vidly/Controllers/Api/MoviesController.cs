using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private MyDBContext _context;

        public MoviesController()
        {
            _context = new MyDBContext();
        }

        //GET /api/movies
        public IHttpActionResult GetMovies()
        {
            return Ok();
        }

        //GET /api/movies/1
        public IHttpActionResult GetMovie(int id)
        {
            return Ok();
        }

        //POST /api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(Movie movie)
        {
            return Ok();
        }

        //PUT /api/movies/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, Movie movie)
        {
            return Ok();
        }

        //DELETE /api/movies/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            return Ok();
        }
    }
}
