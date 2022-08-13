using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem.Tests
{
    [TestClass()]
    public class MinCoinDenominationTests
    {
        [TestMethod()]
        public void CoinChangeTest()
        {
          Console.Out.WriteLine((new MinCoinDenomination()).CoinChange(new[] { 1, 2, 5 }, 11));
        }
    }
}