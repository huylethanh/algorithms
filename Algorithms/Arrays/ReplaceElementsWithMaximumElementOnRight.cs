using System;
using System.Collections.Generic;
using System.Text;

namespace Grapoh.Arrays
{
    //Original Array: [2, 5, 1, 6, 3, 4]
    //Output: [6, 6, 6, 0, 4, 0]
    /// <summary>
    /// (For elements 2, 5, 1 the maximum element at the right side is 6, so replace these by 6, there is no element bigger than 6 at the right of 6 so replace 6 with 0 at its index.
    /// Similarly, for element 3, the maximum element at the right side is 4 so replace it by 4 and at the last index put 0)
    /// </summary>
    public class ReplaceElementsWithMaximumElementOnRight
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nameof(ReplaceElementsWithMaximumElementOnRight));
            Console.ResetColor();

            var array = new[] { 2, 5, 1, 6, 3, 4 };
            DoReplaceElementsWithMaximumElementOnRight(array);
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[" + string.Join(",", array) + "]");

            Console.ResetColor();
        }

        public void DoReplaceElementsWithMaximumElementOnRight(int[] array)
        {
            var maxRight = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < maxRight)
                {
                    array[i] = maxRight;
                    continue;
                }

                if (array[i] == maxRight)
                {
                    array[i] = 0;
                    continue;
                }

                if (array[i] > maxRight)
                {
                    maxRight = array[i];
                    array[i] = 0;
                    continue;
                }
            }
        }
    }
}
