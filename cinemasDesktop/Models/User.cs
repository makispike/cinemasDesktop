using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class User
    {
        private int userId { get; set; }
        private string userEmail { get; set; }
        private string userLastName { get; set; }
        private string userFirstName { get; set; }
        private string userAddress { get; set; }
        private string userContactEmail { get; set; }
        private List<Reservation> reservations { get; set; }
    }
}
