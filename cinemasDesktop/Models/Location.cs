using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemasDesktop.Models
{
    class Location
    {
        private int locationId { get; set; }
        private string locationName { get; set; }
        private string locationAddress { get; set; }
        private string locationDescriptionFR { get; set; }
        private string locationDescriptionNL { get; set; }
        private string locationDescriptionEN { get; set; }
        private string locationPhotoUrl { get; set; }
        private List<Venue> venues { get; set; }
        private List<PriceCategory> priceCategories { get; set; }
    }
}
