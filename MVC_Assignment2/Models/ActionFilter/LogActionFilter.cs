using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment2.Models.ActionFilter
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
          bool isCrawler =  HttpContext.Current.Request.Browser.Crawler;
            if (isCrawler)
            {
                filterContext.Result = new EmptyResult();
            }
           
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }
    }
}