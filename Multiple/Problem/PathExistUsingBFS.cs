using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class PathExistUsingBFS
    {
        public static bool ValidPath(int n, int[][] edges, int source, int destination)
        {

            var adjacencyList = new Dictionary<int, List<int>>();
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

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);
            Boolean[] seen = new bool[n];
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                if (node == destination)
                {
                    return true;
                }

               
                foreach (int i in adjacencyList[node])
                {
                    if (!seen[i])
                    {
                        seen[node] = true;
                        queue.Enqueue(i);
                    }
                }
            }

            return false;









        }
    }
}
