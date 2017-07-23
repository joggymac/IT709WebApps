using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class CarModel
    {
        [Key]
        public int CarModelID { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
