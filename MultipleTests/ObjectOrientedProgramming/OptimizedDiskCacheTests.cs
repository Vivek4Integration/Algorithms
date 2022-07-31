using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.ObjectOrientedProgramming.Tests
{
    [TestClass()]
    public class OptimizedDiskCacheTests
    {
        [TestMethod()]
        public void Inheritance_BaseBoxing()
        {
            OptimizedDiskCache optimizedDiskCache = new OptimizedDiskCache();
            Cache cache = (Cache)optimizedDiskCache;
        }

        [TestMethod()]
        public void Inheritance_InvalidCasting()
        {
            var isSuccess = true;
            try
            {
                MemoryCache memoryCache = new MemoryCache();
                Cache cache = (Cache)memoryCache;
                DiskCache diskCache = (DiskCache)cache;
                isSuccess = false;
            }
            catch (Exception exception)
            {
                Console.Out.WriteLine(exception.Message);
                isSuccess = true;
            }

            Assert.IsTrue(isSuccess);
        }

        [TestMethod()]
        public void Inheritance_InvalidCastingDerivedClass()
        {
            var isSuccess = true;
            try
            {
                DiskCache diskCache = new DiskCache();
                OptimizedDiskCache optimizedDiskCache = (OptimizedDiskCache)diskCache;
                isSuccess = false;
            }
            catch (Exception exception)
            {
                Console.Out.WriteLine(exception.Message);
                isSuccess = true;
            }

            Assert.IsTrue(isSuccess);
        }

        [TestMethod()]
        public void Inheritance_InvalidCastingDerivedClassAlt()
        {
            var isSuccess = true;
            try
            {
                   Cache cache = new Cache();
                        MemoryCache memoryCache = (MemoryCache)cache;
                        isSuccess = false;
                   
               
            }
            catch (Exception exception)
            {
                Console.Out.WriteLine(exception.Message);
                isSuccess = true;
            }

            Assert.IsTrue(isSuccess);
        }

        [TestMethod()]
        public void Inheritance_ValidBoxing()
        {
            OptimizedDiskCache optimizedDiskCache = new OptimizedDiskCache();
            Cache cache = (Cache)optimizedDiskCache;
            DiskCache diskCache = (DiskCache)cache;
        }
    }
}