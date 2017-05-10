using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTest3.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }

        public Album Album { get; set; }
        public virtual int AlbumID { get; set; }

    }
}
