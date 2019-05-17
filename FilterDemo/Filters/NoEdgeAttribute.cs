using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Filters
{
    public class NoEdgeAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            string userAgent = context.HttpContext.Request.Headers["user-agent"].FirstOrDefault();

            if (userAgent.Contains("Edge"))
            {
                context.Result = new ContentResult()
                {
                    Content = "NO EDGE!"
                };
            }
        }
    }
}
