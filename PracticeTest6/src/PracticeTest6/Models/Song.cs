using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest6.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Preview { get; set; }

        public virtual int AlbumID { get; set; }
        public Album Album { get; set; }
    }
}
