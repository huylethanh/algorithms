using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class NumberToWords : Runable
    { 
        protected override string ActionName => nameof(LeetCode.NumberToWords);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>)value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new int[] {80, 0,100, 10000, 10000000, 101001, 111, 1111, 99, 35, 56, 9999999, 123, 1234, 12345, 123456, 1234567, 1234567891, 1000010, 110, 10, 1000, 11000, 101, 1000000, 10000010};
           // var inputs = new int[] { 1100 };
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var result = ConvertNumberToWords(item);
                output.Add($"{item} => {result}");
            }

            return output;
        }

        private string ConvertNumberToWords(int num)
        {
            if (num == 0)
            {
                return NumberDefine(0);
            }

            var builder = new StringBuilder();
            DoNumberToWords(num, builder);
            return builder.ToString().Trim();
        }

        private void DoNumberToWords(int num, StringBuilder builder)
        {
            if (num == 0)
            {
                return;
            }

            while (num > 0)
            {
                var name = NumberDefine(num);
                var devider = GetDivider(num);
                var divi = num / devider;

                if (!string.IsNullOrWhiteSpace(name))
                {
                    if (num >= 100)
                    {
                        builder.Append(NumberDefine(divi));
                    }

                    builder.Append(name);
                    break;
                }

                num %= devider;

                if (devider == 10)
                {
                    builder.Append(NumberDefine(divi * devider));
                    builder.Append(NumberDefine(num));
                    break;
                }

                DoNumberToWords(divi, builder);
                builder.Append(NumberDefine(devider));
            }
        }

        private int GetDivider(int num)
        {
            if (num < 100)
            {
                return 10;
            }

            if (num >= 100 && num < 1000)
            {
                return 100;
            }

            if (num >= 1000 && num < 1000000)
            {
                return 1000;
            }

            if (num >= 1000000 && num < 1000000000)
            {
                return 1000000;
            }

            return 1000000000;
        }

        private string NumberDefine(int num)
        {
            switch (num)
            {
                case 0:
                    return "Zero ";

                case 1:
                    return "One ";

                case 2:
                    return "Two ";

                case 3:
                    return "Three ";

                case 4:
                    return "Four ";

                case 5:
                    return "Five ";

                case 6:
                    return "Six ";

                case 7:
                    return "Seven ";

                case 8:
                    return "Eight ";

                case 9:
                    return "Nine ";

                case 10:
                    return "Ten ";

                case 11:
                    return "Eleven ";

                case 12:
                    return "Twelve ";

                case 13:
                    return "Thirteen ";

                case 14:
                    return "Fourteen ";

                case 15:
                    return "Fifteen ";

                case 16:
                    return "Sixteen ";

                case 17:
                    return "Seventeen ";

                case 18:
                    return "Eighteen ";

                case 19:
                    return "Nineteen ";

                case 20:
                    return "Twenty ";

                case 30:
                    return "Thirty ";

                case 40:
                    return "Forty ";

                case 50:
                    return "Fifty ";

                case 60:
                    return "Sixty ";

                case 70:
                    return "Seventy ";

                case 80:
                    return "Eighty ";

                case 90:
                    return "Ninety ";

                case 100:
                    return "Hundred ";

                case 1000:
                    return "Thousand ";

                case 1000000:
                    return "Million ";

                case 1000000000:
                    return "Billion ";

                default:
                    return "";
            }
        }
    }
}
