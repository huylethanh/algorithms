using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Algorithms.Sorting;

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

            return Search(arr, 5);
        }

        protected override void Display(object value)
        {
            var found = (bool) value;
            Console.WriteLine(found ? "found" : "not found");
        }


        private bool Search(int[] arr, int searchItem)
        {
            _quickSort.Sort(arr);
            return Search(arr, searchItem, 0, arr.Length - 1);
        }

        private bool Search(int[] arr, int searchItem, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return true;
            }

            var mid = (rightIndex - leftIndex) / 2;
            if (searchItem == arr[mid])
            {
                return true;
            }

            if (searchItem > arr[mid])
            {
                return Search(arr, searchItem, mid + 1, rightIndex);
            }

            return Search(arr, searchItem, leftIndex, mid);
        }
    }
}
