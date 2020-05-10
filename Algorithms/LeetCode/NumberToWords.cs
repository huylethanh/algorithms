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
            var inputs = new int[] { 9999999, 123, 1234, 12345, 123456, 1234567, 1234567891, 1000010, 110, 10, 1000, 11000, 101, 1000000, 10000010 };
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
            if(num==0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            var devider = 10;

            while (devider > 1)
            {
                var name = NumberDefine(num);
                if (!string.IsNullOrWhiteSpace(name))
                {
                    builder.Append(name);
                    break;
                }
                else
                {
                    devider = GetDivider(num);
                    var a = num / devider;
                    num %= devider;

                    if (devider == 10)
                    {
                        builder.Append(NumberDefine(a * devider));
                        builder.Append(NumberDefine(num));
                    }
                    else
                    {
                        if (a > 0)
                        {
                            var result = ConvertNumberToWords(a);
                            builder.Append(result);
                            builder.Append(NumberDefine(devider));
                        }
                    }
                }

                devider = devider / 10;
            }

            return builder.ToString();
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
                    return "ThirdTeen ";

                case 15:
                    return "Fifteen ";

                case 20:
                    return "Twenty ";

                case 30:
                    return "Thirdty ";

                case 40:
                    return "Fourty ";

                case 50:
                    return "Fifty ";

                case 60:
                    return "Sixty ";

                case 70:
                    return "Seventy ";

                case 80:
                    return "Eightty ";

                case 90:
                    return "Ninety ";

                case 100:
                    return "Hundred ";

                case 1000:
                    return "Thousand ";

                case 10000:
                    return "Ten Thousand ";

                case 100000:
                    return "Hundred Thousand ";

                case 1000000:
                    return "Milion ";

                case 10000000:
                    return "Ten milion ";

                case 100000000:
                    return "Hunderd milion ";

                case 1000000000:
                    return "Bilion ";

                default:
                    return "";
            }
        }
    }
}
