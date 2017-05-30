using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest3.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        [Required]
        public Album Album { get; set; }

        public virtual int AlbumID { get; set; }

    }
}
