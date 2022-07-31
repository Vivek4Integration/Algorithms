using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.ObjectOrientedProgramming
{
    public class Cache { }

    public class DiskCache : Cache { }

    public class MemoryCache : Cache { }

    public class OptimizedDiskCache : DiskCache{}
}
