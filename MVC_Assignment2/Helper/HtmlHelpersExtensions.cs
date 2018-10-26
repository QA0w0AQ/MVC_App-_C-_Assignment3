using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment2.Helper
{
    public static class HtmlHelpersExtensions
    {
        public static IHtmlString BootstrapModalWindow(this HtmlHelper helper)
        {
            var someInfo = "hello";
            return new HtmlString(someInfo);
        }
    }
}