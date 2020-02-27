using Algorithms.Sorting;
using System;

namespace Algorithms.Searching
{
    public class BinarySearch : Runable
    {
        private QuickSort _quickSort;

        public BinarySearch()
        {
            _quickSort = new QuickSort();
        }

        protected override string ActionName => nameof(BinarySearch);

        protected override object DoAction()
        {
            int[] arr = {12, 11, 13, 5, 6, 7};
            _quickSort.Sort(arr);
            var searchItem = 11;
            Console.WriteLine("Sorted array: [" + string.Join(",", arr) + "]");
            Console.WriteLine($"search value: {searchItem}");
            return Search(arr, searchItem);
        }

        protected override void Display(object value)
        {
            var index = (int) value;
            Console.WriteLine($"Found at index -> {index}");
        }


        private int Search(int[] arr, int searchItem)
        {
            return Search(arr, searchItem, 0, arr.Length - 1);
        }

        private int Search(int[] arr, int searchItem, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return -1;
            }

            var mid = (rightIndex + leftIndex) / 2;
            if (searchItem == arr[mid])
            {
                return mid;
            }

            if (searchItem > arr[mid])
            {
                return Search(arr, searchItem, mid + 1, rightIndex);
            }

            return Search(arr, searchItem, leftIndex, mid);
        }
    }
}
