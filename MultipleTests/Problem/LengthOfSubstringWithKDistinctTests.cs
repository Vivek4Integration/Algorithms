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
    public class LengthOfSubstringWithKDistinctTests
    {
        [TestMethod()]
        public void LengthOfSubstringWithKDistinctHelperTest()
        {
          Console.Out.WriteLine(  LengthOfSubstringWithKDistinct.LengthOfSubstringWithKDistinctHelper("eceba", 2));
        }

       
    }
}