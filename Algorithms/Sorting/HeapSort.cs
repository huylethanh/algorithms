using System;

namespace Algorithms.Sorting
{
    public class HeapSort : Runable
    {
        protected override string ActionName => nameof(HeapSort);

        protected override object DoAction()
        {
            int[] arr = {12, 11, 13, 5, 6, 7};
            Sort(arr);
            return arr;
        }

        protected override void Display(object value)
        {
            var arr = (int[]) value;
            Console.WriteLine("[" + string.Join(",", arr) + "]");
        }

        private void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i); // find max heap.
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Helpers.Swap(array, i, 0);

                Heapify(array, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int root)
        {
            int largest = root;
            int l = 2 * root + 1; // left
            int r = 2 * root + 2; //right

            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != root)
            {
                Helpers.Swap(arr, root, largest);

                // Recursively heapify the affected sub-tree 
                Heapify(arr, n, largest);
            }
        }
    }
}