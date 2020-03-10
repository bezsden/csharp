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
            Burrow burrow = redFox.GetIntoBurrow(burrows);

            int iteration = 0;


        }
    }
}
