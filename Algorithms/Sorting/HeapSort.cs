using System;

namespace Algorithms.Sorting
{
    public class HeapSort
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nameof(HeapSort));
            Console.ResetColor();

            int[] arr = {12, 11, 13, 5, 6, 7};

            Sort(arr);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[" + string.Join(",", arr) + "]");

            Console.ResetColor();

        }

        private void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Swap(array, n, i);

                Heapify(array, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1; // left
            int r = 2 * i + 2; //right

            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                Swap(arr, i, largest);

                // Recursively heapify the affected sub-tree 
                Heapify(arr, n, largest);
            }
        }

        private void Swap(int[] arr, int indexA, int indexB)
        {
            int swap = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = swap;
        }
    }
}