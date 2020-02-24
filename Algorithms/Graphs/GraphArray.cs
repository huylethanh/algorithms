using System;

namespace Algorithms.Graphs
{
    public class GraphArray
    {
        public void Run()
        {
            int[,] graph = new int[,]
            {
                {0, 4, 0, 0, 0, 0, 0, 8, 0},
                {4, 0, 8, 0, 0, 0, 0, 11, 0},
                {0, 8, 0, 7, 0, 4, 0, 0, 2},
                {0, 0, 7, 0, 9, 14, 0, 0, 0},
                {0, 0, 0, 9, 0, 10, 0, 0, 0},
                {0, 0, 4, 14, 10, 0, 2, 0, 0},
                {0, 0, 0, 0, 0, 2, 0, 1, 6},
                {8, 11, 0, 0, 0, 0, 1, 0, 7},
                {0, 0, 2, 0, 0, 0, 6, 7, 0}
            };

            Dijkstra(graph, 0);
        }

        public void Dijkstra(int[,] graph, int start)
        {
            var length = graph.GetLength(1);
            var dist = new int[length];

            var travelled = new bool[length];

            for (int i = 0; i < length; i++)
            {
                dist[i] = int.MaxValue;
                travelled[i] = false;
            }

            dist[start] = 0;

            for (int i = 0; i < length; i++)
            {
                var u = MinIndex(dist, travelled);
                travelled[u] = true;

                for (int v = 0; v < length; v++)
                {
                    if (!travelled[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }

            printSolution(dist);
        }

        private int MinIndex(int[] dist, bool[] travelled)
        {
            var min = int.MaxValue;
            var minIndex = -1;

            for (int i = 0; i < dist.Length; i++)
            {
                if(!travelled[i] && dist[i]<min)
                {
                    min = dist[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        void printSolution(int[] dist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vertex \t\t Distance "
                          + "from Source\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < dist.Length; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");

            Console.ResetColor();
        }
    }
}
