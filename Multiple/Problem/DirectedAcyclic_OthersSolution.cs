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

        /// <summary>
        /// Depth first search for finding all paths between two nodes in directional graph.
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="node"></param>
        /// <param name="path"></param>
        /// <param name="paths"></param>
        /// <remarks>The visited is not looked up as in directional graph, it can be ignored</remarks>
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

               //removing last node that got added to path, as new route has to be plotted.
               path.RemoveAt(path.Count-1);
            }
        }
    }
}
