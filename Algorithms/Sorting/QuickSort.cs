using System;

namespace Algorithms.Sorting
{
    public class QuickSort : Runable
    {
        protected override string ActionName => nameof(QuickSort);

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
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int low, int hight)
        {
            if (low < hight)
            {
                int pi = Partition(arr, low, hight);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, hight);
            }
        }

        private int Partition(int[] arr, int low, int hight)
        {
            int pivot = arr[hight];

            int i = low - 1;

            for (int j = low; j < hight; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Helpers.Swap(arr, i, j);
                }
            }

            int temp = arr[i + 1];
            arr[i + 1] = arr[hight];
            arr[hight] = temp;

            return i + 1;
        }
    }
}
