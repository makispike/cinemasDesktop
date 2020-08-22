using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class Ticket
    {
        private int ticketId { get; set; }
        private Reservation reservation { get; set; }
        private Screening screening { get; set; }
        private PriceCategory priceCategory { get; set; }

    }
}
