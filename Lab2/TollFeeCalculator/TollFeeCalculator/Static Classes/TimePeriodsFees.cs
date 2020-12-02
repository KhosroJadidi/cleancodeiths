using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.StaticClasses
{
    internal static class TimePeriodsFees
    {
        internal static int FR_0000_TO_0600 { get; } = 8;
        internal static int FR_0600_TO_0630 { get; } = 13;
        internal static int FR_0630_TO_0700 { get; } = 18;
        internal static int FR_0700_TO_0800 { get; } = 13;
        internal static int FR_0800_TO_0830 { get; } = 8;
        internal static int FR_0830_TO_1500 { get; } = 13;
        internal static int FR_1500_TO_1530 { get; } = 18;
        internal static int FR_1530_TO_1700 { get; } = 13;
        internal static int FR_1700_TO_1800 { get; } = 8;
        internal static int FR_1800_TO_1830 { get; } = 0;
    }
}
