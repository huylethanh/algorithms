using System;
using Algorithms.Arrays;
using Algorithms.Graphs;
using Algorithms.LeetCode;
using Algorithms.ReactiveX;
using Algorithms.Searching;
using Algorithms.Sorting;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IntegerToEnglishWords();
            //IntergerToRoman();
            //RomanToInterger();
            //ReverseVowels();
            //SingleNumber();
            //FirstMissingPositive();
            //TwoSum();
            ShortestPalindrome();
            Console.ReadKey();
        }

        private static void ShortestPalindrome()
        {
            var c = new ShortestPalindrome();
            c.Run();
        }

        private static void TwoSum()
        {
            var c = new TwoSum();
            c.Run();
        }

        private static void FirstMissingPositive()
        {
            var c = new FirstMissingPositive();
            c.Run();
        }

        private static void FindDuplicate()
        {
            var c = new FindDuplicate();
            c.Run();
        }

        private static void SingleNumber()
        {
            var c = new SingleNumber();
            c.Run();
        }

        private static void ReverseVowels()
        {
            var c = new ReverseVowels();
            c.Run();
        }

        private static void ClimbStairs()
        {
            var c = new ClimbStairs();
            c.Run();
        }

        private static void IntegerToEnglishWords()
        {
            var c = new NumberToWords();
            c.Run();
        }

        private static void IntergerToRoman()
        {
            var c = new IntergerToRoman();
            c.Run();
        }

        private static void RomanToInterger()
        {
            var c = new RomanToInterger();
            c.Run();
        }

        private static void BinarySearchTest()
        {
            var sort = new BinarySearch();
            sort.Run();
        }


        private static void QuickSortTest()
        {
            var sort = new QuickSort();
            sort.Run();
        }

        private static void InsertionSortTest()
        {
            var sort = new InsertionSort();
            sort.Run();
        }

        private static void MergeSortTest()
        {
            var sort = new MergeSort();
            sort.Run();
        }
        
        private static void SelectionSortTest()
        {
            var selectionSort = new SelectionSort();
            selectionSort.Run();
        }

        private static void BubbleSortTest()
        {
            var bubbleSort = new BubbleSort();
            bubbleSort.Run();
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