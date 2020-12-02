using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TollFeeCalculator.StaticClasses
{
    internal static class IntervalStartAndEndHours
    {

        private static Tuple<int[], int[]> FR_0600_TO_0629 { get; }
            = new Tuple<int[], int[]>(new int[] { 6, 0, 0 }, new int[] { 6, 29, 59 });
        private static Tuple<int[], int[]> FR_0630_TO_0659 { get; }
            = new Tuple<int[], int[]>(new int[] { 6, 30, 0 }, new int[] { 6, 59, 59 });
        private static Tuple<int[], int[]> FR_0700_TO_0759 { get; }
            = new Tuple<int[], int[]>(new int[] { 7, 0, 0 }, new int[] { 7, 59, 59 });
        private static Tuple<int[], int[]> FR_0800_TO_0829 { get; }
            = new Tuple<int[], int[]>(new int[] { 8, 0, 0 }, new int[] { 8, 29, 59 });
        private static Tuple<int[], int[]> FR_0830_TO_1459 { get; }
            = new Tuple<int[], int[]>(new int[] { 8, 30, 0 }, new int[] { 14, 59, 59 });
        private static Tuple<int[], int[]> FR_1500_TO_1529 { get; }
            = new Tuple<int[], int[]>(new int[] { 15, 0, 0 }, new int[] { 15, 29, 59 });
        private static Tuple<int[], int[]> FR_1530_TO_1659 { get; }
            = new Tuple<int[], int[]>(new int[] { 15, 30, 0 }, new int[] { 16, 59, 59 });
        private static Tuple<int[], int[]> FR_1700_TO_1759 { get; }
            = new Tuple<int[], int[]>(new int[] { 17, 0, 0 }, new int[] { 17, 59, 59 });
        private static Tuple<int[], int[]> FR_1800_TO_1829 { get; }
            = new Tuple<int[], int[]>(new int[] { 18, 0, 0 }, new int[] { 18, 29, 59 });
        private static Tuple<int[], int[]> FR_1830_TO_0559 { get; }
            = new Tuple<int[], int[]>(new int[] { 18, 30, 0 }, new int[] { 5, 59, 59 });


        internal static Tuple<int[], int[]>[] IntervalStartAndEnds
            => new[]
            {
                FR_0600_TO_0629,
                FR_0630_TO_0659,
                FR_0700_TO_0759,
                FR_0800_TO_0829,
                FR_0830_TO_1459,
                FR_1500_TO_1529,
                FR_1530_TO_1659,
                FR_1700_TO_1759,
                FR_1800_TO_1829,
                FR_1830_TO_0559
            };
    }
}
