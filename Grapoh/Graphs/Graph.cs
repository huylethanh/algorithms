using System;
using System.Collections.Generic;

namespace Grapoh.Graphs
{
    public class Graph
    {
        private int _v;
        private readonly LinkedList<Vector<int>>[] _adj;

        public Graph(int v)
        {
            _v = v;
            _adj = new LinkedList<Vector<int>>[v];

            for (int i = 0; i < _v; i++)
            {
                _adj[i] = new LinkedList<Vector<int>>();
            }
        }

        public void AddEdge(int src, int dest, int distance)
        {
            _adj[src].AddLast(new Vector<int>(src, dest, distance));
            _adj[dest].AddFirst(new Vector<int>(dest, src, distance));
        }

        public void PrintGraph()
        {
            for (int v = 0; v < _v; v++)
            {
                Console.ResetColor();
                WriteLine("Adjacency list of vertex " + v);
                WriteLine("Head");

                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var item in _adj[v])
                {
                    Write(" node " + v);
                    WriteLine(" -> " + item);
                }

                WriteLine("");
            }
        }

        public void DFTravel(int v)
        {
            bool[] visited = new bool[_v];
            Write("Start --> " + v);
            DFTravel(v, visited);
        }


        public void BFTravel(int v)
        {
            Write("Start --> " + v);
            bool[] visited = new bool[_v];
            var queue = new Queue<Vector<int>>();
            visited[v] = true;

            var current = _adj[v].First.Value;

            do
            {
                foreach (var item in _adj[current.Source])
                {
                    var next = _adj[item.Dest].First.Value;
                    if (!visited[next.Source])
                    {
                        queue.Enqueue(next);
                        visited[next.Source] = true;
                    }
                }

                current = queue.Dequeue();
                Write(" next-> " + current.Source);

            } while (queue.Count != 0);
        }

        private void DFTravel(int v, bool[] visited)
        {
            visited[v] = true;
            var current = _adj[v];

            foreach (var item in current)
            {
                if (visited[item.Dest])
                {
                    continue;
                }

                Write(" next-> " + item);
                DFTravel(item.Dest, visited);
            }
        }

        public void FindShortPath(int start, int to)
        {
            var calculatedPath = new int[_v];

            for (int i = start; i < _v; i++)
            {
                calculatedPath[i] = Int32.MaxValue;
            }

            calculatedPath[start] = 0;
            var paths = new int?[_v];

            for (int i = start; i < _v; i++)
            {
                FindShortPath(i, calculatedPath, paths);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Calculated path");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < _v; i++)
            {
                Write(i);
                Write("  ------  ");
                WriteLine(calculatedPath[i]);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"shortest path from {start} dest {to}");

            for (int i = _v - 1; i >= 0; i--)
            {
                PrintPath(i, paths);
                WriteLine("");
            }

            Console.ResetColor();
        }

        private void PrintPath(int to, int?[] paths)
        {
            Write(to + " ");
            if (paths[to] == null)
            {
                return;
            }

            PrintPath(paths[to].Value, paths);
        }

        private void FindShortPath(int v, int[] foundPath, int?[] paths)
        {
            var current = _adj[v];

            foreach (var item in current)
            {
                CalculatePath(item, foundPath, paths);
            }
        }

        private void CalculatePath(Vector<int> current, int[] foundPath, int?[] paths)
        {
            var total = current.Distance + foundPath[current.Source];
            if (total < foundPath[current.Dest])
            {
                paths[current.Dest] = current.Source;
                foundPath[current.Dest] = total;
                FindShortPath(current.Dest, foundPath, paths);
            }
        }

        private void WriteLine(object message)
        {
            Console.WriteLine(message);
        }

        private void Write(object message)
        {
            Console.Write(message);
        }
    }

    public class Vector<T>
    {
        public Vector(T source, T dest, int distance)
        {
            Source = source;
            Dest = dest;
            Distance = distance;
        }

        public T Source { get; set; }

        public T Dest { get; set; }

        public int Distance { get; set; }

        public override string ToString()
        {
            return Dest.ToString();
        }
    }
}