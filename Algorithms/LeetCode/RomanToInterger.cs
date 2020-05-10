using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class RomanToInterger : Runable
    {
        private readonly Dictionary<string, int> defining;
        private readonly Dictionary<string, int> sepcialDefining;

        public RomanToInterger()
        {
            defining = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"M",1000 },
                {"D",500 },
                {"C",100 },
                {"L",50 },
                {"X",10 },
                {"V",5 },
                {"I",1 },
            };

            sepcialDefining = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"CM", 900 },
                {"CD", 400 },
                {"XC", 90 },
                {"XL", 40 },
                {"IX", 9 },
                {"IV", 4 },
            };
        }

        protected override string ActionName => nameof(RomanToInterger);

        protected override void Display(object value)
        {
            foreach(var item in (List<string>)value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new string[] { "LVIII", "iii", "iv", "xiv", "MCMXCIV", "v", "XX", "XIX" };
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var result = ConvertRomanToInterer(item);
                output.Add($"{item} => {result}");
            }

            return output;
        }

        private int ConvertRomanToInterer(string romance)
        {
            var chars = romance.ToCharArray();
            var number = 0;

            var i = 0;
            while (i < chars.Length)
            {
                var current = chars[i].ToString();
                var value = 0;
                if (i < chars.Length - 1 && sepcialDefining.TryGetValue($"{current}{chars[i + 1].ToString()}", out value))
                {
                    number += value;
                    i += 2;

                    continue;
                }

                number += defining[current];
                i++;
            }

            return number;
        }
    }
}
