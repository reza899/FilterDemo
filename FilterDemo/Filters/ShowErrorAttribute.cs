using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Filters
{
    public class ShowError : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var ex = context.Exception;
            var view = new ViewResult
            {
                ViewName = "Error"
            };
            view.ViewData.Add("ErrorMessage", ex);

            context.Result = view;
        }
    }
}
