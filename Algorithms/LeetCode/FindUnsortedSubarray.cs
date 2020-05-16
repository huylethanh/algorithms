using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algorithms.LeetCode
{
    public class FindUnsortedSubarray : Runable
    {
        protected override string ActionName => nameof(FindUnsortedSubarray);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>)value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int[]>()
            {
                new int[] { 2, 6, 4, 8, 10, 9, 15 }, // 2, 4, 6
                new int []{1,3,4,2,5 },
                new int[]{1,2,4,5,3}, // 1 2 3 4 5
                new int[]{1, 3, 2, 2, 2 },// 1 2 2 2 3
                new int[] {1,3,2,4,5},
                new int[] {2,1},
                new int[] {1,2},
                new int[] {1, 2, 3, 4},

            };

            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoFindUnsortedSubarray2(item);
                output.Add($"'[{string.Join(",", item)}]' => length: {value}");
            }

            return output;
        }

        private int DoFindUnsortedSubarray(int[] nums)
        {
            var list = new List<int[]>();
            var sorted = nums.Clone() as int[];
            Array.Sort(sorted);
            var found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != sorted[i])
                {
                    if (found)
                    {
                        found = false;
                        list[list.Count - 1][1] = i;
                        continue;
                    }

                    found = true;
                    list.Add(new[] { i, i });
                }
            }

            if (list.Count == 0)
            {
                return 0;
            }

            var ret = list[list.Count - 1][1] - list[0][0];
            return ret + 1;
        }

        private int DoFindUnsortedSubarray2(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length == 0 || nums.Length == 1) return 0;

            int max = Int32.MinValue;
            int end = -2;

            for (int i = 0; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]);
                if (nums[i] < max)
                    end = i;
            }

            int min = Int32.MaxValue;
            int begin = -1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                min = Math.Min(min, nums[i]);
                if (nums[i] > min)
                    begin = i;
            }

            return end - begin + 1;
        }
    }
}