using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    #region Question (1)
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public void Display()
        {
            Console.WriteLine($"Duration: {Hours}:{Minutes}:{Seconds}");
        }
        #endregion
    }
}
