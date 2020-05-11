using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class FindDuplicate : Runable
    {
        protected override string ActionName => nameof(FindDuplicate);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int[]>() {new[] { 1, 3, 4, 2, 2 }, new[] { 3, 1, 3, 4, 2 } };
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoFindDuplicate(item);
                output.Add($"[{string.Join(",", item)}] => {value}");
            }

            return output;
        }

        private int DoFindDuplicate(int[] numbers)
        {
            Dictionary<int, int> checking = new Dictionary<int, int>();
            if (numbers.Length == 1)
            {
                return numbers[0];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!checking.ContainsKey(numbers[i]))
                {
                    checking.Add(numbers[i], 0);
                    continue;
                }

                checking[numbers[i]]++;
            }

            foreach (var key in checking.Keys)
            {
                if (checking[key] > 0)
                {
                    return key;
                }
            }

            return 0;
        }
    }
}
