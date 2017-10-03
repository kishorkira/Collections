using System;

namespace MultiDArraysRankBound
{
    class MultiDArray
    {
        public static void MDAMain()
        {
            float[,] tempsGrid = new float[4, 3];
            Console.WriteLine("Rank : "+ tempsGrid.Rank);
            for(int x = 0; x < tempsGrid.GetLength(0); x++)
            {
                for(int y = 0; y < tempsGrid.GetLength(1); y++)
                {
                    tempsGrid[x,y] = x+10*y;
                }
            }

            for (int x = 0; x < tempsGrid.GetLength(0); x++)
            {
                for (int y = 0; y < tempsGrid.GetLength(1); y++)
                {
                    Console.Write(tempsGrid[x,y]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
