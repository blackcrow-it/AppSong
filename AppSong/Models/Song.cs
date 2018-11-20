using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSong.Models
{
    public class Song
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Thumbnail { get; set; }
        public List<SongCategory> SongCategories { get; set; }
    }
}
