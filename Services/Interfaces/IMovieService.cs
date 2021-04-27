
using Eagle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eagle.API.Services.Interfaces
{
    public interface IMovieService
    {
        Task<List<MovieStatsViewModel>> GetMovieStats();

    }
}
