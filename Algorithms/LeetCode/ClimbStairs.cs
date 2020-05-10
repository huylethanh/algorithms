using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class ClimbStairs : Runable
    {
        private int Max = 2;
        private int Min = 1;

        protected override string ActionName => nameof(ClimbStairs);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>)value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, };
            var outputs = new List<string>();

            for (int i = 2; i < 10; i++)
            {
                var total = CalculateClimbStairs(i);
                outputs.Add($"Step: {i} => total ways: {total}");
            }

            return outputs;
        }

        public int CalculateClimbStairs(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            int step1 = 2;
            int step2 = 1;
            int all = 0;

            for (int i = 2; i < n; i++)
            {
                all = step1 + step2;
                step2 = step1;
                step1 = all;
            }

            return all;
        }
    }
}