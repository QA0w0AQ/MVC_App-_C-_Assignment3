﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment2.Models.ExtensionMethod
{
    public static class ExtensionMethod2
    {
        public static string ToDigitsOnly(this string str)
        {
            return new string(str.ToArray().Where(p=>char.IsDigit(p)).ToArray());
            
        }
    }
}