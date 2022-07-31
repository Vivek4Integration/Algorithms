using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Graph
{
    public class DisjointSetUnionByRank
    {
        public int[] Root;
        public int[] Rank;
        public DisjointSetUnionByRank(int size)
        {
            Root = new int[size];
            Rank = new int[size];
            for (int i = 0; i < size; i++)
            {
                Root[i] = i;
                Rank[i] = 1;
            }

            
        }

        public int Find(int x)
        {
            while (x != Root[x])
                x = Root[x];
            return x;
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootY != rootX)
            {
                if (Rank[rootX] > Rank[rootY])
                    Root[y] = rootX;
                else if (Rank[rootX] < Rank[rootY])
                    Root[x] = rootY;
                else
                {
                    Root[y] = rootX;
                    Rank[rootX] += 1;
                }
            }
        }

        public Boolean IsConnected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}
