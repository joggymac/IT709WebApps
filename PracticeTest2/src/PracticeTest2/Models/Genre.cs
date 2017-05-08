using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest2.Models
{
    public class Genre
    {
        [Required]
        public int GenreID { get; set; }
        [Required]
        public int Name { get; set; }

    }
}
