using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class PathExists
    {
        
            public static bool ValidPath(int n, int[][] edges, int source, int destination)
            {
                
                var adjacencyList = new Hashtable();
                for (int i = 0; i < n; i++)
                {
                    adjacencyList[i] = new List<int>();

                }

                for (int i = 0; i < edges.Length; i++)
                {
                    var edge = edges[i];
                    
                        ((List<int>)adjacencyList[edge[0]]).Add(edge[1]);
                        ((List<int>)adjacencyList[edge[1]]).Add(edge[0]);
                        
                   

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
                foreach (int i in (List<int>)adjacencyList[node])
                    {
                        stack.Push(i);
                    }
                }

                return false;







                

            }
        
    }
}
