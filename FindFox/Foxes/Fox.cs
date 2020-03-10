using System;
using System.Collections.Generic;
using System.Text;

namespace FindFox
{
    public class Fox
    {
        public string FoxName { get; set; } = "RedFox";

        public Burrow GetIntoBurrow(Dictionary<int, Burrow> burrows)
        {
            int burrowId = new Random().Next(1,5);
            burrows.TryGetValue(burrowId, out Burrow burrowName);
            return burrowName;
        }

        public Burrow ChangeBurrow(Dictionary<int, Burrow> burrows, Burrow currentBurrow)
        {
            int direction = new Random().Next(0, 1);

            int key = 0;

            foreach (KeyValuePair<int, Burrow> item in burrows)
            {
                if (EqualityComparer<Burrow>.Default.Equals(item.Value, currentBurrow))
                {
                    key = item.Key;
                    break;
                }
            }

            if (direction == 1)
            {
                burrows.TryGetValue(key + 1, out Burrow burrowName);
                return burrowName;
            }
            else
            {
                burrows.TryGetValue(key - 1, out Burrow burrowName);
                return burrowName;
            }
                       
        }
    }
}
