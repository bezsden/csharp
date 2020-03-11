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

            while (!Atu.IsFoxFound)
            {
                Atu.Search1(burrows);
                Atu.Search2(burrows);
                Console.WriteLine("{0} Fox in burrow {1} marker {2}, iterations {3}", Atu.Winer, Atu.resultBurrow, burrows[Atu.resultBurrow], Atu.IterationCounter);
                Console.WriteLine("{0} Fox in burrow {1} marker {2}, iterations {3}", Atu.Winer, Atu.resultBurrow2, burrows[Atu.resultBurrow2], Atu.IterationCounter2);
                Console.ReadLine();
                if (Atu.IsFoxFound == true && Atu.IsFoxFound2 == true) break;
                redFox.ChangeBurrow(burrows);
                
                
            }

           


            Console.ReadLine();

        }
    }
}
