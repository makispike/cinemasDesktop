using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class Movie
    {
        public int movieId { get; set; }
        public string movieNameFr { get; set; }
        public string movieNameNl { get; set; }
        private string movieNameEN { get; set; }
        private string movieDescriptionFR { get; set; }
        private string movieDescriptionNL { get; set; }
        private string movieDescriptionEN { get; set; }
        private string moviePictureUrl { get; set; }
        private List<Genre> genres { get; set; }
        private List<Version> versions { get; set; }
        private List<Screening> screenings { get; set; }

    }
}
