using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Factory;

namespace TollFeeCalculatorTests
{
    [TestClass]
    public class InstantFactoryTests
    {
        [TestMethod]
        public void GetDateTimeTest()
        {
            var sut = new InstantFactory(new DateTime(1, 2, 3));
            var actual= sut.GetDateTime( new int[] { 4,5,6 });
            var expected = new DateTime(1, 2, 3, 4, 5, 6);
            Assert.AreEqual(expected, actual);

        }

        
    }
}
