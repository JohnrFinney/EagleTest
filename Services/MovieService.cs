using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Eagle.API.Services.Interfaces;
using Eagle.Models;
using Eagle.API.Data;

namespace Eagle.API.Services
{
    public class MovieService : IMovieService
    {
        private readonly IDataClass dataClass;


        public MovieService(IDataClass dataClass)
        {
            this.dataClass = dataClass;
        }


        #region Get

        public async Task<List<MovieStatsViewModel>> GetMovieStats()
        {
            return await this.dataClass.GetStats();
        }




        #endregion



        #region Create


        #endregion

    }
}