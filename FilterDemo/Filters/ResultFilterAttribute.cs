using FilterDemo.Data;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Filters
{
    public class ResultFilterAttribute : Attribute, IAsyncResultFilter
    {
        private readonly MovieDbContext movieDb;

        public ResultFilterAttribute(MovieDbContext movieDb)
        {
            this.movieDb = movieDb;
        }
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();
            int id = Convert.ToInt32(context.RouteData.Values["id"]);
            var movie = movieDb.Movies.Find(id);
            movie.ViewCount++;
            movieDb.SaveChanges();
        }
    }
}
