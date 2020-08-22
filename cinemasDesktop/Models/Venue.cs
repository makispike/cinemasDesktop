using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class Venue
    {
        private int venueId { get; set; }
        private int venueNumber { get; set; }
        private int venueSeatsAmount { get; set; }
        private List<Screening> screenings { get; set; }
        private Location location { get; set; }
    }
}
