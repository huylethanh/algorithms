using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms.LeetCode
{
    public class IntergerToRoman : Runable
    {
        private readonly Dictionary<int, string> defining;
        private readonly Dictionary<string, int> sepcialDefining;
        private readonly int[] values;
        private readonly string[] strs;

        public IntergerToRoman()
        {
            values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            strs = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            defining = new Dictionary<int, string>()
            {
                {1000, "M" },
                {900, "CM" },
                {500, "D" },
                {400, "CD" },
                {100, "C" },
                {90, "XC" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {8, "VIII" },
                {7, "VII" },
                {6, "VI" },
                {5, "V" },
                {4, "IV" },
                {3, "III" },
                {2, "II" },
                {1, "I" },
            };
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
            var inputs = new int[] { 1094, 1994, 58, 9, 4, 3 };
            var output = new List<string>();

            var watcher = new Stopwatch();
            var begin = watcher.ElapsedTicks;

            output.Add("----------------ConvertIntergerToRoman--------------------------");
            watcher.Start();

            foreach (var item in inputs)
            {
                var result = ConvertIntergerToRoman(item);
                output.Add($"{item} => {result}");
            }

            watcher.Stop();
            var end = watcher.ElapsedTicks;

            output.Add($"Tooks {end - begin} ticks");

            output.Add("----------------OtherConvertIntergerToRoman--------------------------");

            watcher.Reset();
            begin = watcher.ElapsedTicks;
            watcher.Start();

            foreach (var item in inputs)
            {
                var result = OtherConvertIntergerToRoman(item);
                output.Add($"{item} => {result}");
            }

            watcher.Stop();
            end = watcher.ElapsedTicks;
            output.Add($"Tooks {end - begin} ticks");

            return output;
        }

        private string ConvertIntergerToRoman(int num)
        {
            var buider = new StringBuilder();
            var devider = 1000;
            
            while (devider > 0)
            {
                var a = num / devider;

                if (a > 0)
                {
                    buider.Append(defining[a * devider]);
                    num %= devider;
                }

                devider /= 10;
            }

            return buider.ToString();
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
