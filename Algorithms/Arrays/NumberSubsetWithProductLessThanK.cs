using System;
using System.Collections.Generic;
using System.Text;

namespace Grapoh.Arrays
{
    public class NumberSubsetWithProductLessThanK
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nameof(FindNumberSubsetWithProductLessThanK));
            Console.ResetColor();

            var input = new int[] { 4, 2, 3, 6, 5 };
            var result = FindNumberSubsetWithProductLessThanK(input, 25);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Total subset: " + result.Count);
            foreach (var list in result)
            {
                Console.WriteLine("[" + string.Join(",", list) + "]");
            }

            Console.ResetColor();
        }

        private List<List<int>> FindNumberSubsetWithProductLessThanK(int[] input, int k)
        {
            Array.Sort(input);
            var list = new List<int>();
            var pre = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > k)
                {
                    break;
                }

                if (pre == input[i])
                {
                    continue;
                }

                list.Add(input[i]);
                pre = input[i];
            }

            var all = new List<List<int>>();
            FindNumberSubsetWithProductLessThanK(list.ToArray(), all, new List<int>(), 1, 0, k);
            return all;
        }

        private void FindNumberSubsetWithProductLessThanK(int[] input, List<List<int>> list, List<int> elemennt, int product, int startIndex, int k)
        {
            if (product > k)
            {
                return;
            }

            if (elemennt.Count > 0)
            {
                list.Add(new List<int>(elemennt));
            }

            for (int i = startIndex; i < input.Length; i++)
            {
                elemennt.Add(input[i]);
                FindNumberSubsetWithProductLessThanK(input, list, elemennt, product * input[i], i + 1, k);
                elemennt.RemoveAt(elemennt.Count-1);
            }
        }
    }
}
