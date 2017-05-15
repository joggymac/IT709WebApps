using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest6.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
