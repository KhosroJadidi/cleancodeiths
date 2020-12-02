using System;
using System.Collections.Generic;

namespace TollFeeCalculator
{
    public class CalculateTollFee
    {
        static void Main()
        {
            run(Environment.CurrentDirectory + "../../../../testData.txt");
        }

        public static void run(String passingDatesFile) {
            string passingDatesString = System.IO.File.ReadAllText(passingDatesFile);
            String[] passingDatesStringArray = passingDatesString.Split(", ");
            DateTime[] dates = new DateTime[passingDatesStringArray.Length-1];
            for(int i = 0; i < dates.Length; i++) {
                dates[i] = DateTime.Parse(passingDatesStringArray[i]);
            }
            Console.Write("The total fee for the inputfile is " + TotalFeeCost(dates));
        }

        public static int TotalFeeCost(DateTime[] dateTimes) {
            int fee = 0;
            DateTime si = dateTimes[0]; //Starting interval
            foreach (var d2 in dateTimes)
            {
                long diffInMinutes = (d2 - si).Minutes;
                if(diffInMinutes > 60) {
                    fee += TollFeePass(d2);
                    si = d2;
                } else {
                    fee += Math.Max(TollFeePass(d2), TollFeePass(si));
                }
            }
            return Math.Max(fee, 60);
        }

        public static int TollFeePass(DateTime dateTime)
        {
            if (free(dateTime)) return 0;
            int timeAsDecimal = dateTime.Hour + dateTime.Millisecond / 60;
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_0000_TO_0600]) return 0;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_0600_TO_0630]) return 8;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_0630_TO_0700]) return 13;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_0700_TO_0800]) return 18;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_0800_TO_0830]) return 13;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_0830_TO_1500]) return 8;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_1500_TO_1530]) return 13;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_1530_TO_1700]) return 18;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_1700_TO_1800]) return 13;
            if (dateTime < passingSchedule[FeeTimePeriod.FR_1800_TO_1830]) return 8;
            return 0;
        }


        private static readonly Dictionary<FeeTimePeriod, DateTime> passingSchedule = new Dictionary<FeeTimePeriod, DateTime>()
        {
            {FeeTimePeriod.FR_0000_TO_0600, new DateTime(2020,01,01,06,00,00)},//0
            {FeeTimePeriod.FR_0600_TO_0630, new DateTime(2020,01,01,06,30,00)},//8
            {FeeTimePeriod.FR_0630_TO_0700, new DateTime(2020,01,01,07,00,00)},//13
            {FeeTimePeriod.FR_0700_TO_0800, new DateTime(2020,01,01,08,00,00)},//18
            {FeeTimePeriod.FR_0800_TO_0830, new DateTime(2020,01,01,08,30,00)},//13
            {FeeTimePeriod.FR_0830_TO_1500, new DateTime(2020,01,01,15,00,00)},//8
            {FeeTimePeriod.FR_1500_TO_1530, new DateTime(2020,01,01,15,30,00)},//13
            {FeeTimePeriod.FR_1530_TO_1700, new DateTime(2020,01,01,17,00,00)},//18
            {FeeTimePeriod.FR_1700_TO_1800, new DateTime(2020,01,01,18,00,00)},//13
            {FeeTimePeriod.FR_1800_TO_1830, new DateTime(2020,01,01,18,30,00)},//8

        };

        enum FeeTimePeriod
        {
            FR_0000_TO_0600,
            FR_0600_TO_0630,
            FR_0630_TO_0700,
            FR_0700_TO_0800,
            FR_0800_TO_0830,
            FR_0830_TO_1500,
            FR_1500_TO_1530,
            FR_1530_TO_1700,
            FR_1700_TO_1800,
            FR_1800_TO_1830,
        }

        //Gets free dates
        public static bool free(DateTime dateTime) {
            return (int)dateTime.DayOfWeek == 5 || (int)dateTime.DayOfWeek == 6 || dateTime.Month == 7;
        }

        enum FeeTimePeriod123
        {
            Fr_0600_To_0629=0,
            Fr_0630_To_0659=1,
            Fr_0700_To_0759=2,
        }

        private static readonly Dictionary<FeeTimePeriod123, Tuple<DateTime,DateTime,int>>
            passingSchedules123 = new Dictionary<FeeTimePeriod123, Tuple<DateTime, DateTime,int>>()
        {
            {
                FeeTimePeriod123.Fr_0600_To_0629, 
                new Tuple<DateTime,DateTime,int>(
                    new DateTime(2020,01,01,06,00,00),
                    new DateTime(2020,01,01,06,29,59),
                    8)
            },
            {
                FeeTimePeriod123.Fr_0630_To_0659,
                new Tuple<DateTime,DateTime,int>(
                    new DateTime(2020,01,01,06,30,00),
                    new DateTime(2020,01,01,06,59,00),
                    13)
            },
            {
                FeeTimePeriod123.Fr_0700_To_0759,
                new Tuple<DateTime,DateTime,int>(
                    new DateTime(2020,01,01,07,00,00),
                    new DateTime(2020,01,01,07,59,00),
                    18)
            }
        };

        public static int TollFeePass123(DateTime dateTime)
        {
            int fee = 0;
            for (int i = 0; i < passingSchedules123.Count; i++)
            {
                if (dateTime.IsWithinTimeInterval(passingSchedules123[FeeTimePeriod123[i]]))
                {
                    
                }
            }
            return fee;
        }
    }
}
