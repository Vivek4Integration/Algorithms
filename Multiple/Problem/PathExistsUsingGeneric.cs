using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class PathExistsUsingGeneric
    {
        
            public static bool ValidPath(int n, int[][] edges, int source, int destination)
            {
                
                var adjacencyList = new Dictionary<int,List<int>>();
                for (int i = 0; i < n; i++)
                {
                    adjacencyList[i] = new List<int>();

                }

                for (int i = 0; i < edges.Length; i++)
                {
                    var edge = edges[i];
                    adjacencyList[edge[0]].Add(edge[1]);
                    adjacencyList[edge[1]].Add(edge[0]);

                }

                Stack<int> stack = new Stack<int>();
                stack.Push(source);
                Boolean[] seen = new bool[n];
                while (stack.Count > 0)
                {
                    int node = stack.Pop();
                    if (node == destination)
                    {
                        return true;
                    }

                    if(seen[node])
                        continue;
                    seen[node] = true;
                foreach (int i in adjacencyList[node])
                    {
                        stack.Push(i);
                    }
                }

                return false;







                

            }
        
    }
}
