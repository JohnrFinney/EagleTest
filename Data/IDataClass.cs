
using Eagle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eagle.API.Data
{
    public interface IDataClass
    {
        IQueryable<MetadataViewModel> GetMetadata();
        Task<List<MovieStatsViewModel>> GetStats();
        Task<MetadataViewModel> CreateMetaData(MetadataViewModel model);
    }
}
