using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class BubbleSort : Runable
    {
        protected override string ActionName => nameof(BubbleSort);

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

        private void Sort(int[] arr)
        {
            var n = arr.Length;
            for (int step = 0; step < n; step++)
            {
                for (int i = 0; i < n - step - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Helpers.Swap(arr, i, i + 1);
                    }
                }
            }
        }
    }
}