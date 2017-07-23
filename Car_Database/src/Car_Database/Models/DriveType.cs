using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class DriveType
    {
        [Key]
        public int DrveTypeID { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
