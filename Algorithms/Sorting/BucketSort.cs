using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class BucketSort : Runable
    {
        protected override string ActionName => nameof(BubbleSort);

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

        private void Sort(int[] arr)
        {

        }
    }
}
