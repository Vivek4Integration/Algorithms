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
    public class emailTests
    {
        [TestMethod()]
        public void NumUniqueEmailsTest()
        {
            string[] emailids = new[]
            {
                "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"
            };
           var result = email.NumUniqueEmails(emailids);
           Console.Out.WriteLine(result);
        }
    }
}