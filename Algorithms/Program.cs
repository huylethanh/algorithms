using System;
using System.Collections.Generic;
using Algorithms.Arrays;
using Algorithms.Graphs;
using Algorithms.ReactiveX;
using Algorithms.Sorting;
using Algorithms.Strings;

namespace Grapoh
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapSortTest();
            Console.ReadKey();
        }

        private static void HeapSortTest()
        {
            var heapSort = new HeapSort();
            heapSort.Run();
        }

        private static void SelectTransformationTest()
        {
            var abc = new SelectTransformation();
            abc.Run();
        }

        private static void ReplaceElementsWithMaximumElementOnRightTest()
        {
            var abc = new ReplaceElementsWithMaximumElementOnRight();
            abc.Run();
        }

        private static void FindNumberSubsetWithProductLessThanKTest()
        {
            var arr = new NumberSubsetWithProductLessThanK();
            arr.Run();
        }

        private static void FindUniqueSubsetsWithGivenSumTest()
        {
            var arr = new UniqueSubsetsWithGivenSum();
            arr.Run();
        }

        private static void ThreeSumCloseZerest()
        {
            var arr = new ThreeSumCloseZero();
            arr.Run();
        }

        private static void StringTest()
        {
            StringAnagram a = new StringAnagram();
            var result = a.IsAnagram("post", "stop");
            WriteLine("Is Anagram: " + result);
        }

        private static void GraphArrayTest()
        {
            var graph = new GraphArray();
            graph.Run();
        }

        private static void GraphTest()
        {
            var graph = new Graph(9);

            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(5, 4, 10);

            //graph.AddEdge(0, 1, 1);
            //graph.AddEdge(0, 7, 2);
            //graph.AddEdge(1, 2, 3);
            //graph.AddEdge(1, 7, 4);
            //graph.AddEdge(2, 3, 5);
            //graph.AddEdge(2, 5, 2);
            //graph.AddEdge(2, 8, 4);
            //graph.AddEdge(7, 8, 3);
            //graph.AddEdge(7, 6, 8);
            //graph.AddEdge(6, 8, 1);
            //graph.AddEdge(6, 5, 2);
            //graph.AddEdge(3, 4, 1);
            //graph.AddEdge(3, 5, 1);
            //graph.AddEdge(5, 4, 6);

            graph.PrintGraph();

            var startV = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Begin Deep First Travle");
            Console.ResetColor();

            graph.DFTravel(startV);

            Console.WriteLine();
            Console.WriteLine();

            startV = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Begin Deep First Travle");
            Console.ResetColor();

            graph.BFTravel(startV);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Find shortest path, starting node: ");
            var start = 0;

            graph.FindShortPath(start, 4);
        }

        private static void WriteLine(object message)
        {
            Console.WriteLine(message);
        }

        private static void Write(object message)
        {
            Console.Write(message);
        }
    }
}