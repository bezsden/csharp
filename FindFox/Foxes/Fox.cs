using System;
using System.Collections.Generic;

namespace FindFox
{
    public class Fox
    {
        public string FoxName { get; set; } = "RedFox";

        public Burrow currentBurrow { get; set; }

        public void GetIntoBurrow(Dictionary<int, Burrow> burrows)
        {
            int burrowId = new Random().Next(1, 5);
            burrows.TryGetValue(burrowId, out Burrow burrowName);
            currentBurrow = burrowName;
        }

        public void ChangeBurrow(Dictionary<int, Burrow> burrows)
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

            if (direction == 1 && burrows.ContainsKey(key + 1))
            {
                ChangeBurrow(key + 1);
            }
            else if (direction == 1 && !burrows.ContainsKey(key + 1))
            {
                ChangeBurrow(key - 1);
            }
            else if (direction == 0 && burrows.ContainsKey(key - 1))
            {
                ChangeBurrow(key - 1);
            }
            else if (direction == 0 && !burrows.ContainsKey(key - 1))
            {
                ChangeBurrow(key + 1);
            }
            else throw new NotImplementedException();

            void ChangeBurrow(int key)
            {
                burrows.TryGetValue(key, out Burrow burrowName);
                currentBurrow = burrowName;
            }
        }
    }
}
