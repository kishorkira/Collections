using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
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
            //foreach (var day in DaysOfWeek) { Console.WriteLine(day); }
            //for (int i = 0; i < DaysOfWeek.Length; i++) { Console.WriteLine(DaysOfWeek[i]); }

            string[] CopyDaysOfWeek=new string[12];

            Array.Copy(DaysOfWeek,0, CopyDaysOfWeek,3,7);
            //foreach (var day in CopyDaysOfWeek) { Console.WriteLine(day+"s"); }
            int index=Array.IndexOf(CopyDaysOfWeek, "Monday");

            string[] DaysLength6= Array.FindAll(DaysOfWeek, x => x.Length == 6);

            foreach (var day in DaysLength6) { Console.WriteLine(day); }


        }
    }
}
