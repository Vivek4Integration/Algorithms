using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class DirectedAcyclicGraph
    {
        public static List<List<int>> AllPathsSourceTarget(int[][] graph)
        {
            var adjacencyList = new Dictionary<int, List<int>>();
            for (int i = 0; i < graph.Length; i++)
            {
                adjacencyList[i] = new List<int>();

            }

            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; graph[i] != null && j <  graph[i].Length  ; j++)
                {
                    if(graph[i][j]!=null)
                    adjacencyList[i].Add(graph[i][j]);
                }
                
            }
            var routes = new List< List<int>>();

            Stack<int> stack = new Stack<int>();
            
            stack.Push(0);
            int routeIndex = 0;
            routes.Add(new List<int>());
            
            var pathfound = false;
            
                while (stack.Count > 0)
                {
                    int node = stack.Pop();
                    routes[routeIndex].Add(node);
                    if (node == graph.Length - 1)
                    {
                        pathfound = true;
                        routeIndex++;
                        routes.Add(new List<int>());
                        Stack<int> tempStack = new Stack<int>();
                        for (int i = 0; i < stack.Count; i++)
                        {
                            var a = stack.Pop();
                            tempStack.Push(a);
                            routes[routeIndex].Add(a);
                        }

                        for (int i = 0; i < tempStack.Count ; i++)
                        {
                            stack.Push(tempStack.Pop());
                        }
                        // continue;
                    }

                  

                    
                    foreach (int i in (List<int>)adjacencyList[node])
                    {
                        stack.Push(i);
                    }
               

                //if (pathfound)
                //{
                //    //routeIndex++;
                //    //routes.Add(new List<int>());
                //    //stack.Clear();
                //    //stack.Push(0);
                    
                //    pathfound = false;
                //}
                //else
                //{
                //    break;
                //}
            }

            return routes;
        }
    }
}
