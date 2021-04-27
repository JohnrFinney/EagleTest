using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Eagle.API.Services.Interfaces;
using Eagle.Models;
using Eagle.API.Data;

namespace Eagle.API.Services
{
    public class MetadataService : IMetadataService
    {
        private readonly IDataClass dataClass;

        public MetadataService(IDataClass dataClass)
        {
            this.dataClass = dataClass;

        }


        #region Get


        public async Task<List<MetadataViewModel>> GetMetaData(int movieId)
        {
            var res = this.dataClass.GetMetadata().Where(_ => _.MovieId == movieId).ToList();
            return await Task.Run(() => res);
        }


        #endregion



        #region Create

        public Task<MetadataViewModel> CreateMetaData(MetadataViewModel model)
        {
            return this.dataClass.CreateMetaData(model);
        }


        #endregion

    }
}