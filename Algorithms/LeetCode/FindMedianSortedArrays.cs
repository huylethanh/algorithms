using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Algorithms.LeetCode
{
    public class FindMedianSortedArrays : Runable
    {
        protected override string ActionName => nameof(FindMedianSortedArrays);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>)value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<Tuple<int[], int[]>>()
            {
                new Tuple<int[], int[]>(new int[]{ }, new int[] { 1,2,3,4,5 }),
                new Tuple<int[], int[]>(new int[]{ }, new int[] { 1 }),
                new Tuple<int[], int[]>(new int[] { 1, 3 }, new int[] { 2 }),
                new Tuple<int[], int[]>(new int[] { 1, 2 }, new int[] {3,4 }),
            };

            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoFindMedianSortedArrays(item.Item1, item.Item2);
                output.Add($"Median of [${string.Join(",", item.Item1)}] and  [${string.Join(",", item.Item2)}] => {value}");
            }

            return output;
        }

        private double DoFindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            HashSet<int> items = new HashSet<int>();
            var all = nums1.Concat(nums2).ToArray();

            if (all.Length == 1)
            {
                return all[0];
            }

            Array.Sort(all);

            var a = all.Length / 2;
            if (all.Length % 2 == 1)
            {
                return all[a];
            }
           
            double abc = (all[a] + all[a - 1]) / 2.0;
            return abc;
        }
    }
}
