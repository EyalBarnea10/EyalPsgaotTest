using BLTestEyal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestEyal.Models;

namespace TestEyal.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/movies")]
        [HttpGet]
        /// <summary>
        /// Call Bl and get the movies list 
        /// </summary>
        public IEnumerable<Movie> GetMoviesList()
        {
            BlTest blTest = new BlTest();
            MoviesList lsMovies = new MoviesList();
            lsMovies = blTest.GetMoviesList();

            return lsMovies.Movies;
        }

    }
}
