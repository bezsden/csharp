using System;
using System.Collections.Generic;


namespace FindFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, bool> burrows = new Dictionary<int, bool>();

            burrows.Add(1, false);
            burrows.Add(2, false);
            burrows.Add(3, false);
            burrows.Add(4, false);
            burrows.Add(5, false);

            Fox redFox = new Fox();
            redFox.GetIntoBurrow(burrows);

            Search Atu = new Search();
            Search Atu2 = new Search();

            while (true)
            {
                if (!Atu.FoxState) Atu.Search1(burrows);
                if (!Atu2.FoxState) Atu2.Search2(burrows);
                if (Atu2.FoxState == true & Atu.FoxState == true) break;
                redFox.ChangeBurrow(burrows);
            }

            Console.WriteLine("{0} Fox in burrow {1} marker {2}, iterations {3}", Atu.Winer, Atu.resultBurrow, Atu.resultValue, Atu.IterationCounter);
            Console.WriteLine("{0} Fox in burrow {1} marker {2}, iterations {3}", Atu2.Winer, Atu2.resultBurrow, Atu2.resultValue, Atu2.IterationCounter);

            Console.ReadLine();



        }
    }
}
