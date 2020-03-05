using System;
using System.Collections.Generic;


namespace FindFox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Burrow> burrows = new List<Burrow>();
            burrows.Add(new Burrow { BurrowName = "Burrow1" });
            burrows.Add(new Burrow { BurrowName = "Burrow2" });
            burrows.Add(new Burrow { BurrowName = "Burrow3" });
            burrows.Add(new Burrow { BurrowName = "Burrow4" });
            burrows.Add(new Burrow { BurrowName = "Burrow5" });

            Fox redFox = new Fox();
            redFox.FoxName = "RedFox";

            int turn = 0 ;


        }
    }
}
