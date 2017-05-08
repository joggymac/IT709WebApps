using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest2.Models
{
    public class Song
    {
        [Required]
        public int SongID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int AlbumID { get; set; }

        public Album Album { get; set; }

    }
}
