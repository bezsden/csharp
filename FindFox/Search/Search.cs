using System;
using System.Collections.Generic;
using System.Text;

namespace FindFox
{
    public class Search
    {
        public bool IsFoxFound { get; set; } = false;
        public bool IsFoxFound2 { get; set; } = false;
        public int IterationCounter { get; set; } = 0;
        public int IterationCounter2 { get; set; } = 0;
        public string Winer { get; set; }


        private int burrowId = 2;
        private int burrowId2 = 4;

        public int resultBurrow = 1;
        public int resultBurrow2 = 1;

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
            IterationCounter2 = ++IterationCounter2;
            if (IterationCounter2 < 8)
            {
                Verify2(burrowId2, currentBurrows);
            }
            else if (IterationCounter2 < 15)
            {
                Verify2(burrowId2 - 1, currentBurrows);
            }
            else if (IterationCounter2 < 22)
            {
                Verify2(burrowId2 - 2, currentBurrows);
            }
            else
            {
                IterationCounter2 = 1;
                burrowId2 = 4;
                Verify2(burrowId2, currentBurrows);
            }
        }

        private bool Verify(int key, Dictionary<int, bool> burrows)
        {
            IsFoxFound = burrows[key];
            if (IsFoxFound)
            {
                resultBurrow = key;
                Winer = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name;
            }
            return IsFoxFound;
        }
        private bool Verify2(int key, Dictionary<int, bool> burrows)
        {
            IsFoxFound2 = burrows[key];
            if (IsFoxFound2)
            {
                resultBurrow2 = key;
                Winer = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name;
            }
            return IsFoxFound2;
        }
    }
}
