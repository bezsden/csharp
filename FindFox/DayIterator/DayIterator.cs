using System;
using System.Collections.Generic;
using System.Text;

namespace FindFox
{
    public class DayIterator
    {
        //first day
        private int day = 0;

        public int Day { get => day; }
        public void PassTheDay()
        {
            day = ++day;
        }
    }
}
