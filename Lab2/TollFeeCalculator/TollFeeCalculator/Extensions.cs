using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public static class Extensions
    {
        public static bool IsWithinTimeInterval(
            this DateTime time,
            Tuple<DateTime,DateTime> interval)
        {
            bool isWithinInterval = false;
            if (interval.Item1 < time && time < interval.Item2)
                isWithinInterval = true;
            return isWithinInterval;
        }
    }
}
