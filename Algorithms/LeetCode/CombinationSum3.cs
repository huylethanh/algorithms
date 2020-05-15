using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class CombinationSum3 : Runable
    {
        protected override string ActionName => nameof(CombinationSum3);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<int[]>() { new[] { 2, 6 }, new[] { 2, 18 } };
            var output = new List<string>();

            foreach (var item in inputs)
            {
                var value = DoCombinationSum3(item[0], item[1]);
                foreach (var list in value)
                {
                    output.Add($"Sum {item[1]} => [{string.Join(",", list)}]");
                }

            }

            return output;
        }

        private IList<IList<int>> DoCombinationSum3(int k, int n)
        {
            IList<int> list = new List<int>();
            IList<IList<int>> result = new List<IList<int>>();
           
            DoCombinationSum3(k, n, 1, list, result);

       //     result = result.Where(e => e.Count == k).ToList();

            return result;
        }

        private void DoCombinationSum3(int k, int n, int begin, IList<int> result, IList<IList<int>> abc)
        {
            int temp = n;
            int i = begin;

            while (i <= 9)
            {
                result.Add(i);
                temp -= i;
                DoCombinationSum3(k, temp, ++i, result, abc);

                if (temp == 0)
                {
                    abc.Add(result.ToList());
                    result.RemoveAt(result.Count-1);
                    return;
                }

                temp += result[result.Count - 1];
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
