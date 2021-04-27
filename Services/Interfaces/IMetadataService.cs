﻿
using Eagle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eagle.API.Services.Interfaces
{
    public interface IMetadataService
    {
        Task<List<MetadataViewModel>> GetMetaData(int movieId);
        Task<MetadataViewModel> CreateMetaData(MetadataViewModel model);
    }
}
