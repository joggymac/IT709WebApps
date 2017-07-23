using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class Cylinder
    {
        [Key]
        public int CylinderID { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
