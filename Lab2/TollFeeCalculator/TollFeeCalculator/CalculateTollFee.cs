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
            
            return 0;
        }


        

        

        //Gets free dates
        public static bool free(DateTime dateTime) {
            return (int)dateTime.DayOfWeek == 5 || (int)dateTime.DayOfWeek == 6 || dateTime.Month == 7;
        }

        

        

        



        
    }
}
