using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    // Base cases:
    // if n <= 0, then the number of ways should be zero.
    // if n == 1, then there is only way to climb the stair.
    // if n == 2, then there are two ways to climb the stairs. One solution is one step by another; the other one is two steps at one time.
     
    // The key intuition to solve the problem is that given a number of stairs n, if we know the number ways to get to the points [n-1] and [n-2] respectively, denoted as n1 and n2 , 
    // then the total ways to get to the point [n] is n1 + n2. 
    // Because from the [n-1] point, we can take one single step to reach [n]. And from the [n-2] point, we could take two steps to get there.

    // The solutions calculated by the above approach are complete and non-redundant. The two solution sets (n1 and n2) cover all the possible cases on how the final step is taken. 
    // And there would be NO overlapping among the final solutions constructed from these two solution sets, because they differ in the final step.

    // Now given the above intuition, one can construct an array where each node stores the solution for each number n. 
    // Or if we look at it closer, it is clear that this is basically a fibonacci number, with the starting numbers as 1 and 2, instead of 1 and 1.
    
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