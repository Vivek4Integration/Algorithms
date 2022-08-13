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
    public class CyclicWordTests
    {
        [TestMethod()]
        public void IsCyclicWordTest()
        {
            var wordArray = new string[]
            {
                "apple", "eggs", "snack", "karat", "tuna"

            };
            CyclicWord cyclic = new CyclicWord(wordArray);

           Console.Out.WriteLine(cyclic.IsCyclicWord(wordArray[0], wordArray[0], wordArray.Length));
        }
    }
}