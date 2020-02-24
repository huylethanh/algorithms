using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class SelectionSort : Runable
    {
        protected override string ActionName => nameof(SelectionSort);

        protected override object DoAction()
        {
            int[] arr = { 75, 38, 51, 40, 63, 54, 78, 23, 44, 80, 96, 73, 55, 91, 56, 27, 48, 49, 66, 85, 36, 31, 79, 18, 92, 16, 62, 76, 45, 35, 
                21, 61, 57, 88, 90, 59, 42, 32, 10, 47, 11, 86, 37, 97, 39, 13, 89, 22, 24, 70, 7, 9, 82, 77, 14, 30, 
                65, 68, 60, 25, 2, 74, 29, 98, 99, 52, 95, 64, 67, 33, 100, 94, 26, 34, 72, 43, 93, 8, 87, 20, 71, 12, 
                6, 4, 58, 53, 50, 84, 17, 41, 69, 5, 15, 19, 1, 81, 46, 83, 3, 28 };
            Sort(arr);
            return arr;
        }

        protected override void Display(object value)
        {
            var arr = (int[]) value;
            Console.WriteLine("[" + string.Join(",", arr) + "]");
        }

        private void Sort(int[] arr)
        {
            var n = arr.Length;
            for (int step = 0; step < n; step++)
            {
                var minIndex = step;

                for (int i = step + 1; i < n; i++)
                {
                    if (arr[i] < arr[minIndex])
                    {
                        minIndex = i;
                    }
                }

                Helpers.Swap(arr, step, minIndex);
            }
        }
    }
}
