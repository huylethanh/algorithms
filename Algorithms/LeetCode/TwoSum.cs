using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithms.LeetCode
{
    public class TwoSum : Runable
    {
        protected override string ActionName => nameof(TwoSum);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int[]>() {new[] {230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789}};

            var targets = new int[] {765};
            var output = new List<string>();

            for (int i = 0; i < inputs.Count; i++)
            {
                var value = DoOtherTwoSum(inputs[i], targets[i]);
                output.Add($"[{string.Join(",", inputs[i])}] - {targets[i]} => result [{string.Join(',', value)}]");
            }

            return output;
        }

        public int[] DoTwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    continue;
                }

                set.Add(nums[i]);

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        private int[] DoOtherTwoSum(int[] nums, int target)
        {
            var result = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    result[0] = map[complement];
                    result[1] = i;
                    break;
                }

                if (map.ContainsKey(nums[i]))
                {
                    continue;
                }

                map.Add(nums[i], i);
            }

            return result;
        }
    }
}
