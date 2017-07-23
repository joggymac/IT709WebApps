using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class FuelType
    {
        [Key]
        public int FuelTypeID { get; set; }
        [Required]
        public string Fuel { get; set; }
    }
}
