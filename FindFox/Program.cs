using System;
using System.Collections.Generic;


namespace FindFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Burrow> burrows = new Dictionary<int, Burrow>();

            burrows.Add(1,new Burrow("one"));
            burrows.Add(2, new Burrow("two"));
            burrows.Add(3, new Burrow("three"));
            burrows.Add(4, new Burrow("four"));
            burrows.Add(5, new Burrow("five"));

            Fox redFox = new Fox();
            redFox.GetIntoBurrow(burrows);

            SearchTheFox Atu = new SearchTheFox();

            while (!Atu.IsFoxFound)
            {
                Atu.Search(redFox, burrows);
                redFox.ChangeBurrow(burrows);
            }

            Console.WriteLine("Fox found foxburrow is {0}, Looked burrow is {1}, iterations {2}", redFox.currentBurrow.ToString(), Atu.resultBurrow.ToString(), Atu.IterationCounter);
            Console.ReadLine();

        }
    }
}
