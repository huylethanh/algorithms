using System;

namespace Algorithms.Sorting
{
    public class InsertionSort : Runable
    {
        protected override string ActionName => nameof(InsertionSort);

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

            for (int i = 1; i < n; i++)
            {
                var value = arr[i];
                var leftIndex = i - 1;

                while (leftIndex >= 0 && value < arr[leftIndex])
                {
                    arr[leftIndex + 1] = arr[leftIndex]; // insert the next one by previouse one.
                    --leftIndex;
                }

                arr[leftIndex + 1] = value; // replate the last one by min value
            }
        }
    }
}