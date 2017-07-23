using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class GearBox
    {
        [Key]
        public int GearBoxID { get; set; }
        [Required]
        public string GearBoxType { get; set; }
    }
}
