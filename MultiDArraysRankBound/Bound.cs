using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDArraysRankBound
{
    class Bound
    {
        public static void BMain()
        {
            float[,] tempsGrid = new float[4, 3];
            Console.WriteLine("Rank : " + tempsGrid.Rank);

            int xfrom = tempsGrid.GetLowerBound(0);
            int xto = tempsGrid.GetUpperBound(0);
            int yfrom = tempsGrid.GetLowerBound(1);
            int yto = tempsGrid.GetUpperBound(1);

            for (int x = xfrom; x <=xto; x++)
            {
                for (int y = yfrom; y <= yto; y++)
                {
                    tempsGrid[x, y] = x + 10 * y;
                }
            }

            for (int x = xfrom; x <= xto; x++)
            {
                for (int y = yfrom; y <= yto; y++)
                {
                    Console.Write(tempsGrid[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
