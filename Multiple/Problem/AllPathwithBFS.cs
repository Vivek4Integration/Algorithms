using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class AllPathwithBFS
    {
        public static IList<IList<int>> allPathsSourceTarget(int[][] graph)
        {
            List<IList<int>> paths = new List<IList<int>>();
            if (graph == null || graph.Length == 0)
                return paths;
            Queue<List<int>> queue = new Queue<List<int>>();
            var path = new List<int>();
            path.Add(0);
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                var currentPath = queue.Dequeue();
                int node = currentPath[currentPath.Count - 1];
                foreach (int nextNode in graph[node])
                {
                    List<int> temporaryPath = new List<int>(currentPath);
                    temporaryPath.Add(nextNode);
                    if(nextNode==graph.Length-1)
                        paths.Add(new List<int>(temporaryPath));
                    else
                    {
                        queue.Enqueue(temporaryPath);
                    }
                }
            }

            return paths;

        }
    }
}
