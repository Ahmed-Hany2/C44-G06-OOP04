using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    #region Question (1, 2)
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            string result = $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            return result;
        }
        #endregion

        #region Question (3)
        public int ToSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() + d2.ToSeconds());
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.ToSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() - d2.ToSeconds());
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.ToSeconds() - 60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }
        #endregion
    }
}
