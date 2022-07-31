using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Algoriths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Tests
{
    [TestClass()]
    public class PermutationsTests
    {


        [TestMethod()]
        public void PermutateArrayListTest_Mine()
        {
            var intArray = new int[] { 1, 2, 3 };

      
            var list = new List<IList<int>>();
            Algoriths.Permutations.PermutateArrayList(intArray, 0, intArray.Length - 1, list);
            foreach (var item in list)
            {
                Console.Out.WriteLine(string.Join("", item));

            }
        }

        [TestMethod()]
        public void PermutateArrayListTest()
        {
           var intArray = new int[] { 1, 2, 3 };
           var list = new List<IList<int>>();
           Algoriths.Permutations.DoPermute(intArray, 0, intArray.Length - 1, list);
           foreach (var item in list)
           {
               Console.Out.WriteLine(string.Join("",item));

           }
        }
    }
}