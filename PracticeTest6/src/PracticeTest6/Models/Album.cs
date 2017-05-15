using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest6.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        [Required]
        public string Title { get; set; }
        [Range (1950,2020)]
        public int Year { get; set; }

        public virtual int GenreID { get; set; }
        public Genre Genre { get; set; }

        public virtual int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
