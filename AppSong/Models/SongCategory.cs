using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSong.Models
{
    public class SongCategory
    {
        public string SongId { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public Song Song { get; set; }
    }
}
