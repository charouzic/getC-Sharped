using System;
namespace getInShape
{
    public class Tortoise
    {
        public int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return null;
            }

            double time = ((double)g / (double)(v2 - v1));

            var timeSpan = TimeSpan.FromHours(time);
            int hh = timeSpan.Hours;
            int mm = timeSpan.Minutes;
            int ss = timeSpan.Seconds;

            int[] timeEven = new int[] { hh, mm, ss };
            return timeEven;
        }
    }
}
