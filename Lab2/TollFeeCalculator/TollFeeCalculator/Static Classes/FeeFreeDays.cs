using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.StaticClasses
{
    internal static class FeeFreeDays
    {
        private static readonly DayOfWeek saturday = DayOfWeek.Saturday;
        private static readonly DayOfWeek sunday = DayOfWeek.Sunday;

        internal static DayOfWeek[] FeeFreeDaysOfTheWeek 
            => new[] { saturday, sunday };
            
    }
}
