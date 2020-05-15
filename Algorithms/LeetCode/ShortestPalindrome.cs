using System;
using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-palindrome/
    /// </summary>
    /// <seealso cref="Algorithms.Runable" />
    public class ShortestPalindrome : Runable
    {
        protected override string ActionName => nameof(ShortestPalindrome);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<string>() { "abcde", "aacecaaa", "abcd" };
       
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoShortestPalindrome(item);
                output.Add($"'{item}' => '{value}'");
            }

            return output;
        }

        private string DoShortestPalindrome(string s)
        {
            var result = string.Empty;
            int n = s.Length;
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            string rev = new string(chars);

            int j = 0;
            for (int i = 0; i < n; i++)
            {
                var a = s.Substring(0, n - i);
                var b = rev.Substring(i);
                if (a == b)
                {
                    result = rev.Substring(0, i) + s;
                    break;
                }
            }

            return result;
        }
    }
}