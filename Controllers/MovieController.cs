
using Eagle.API.Services.Interfaces;
using Eagle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eagle.API.Controllers
{

    [Route("movies")]
    [ApiController]
    public class MovieController : Controller
    {
        private IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }


        #region GET


        [HttpGet("stats")]
        public async Task<ActionResult<List<MovieStatsViewModel>>> GetMovieStats()
        {
            return Ok(await movieService.GetMovieStats().ConfigureAwait(false));
        }



        #endregion


        #region POST



        #endregion


        #region PUT



        #endregion


        #region DELETE


        #endregion





    }
}
