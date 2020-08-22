using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class Reservation
    {
        private int reservationId { get; set; }
        private DateTime reservationDateTime { get; set; }
        private double totalPrice { get; set; } 
        private User user { get; set; }
        private List<Ticket> tickets { get; set; }
    }
}
