using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Algoriths;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Tests
{
    [TestClass()]
    public class RansomNoteTests
    {
        [TestMethod()]
        public void CanConstructTest()
        {
            RansomNote ransonNote = new RansomNote();
            Assert.IsFalse(ransonNote.CanConstruct("aa", "ab"));

        }

        [TestMethod()]
        public void CanConstructTest_LargeData_Hashset()
        {
            Stopwatch sw = Stopwatch.StartNew();
            RansomNote ransonNote = new RansomNote();
            Assert.IsTrue(ransonNote.CanConstruct(File.ReadAllText("Files\\Extract.txt"),
                File.ReadAllText("Files\\FullArticle.txt")));
            sw.Stop();
            Console.Out.WriteLine(sw.Elapsed.TotalMilliseconds);

        }

        [TestMethod()]
        public void CanConstructTest_LargeData_Dictionary()
        {
            Stopwatch sw = Stopwatch.StartNew();
            RansomNote_With_Dictionary ransonNote = new RansomNote_With_Dictionary();
            Assert.IsTrue(ransonNote.CanConstruct(File.ReadAllText("Files\\Extract.txt"),
                File.ReadAllText("Files\\FullArticle.txt")));
            sw.Stop();
            Console.Out.WriteLine(sw.Elapsed.TotalMilliseconds);
        }

        
    }
}