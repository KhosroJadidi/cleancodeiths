using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Interfaces
{
    interface IInstantFactory:IFactory
    {
        DateTime GetDateTime(int[] hourMinuteSecond);
        DateTime GetDateTime();
        List<Tuple<Instant, Instant>> GetListOfTuplesWithInstants();
        Instant GetInstant();
    }
}
