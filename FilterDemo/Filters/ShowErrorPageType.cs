using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Filters
{
    public class ShowErrorPageType : TypeFilterAttribute
    {
        public ShowErrorPageType() : base(typeof(ShowError))
        {
        }
    }
}
