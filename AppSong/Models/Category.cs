using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSong.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<SongCategory> SongCategories { get; set; }
    }
}
