using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/
    /// </summary>
    /// <seealso cref="Algorithms.Runable" />
    public class SingleNumber : Runable
    {
        protected override string ActionName => nameof(SingleNumber);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int[]>() {new[] {-1, -1, -2}};
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoSingleNumber(item);
                output.Add($"[{string.Join(",", item)}] => {value}");
            }

            return output;
        }

        private int DoSingleNumber(int[] numbers)
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
                    checking.Add(numbers[i], numbers[i]);
                    continue;
                }

                checking[numbers[i]] = 0;
            }

            foreach (var key in checking.Keys)
            {
                if (checking[key] != 0)
                {
                    return checking[key];
                }
            }

            return 0;
        }
    }
}
