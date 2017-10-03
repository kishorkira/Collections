using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsBasic
{
    class CountLength
    {
       
        string[] DaysOfWeek =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thusday",
                "Friday",
                "saturday"
            };
        public void Count()
        {
            
            ICollection<string> collection = (ICollection<string>)DaysOfWeek;
            
            Console.WriteLine("count : " + DaysOfWeek.Count());
        }
        public void Length() => Console.WriteLine("count : " + DaysOfWeek.Length);
    }
}
