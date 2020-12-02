using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Interfaces;
using TollFeeCalculator.StaticClasses;

namespace TollFeeCalculator.Factory
{
    public class InstantFactory : IInstantFactory
    {
        private Tuple<int[], int[]>[] intervals;
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private int second;

        public InstantFactory(DateTime dateTime) 
        {
            intervals = IntervalStartAndEndHours.IntervalStartAndEnds;
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
            hour = dateTime.Hour;
            minute = dateTime.Minute;
            second = dateTime.Second;
        }

        public DateTime GetDateTime(int[]hourMinuteSecond)
        {
            var date = new DateTime
                (
                    year,
                    month,
                    day,
                    hourMinuteSecond[0],
                    hourMinuteSecond[1],
                    hourMinuteSecond[2]
                );
            return date;
        }

        public DateTime GetDateTime()
        {
            return new DateTime(year, month, day, hour, minute, second);
        }
        public List<Tuple<Instant, Instant>>GetListOfTuplesWithInstants()
        {
            List<Tuple<Instant, Instant>> instants=null;
            foreach (var IntervalStartAndEnd in intervals)
            {
                var startDate = GetDateTime(IntervalStartAndEnd.Item1);
                var startInstant = Instant.FromDateTimeUtc(startDate);
                var endDate = GetDateTime(IntervalStartAndEnd.Item2);
                var endInstant = Instant.FromDateTimeUtc(endDate);
                var tuple = new Tuple<Instant, Instant>(startInstant, endInstant);
                instants.Add(tuple);
            }
            return instants;
        }

        public Instant GetInstant()
        {
            var date = GetDateTime();
            return Instant.FromDateTimeUtc(date);
        }

    }
}
