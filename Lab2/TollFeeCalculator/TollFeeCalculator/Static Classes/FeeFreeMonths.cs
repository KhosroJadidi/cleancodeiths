using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.StaticClasses
{
    internal static class FeeFreeMonths
    {
        private static Tuple<DateTime, DateTime> july =
            new(new DateTime(2020, 07, 00), new DateTime(2020, 07, 31));

        internal static Tuple<DateTime, DateTime>[] FeeFreeMonthsCollection =>
            new [] { july };
    }
}
