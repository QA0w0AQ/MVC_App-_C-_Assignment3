using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment2.Models.ExtensionMethod
{
    public static class ExtensionMethod1
    {
        public static int ToAge(this DateTime dateTime)
        {
            var rightTime = DateTime.Now;
            int age;
            int RY = rightTime.Year;
            int DY = dateTime.Year;
            age = RY - DY;
           
            //new DateTime(1990, 01, 01).ToAge();
            //new DateTime(1987, 05, 07).ToAge();
            //new DateTime(1975, 10, 10).ToAge();     

            return age;

        }
    }
}