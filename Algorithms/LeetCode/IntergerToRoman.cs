using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms.LeetCode
{
    public class IntergerToRoman : Runable
    {
        private readonly int[] values;
        private readonly string[] strs;

        public IntergerToRoman()
        {
            values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            strs = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        }

        protected override string ActionName => nameof(IntergerToRoman);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>)value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new int[] { 1094, 1994, 58, 9, 4, 3, 20 };
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var result = OtherConvertIntergerToRoman(item);
                output.Add($"{item} => {result}");
            }

            return output;
        }

        private string OtherConvertIntergerToRoman(int num)
        {
            string roman = "";
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    roman += strs[i];
                }
            }

            return roman;
        }
    }
}
