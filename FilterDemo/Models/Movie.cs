using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [Range(2000,2020)]
        public int YearProduction { get; set; }
        [Required]
        [StringLength(200)]
        public string Summary { get; set; }
        public int ViewCount { get; set; }
        public byte[] MovieImage { get; set; }

    }
}
