using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Multiple.Algoriths.Graph;

namespace Multiple.Problem
{
    public class Province
    {
      
            public int FindCircleNum(int[][] isConnected)
            {
                int[] parent = new int[isConnected.Length];
                for (int i = 0; i < parent.Length; i++)
                {
                    parent[i] = -1;
                }
                CompressionPathRoot disjointSetPathCompression = new CompressionPathRoot(isConnected.GetLength(0));
                for (int i = 0; i < isConnected.GetLength(0); i++)
                {
                    for (int j = 0; j < isConnected[i].Length; j++)
                    {
                        if (isConnected[i][j] != 0 && j!=i)
                        {
                            disjointSetPathCompression.Union( parent, i,j);
                        }
                    }
                }
                
                return parent.Where(x=>x==-1).Count();
            
            }

            public int FindProvince_DisjointSetQuickFind(int[][] isConnected)
            {
                int[] parent = new int[isConnected.Length];
                for (int i = 0; i < parent.Length; i++)
                {
                    parent[i] = -1;
                }
                DisjointSetQuickFind disjointSetPathCompression = new DisjointSetQuickFind(isConnected.GetLength(0));
                for (int i = 0; i < isConnected.GetLength(0); i++)
                {
                    for (int j = 0; j < isConnected[i].Length; j++)
                    {
                        if (isConnected[i][j] != 0 && j != i)
                        {
                            disjointSetPathCompression.Union( i, j);
                        }
                    }
                }

                int count = 0;
                for (int i = 0; i < disjointSetPathCompression.root.Length; i++)
                {
                    if (i == disjointSetPathCompression.root[i])
                        count++;
                }

                return count;
            }

    }
}
