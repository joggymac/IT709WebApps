using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest3.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public DateTime Year { get; set; }

        public virtual int GenreID { get; set; }
        public virtual int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
