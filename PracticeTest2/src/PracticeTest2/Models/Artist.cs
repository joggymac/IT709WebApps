using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest2.Models
{
    public class Artist
    {
        [Required]
        public int ArtistID { get; set; }
        [Required]
        public string Name { get; set; }
        
    }
}
