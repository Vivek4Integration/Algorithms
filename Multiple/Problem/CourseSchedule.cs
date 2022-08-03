using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class CourseSchedule
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var adjacencyList = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                adjacencyList[i] = new List<int>();

            }

            for (int i = 0; i < prerequisites.Length; i++)
            {

               
                    adjacencyList[prerequisites[i][0]].Add(prerequisites[i][1]);


               
            }

            for (int ii = 0; ii < numCourses; ii++)
            {
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(ii);
                Boolean[] seen = new bool[numCourses];
                while (queue.Count > 0)
                {
                    int node = queue.Dequeue();
                    


                    foreach (int i in adjacencyList[node])
                    {
                        if (!seen[i])
                        {
                            seen[node] = true;
                            queue.Enqueue(i);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            

            return true;
        }

        public  bool CanFinish_Joma(int numCourses, int[][] prerequisites)
        {
            var adjacencyList = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                adjacencyList[i] = new List<int>();

            }

            for (int i = 0; i < prerequisites.Length; i++)
            {


                adjacencyList[prerequisites[i][0]].Add(prerequisites[i][1]);



            }

            for (int i = 0; i < adjacencyList.Count; i++)
            {
                if (visit(i, adjacencyList, new List<int>()))
                    return false;
            }

            return true;
        }

        private  Boolean visit(int vertex, Dictionary<int, List<int>> adjacencyList, List<int> visited)
        {
            visited.Add(vertex);
            foreach(var neighbour in adjacencyList[vertex])
            {
                if (visited.Contains(neighbour) || visit(neighbour, adjacencyList, visited))
                    return true;
                
            }

            visited.RemoveAt(visited.Count-1);
            return false;
        }

        public bool canFinish_Leet(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            Dictionary<int, Boolean> seen = new Dictionary<int, Boolean>();
            int[] indegree = new int[numCourses];
            Queue<int> q = new Queue<int>();
            int count = 0;

            // Building the graph
            foreach (var courses in prerequisites)
            {
                int to = courses[0];
                int from = courses[1];
                map[from] = new List<int>();
                var list = new List<int>();
                list.Add(to);
                map[from] = list;
                indegree[to]++;
            }

            // Implementation of Kahn's Alg
            for (int i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0) q.Enqueue(i);
            }
            while (q.Count>0)
            {
                int node = q.Peek();
                q.Dequeue();
                count++;
                if (map.ContainsKey(node))
                {
                    foreach (int nei in map[node])
                    {
                        indegree[nei]--;
                        if (indegree[nei] == 0)
                        {
                            q.Enqueue(nei);
                        }
                    }
                }
            }
            return count == numCourses;
        }
    }
}
