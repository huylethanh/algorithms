using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public static class Helpers
    {
        public static void Swap(int[] arr, int indexA, int indexB)
        {
            int swap = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = swap;
        }
    }
}
