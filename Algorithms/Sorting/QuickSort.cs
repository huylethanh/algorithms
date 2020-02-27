using System;

namespace Algorithms.Sorting
{
    public class QuickSort : Runable
    {
        protected override string ActionName => nameof(QuickSort);

        protected override object DoAction()
        {
            //   int[] arr = {3, 5, 8, 1, 2, 9, 4, 7, 6};
            int[] arr = {10, 80, 30, 90, 40, 50, 70};

            Sort(arr);

            return arr;
        }

        protected override void Display(object value)
        {
            var arr = (int[]) value;
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pi = Partition(arr, left, right);
                Sort(arr, left, pi - 1);
                Sort(arr, pi + 1, right);
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Helpers.Swap(arr, i, j);
                }
            }

            Helpers.Swap(arr, i + 1, right); // swap pivot element

            return i + 1;
        }
    }
}
