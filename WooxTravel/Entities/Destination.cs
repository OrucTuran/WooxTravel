using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WooxTravel.Entities
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int DayNight { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
    }
}