using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class MergeSort : Runable
    {
        protected override string ActionName => nameof(MergeSort);

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

        private void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            var leftArr = new int[n1];
            var rightArr = new int[n2];

            for (int a = 0; a < n1; a++)
            {
                leftArr[a] = arr[left + a];
            }

            for (int b = 0; b < n2; b++)
            {
                rightArr[b] = arr[mid + 1 + b];
            }

            int k = left;
            int i = 0;
            int j = 0;

            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
