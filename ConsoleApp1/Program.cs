using System;
using System.Collections.Generic;

namespace BubleSort
{
    public class Program
    {
        
        private static readonly int[] Walls = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        public static void Main()
        {
            var result = GetLargestPoolArea(Walls);
            Console.WriteLine("The largest pool area is: " + result);
        }
        private static int GetLargestPoolArea(int[] walls)
        {
            List<int> allSquares = new List<int>();
            int result;
            for (int i = 0; i < Walls.Length; i++)
            {
                for (int g = i+1; g < Walls.Length; g++)
                {
                    if (Walls[i].CompareTo(Walls[g]) <= 0)
                    {
                        result = Walls[i] * (g-i);
                    }
                    else
                    {
                        result = Walls[g] * (g-i);
                    }
                    allSquares.Add(result);
                    Console.Write (" " + result);
                }
                Console.WriteLine();
            }
            allSquares.Sort();
            allSquares.Reverse();
            return allSquares[0];
        }
    }
}
