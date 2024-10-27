using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WooxTravel.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}