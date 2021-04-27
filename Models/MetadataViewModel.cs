using System;
using System.Collections.Generic;
using System.Text;

namespace Eagle.Models
{
    public class MetadataViewModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }


        //public TimeSpan Duration { get; set; }
        public string Duration { get; set; }


        public int ReleaseYear { get; set; }

    }
}
