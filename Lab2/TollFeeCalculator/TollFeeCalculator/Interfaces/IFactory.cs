using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Interfaces
{
    public interface IFactory
    {
        virtual object Create() { throw new NotImplementedException(); }
    }
}
