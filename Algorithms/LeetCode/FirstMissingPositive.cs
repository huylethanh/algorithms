using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/first-missing-positive/
    /// </summary>
    /// <seealso cref="Algorithms.Runable" />
    public class FirstMissingPositive : Runable
    {
        protected override string ActionName => nameof(FirstMissingPositive);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int[]>() {new[] {4, 3, 4, 2, 1, 1, 4, 1, 4}, new[] {-5}, new[] {-5, -4, -1, 0}, new[] {1, 2, 0}, new[] {3, 4, -1, 1}, new[] {7, 8, 9, 11, 12}};
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoFirstMissingPositive(item);
                output.Add($"[{string.Join(",", item)}] => {value}");
            }

            return output;
        }

        private int DoFirstMissingPositive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 1;
            }

            var sorted = nums.ToList();
            sorted.Sort();
            int missing = 1;

            for (int i = 0; i < sorted.Count; i++)
            {
                if (sorted[i] <= 0)
                {
                    continue;
                }

                if (missing < sorted[i])
                {
                    return missing;
                }

                if (i == 0 || sorted[i] != sorted[i - 1])
                {
                    missing++;
                }
            }

            if (sorted[sorted.Count - 1] <= 0)
            {
                return 1;
            }

            return ++sorted[sorted.Count - 1];
        }
    }
}