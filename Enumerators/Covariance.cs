using System;
using System.Collections.Generic;

namespace Enumerators
{
    class Covariance
    {
        public static void CMain()
        {
            string str = "Hi";
            Object obj = str;

            string[] s = new string[] { "hi", "Hi" };
            //bad code
            object[] lo = s;

            List<string> ls = new List<string> { "hi", "Hi" };
            //invalid code 
            //List<object> lo = (List<object>)ls;
            //lo[0]=3;

            //acceptable beacuse IEnumerable is readonly
            IEnumerable<object> objenum = ls;


        }
    }
}
