using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class DirectedAcyclic_OthersSolution
    {
        public static IList<IList<int>> allPathsSourceTarget(int[][] graph)
        {
            List<IList<int>> paths = new List<IList<int>>();
            if (graph == null || graph.Length == 0)
            {
                return paths;
            }

            dfs(graph, 0, new List<int>(), paths);
            return paths;
        }

        private static void dfs(int[][] graph, int node, List<int> path, List<IList<int>> paths)
        {
            path.Add(node);
            if (node == graph.Length - 1)
            {
                paths.Add(new List<int>(path));
                return;
            }
            int[] nextNodes = graph[node];
            foreach (var nextNode in nextNodes)
            {
               dfs(graph, nextNode, path,paths);
               path.RemoveAt(path.Count-1);
            }
        }
    }
}
