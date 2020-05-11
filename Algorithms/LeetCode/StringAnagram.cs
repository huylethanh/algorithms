using System;

namespace Algorithms.LeetCode
{
    public class StringAnagram
    {
        public bool IsAnagram(string word1, string word2)
        {
            var chars1 = word1.ToCharArray();
            var chars2 = word2.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return string.Compare(new string(chars1), 0, new string(chars2), 0, chars2.Length) == 0;
        }
    }
}
