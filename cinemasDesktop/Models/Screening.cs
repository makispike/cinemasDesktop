using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class Screening
    {
     
        private int screeningId { get; set; }
        private DateTime screeningDate { get; set; }
        private DateTime screeningTime { get; set; }
        private int availableSeats { get; set; }
        private Venue venue { get; set; }
        private Movie movie { get; set; }
        private List<Ticket> tickets { get; set; }
        private Version version { get; set; } 

    }
}
