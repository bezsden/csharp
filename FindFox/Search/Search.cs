using System;
using System.Collections.Generic;
using System.Text;

namespace FindFox
{
    public class Search
    {
        public bool FoxState { get; set; } = false;
        public int IterationCounter { get; set; } = 0;
        public string Winer { get; set; }


        private int burrowId = 2;

        public int resultBurrow = 1;
        public string resultValue = "";


        public void Search1(Dictionary<int, bool> currentBurrows)
        {
            IterationCounter = ++IterationCounter;
            if (IterationCounter % 2 != 0)
            {
                Verify(burrowId, currentBurrows);
            }
            else
            {
                Verify(burrowId, currentBurrows);
                burrowId = ++burrowId;
                if (burrowId == 5) burrowId = 2;
            }
        }

        public void Search2(Dictionary<int, bool> currentBurrows)
        {
            IterationCounter = ++IterationCounter;
            if (IterationCounter < 8)
            {
                Verify(burrowId+2, currentBurrows);
            }
            else if (IterationCounter < 15)
            {
                Verify(burrowId + 1, currentBurrows);
            }
            else if (IterationCounter < 22)
            {
                Verify(burrowId, currentBurrows);
            }
            else
            {
                IterationCounter = 1;
                burrowId = 2;
                Verify(burrowId, currentBurrows);
            }
        }

        private bool Verify(int key, Dictionary<int, bool> burrows)
        {
            FoxState = burrows[key];
            if (FoxState)
            {
                resultBurrow = key;
                Winer = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name;
                resultValue = burrows[key].ToString();
            }
            return FoxState;
        }

    }
}
