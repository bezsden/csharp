using System;
using System.Collections.Generic;
using System.Text;

namespace FindFox
{
    public class SearchTheFox
    {
        public bool IsFoxFound { get; set; } = false;
        public int IterationCounter { get; set; } = 0;
        private int SecondIterator { get; set; } = 0;

        private int burrowId = 2;

        public Burrow resultBurrow;

        public void Search(Fox wantedFox, Dictionary<int, Burrow> currentBurrows)
        {
            IterationCounter = ++IterationCounter;
            if (IterationCounter % 2 != 0)
            {
                currentBurrows.TryGetValue(burrowId, out Burrow value);
                Verify(value, wantedFox.currentBurrow);
            }
            else 
            {
                currentBurrows.TryGetValue(burrowId, out Burrow value);
                Verify(value, wantedFox.currentBurrow);
                burrowId = ++burrowId;
                if (burrowId == 5) burrowId = 2;
            }
        }

        private bool Verify(Burrow fromburrows, Burrow burrowWithFox) 
        {
            IsFoxFound = fromburrows.Equals(burrowWithFox);
            if (IsFoxFound) resultBurrow = fromburrows;
            return IsFoxFound;
        }
    }
}
