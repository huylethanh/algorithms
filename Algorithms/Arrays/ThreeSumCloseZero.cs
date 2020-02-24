using System;

namespace Algorithms.Arrays
{
    public class ThreeSumCloseZero
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nameof(FindSumClosestToZero));
            Console.ResetColor();

            int[] input = {-1, 4, -2, 5, 10, -5};

            var result = FindSumClosestToZero(input);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(nameof(FindSumClosestToZero) + ": " + result);
            Console.ResetColor();
        }

        public int FindSumClosestToZero(int[] input)
        {
            int minSumPositive = int.MaxValue;
            int minSumNegative = int.MinValue;
            if (input.Length < 3)
            {
                Console.WriteLine("Arry is not valid");
                return minSumPositive;
            }

            //sort the array in ascending order
            Array.Sort(input);

            for (int i = 0; i < input.Length; i++)
            {
                int a = input[i];
                int j = i + 1;
                int k = input.Length - 1;
                while (j < k)
                {
                    int sum = a + input[j] + input[k];
                    if (sum == 0)
                    {
                        return 0;
                    }
                    
                    if (sum > 0)
                    {
                        minSumPositive = Math.Min(sum, minSumPositive);
                        k--;
                    }
                    else
                    {
                        minSumNegative = Math.Max(sum, minSumNegative);
                        j++;
                    }
                }
            }

            if (Math.Abs(minSumNegative) < minSumPositive)
            {
                return minSumNegative;
            }

            return minSumPositive;
        }
    }
}