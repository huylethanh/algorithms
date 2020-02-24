using System;
using System.Collections.Generic;

namespace Algorithms.Arrays
{
    public class UniqueSubsetsWithGivenSum
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nameof(FindUniqueSubsetsWithGivenSum));
            Console.ResetColor();


            var input = new int[] {6, 2, 7, 8, 2, 4, 1, 3, 7, 5};
            var result = FindUniqueSubsetsWithGivenSum(input, 8);

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var list in result)
            {
                Console.WriteLine("[" + string.Join(",", list) + "]");
            }

            Console.ResetColor();
        }

        public List<List<int>> FindUniqueSubsetsWithGivenSum(int[] array, int givenSum)
        {
            var list = new List<List<int>>();

            Array.Sort(array);

            FindUniqueSubsetsWithGivenSum(array, list, new List<int>(), givenSum, 0);

            return list;
        }

        private void FindUniqueSubsetsWithGivenSum(int[] array, List<List<int>> allList, List<int> elements, int remain, int startIndex)
        {
            if (remain < 0)
            {
                return;
            }

            if (remain == 0)
            {
                allList.Add(new List<int>(elements));
                return;
            }

            int pre = -1;
            for (int i = startIndex; i < array.Length; i++)
            {
                if (pre == array[i])
                {
                    continue;
                }

                elements.Add(array[i]);
                FindUniqueSubsetsWithGivenSum(array, allList, elements, remain - array[i], i + 1);
                elements.RemoveAt(elements.Count - 1);
                pre = array[i];
            }
        }
    }
}