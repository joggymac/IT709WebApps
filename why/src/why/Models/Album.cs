using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace why.Models
{
    public class Album
    {
        public int AlbumID { get;  set; }
        public string Title { get; set; }
        public DateTime Year { get; set; }

        public Artist Artist { get; set; }
    }
}
