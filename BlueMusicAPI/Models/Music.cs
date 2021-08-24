using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueMusicAPI.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }
        public string Link { get; set; }

    }
}
