using CsvHelper;
using CsvHelper.Configuration;
using Eagle.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Eagle.API.Data
{
    public class DataClass : IDataClass
    {
        public List<MetadataViewModel> database = new List<MetadataViewModel>();
        public List<MovieStatsViewModel> stats = new List<MovieStatsViewModel>();

        public DataClass()
        {
            if (database.Count() == 0)
            {

                using (var reader = new StreamReader(Directory.GetCurrentDirectory() + "\\data\\metadata.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    this.database = csv.GetRecords<MetadataViewModel>().ToList();

                    //foreach (MetadataViewModelTemp rec in records)
                    //{
                    //    // Remove duplicates
                    //    var recFound = database.Where(_ => _.MovieId == rec.MovieId && _.Language == rec.Language && _.Title == rec.Title).FirstOrDefault();
                    //    if (recFound == null)
                    //    {
                    //        database.Add(new MetadataViewModel()
                    //        {
                    //            Duration = rec.Duration,
                    //            Id = rec.Id,
                    //            Language = rec.Language,
                    //            MovieId = rec.MovieId,
                    //            ReleaseYear = rec.ReleaseYear,
                    //            Title = rec.Title
                    //        });
                    //    }
                    //}

                }
            }
        }


        #region Get

        public IQueryable<MetadataViewModel> GetMetadata()
        {
            return database.AsQueryable();
        }


        public async Task<List<MovieStatsViewModel>> GetStats()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower()
            };

            using (var reader = new StreamReader(Directory.GetCurrentDirectory() + "\\data\\stats.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<MovieStatsViewModel>();
                return await Task.Run(() => records.ToList());
            }
        }


        #endregion



        #region Create

        public async Task<MetadataViewModel> CreateMetaData(MetadataViewModel model)
        {
            database.Add(model);

            // Returned rescourse presumably with the newy-inserted id
            return await Task.Run(() => model);
        }




        #endregion

    }
}
