using FilterDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> contextOptions):base(contextOptions)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new List<Movie>() {
                new Movie
                { Id = 1, Name = "Pulp Fiction",
                    YearProduction = 1994, Summary = "folks guys..",
                    ViewCount = default(int) },
                new Movie{ Id = 2, Name = "Titanic",
                    YearProduction = 1997, Summary = "big boat...",
                    ViewCount = default(int)}
            });
        }
    }
}
