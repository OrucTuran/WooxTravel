using System;

namespace WooxTravel.Entities
{
    public class Rezervation
    {
        public int RezervationID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PersonCount { get; set; }
        public DateTime RezervationDate { get; set; }
        public string Description { get; set; }
    }
}