using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Graph
{
    
    public class DisjointSetQuickFind
    {
        public int[] root;

        public DisjointSetQuickFind(int size)
        {
            root = new int[size];
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        public int Find(int x)
        {
            return root[x];
        }

        public void Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);
            if (rootX != rootY)
            {
                for (int i = 0; i < root.Length; i++)
                {
                    if(root[i]==rootY)
                        root[i]=rootX;
                }
            }

        }

        public Boolean IsConnected(int x, int y)
        {
            return root[x] == root[y];
        }
    }
}
