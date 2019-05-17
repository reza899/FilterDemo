using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearProduction { get; set; }
        public string Summary { get; set; }
        public int ViewCount { get; set; }

        public byte[] MovieImage { get; set; }

    }
}
