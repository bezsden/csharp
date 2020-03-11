using System;
using System.Collections.Generic;

namespace FindFox
{
    public class Fox
    {
        public string FoxName { get; set; } = "RedFox";

        public void GetIntoBurrow(Dictionary<int, bool> burrows)
        {
            int burrowId = new Random().Next(1, 5);
            burrows[burrowId] = true;

        }

        public void ChangeBurrow(Dictionary<int, bool> burrows)
        {
            int direction = new Random().Next(0, 1);

            int key = 0;

            foreach (KeyValuePair<int, bool> item in burrows)
            {
                if (item.Value==true)
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
                burrows[key] = true;

            }
        }
    }
}
