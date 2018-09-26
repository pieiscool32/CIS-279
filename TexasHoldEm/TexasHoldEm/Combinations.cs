using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class Combinations<T>
    {
        public static IEnumerable<List<T>> Combine(List<T> input, int pick)
        //Original code from: https://www.videlin.eu/2016/04/10/how-to-generate-combinations-without-repetition-interatively-in-c/
        {
            var num = input.Count;
            var list = new List<T>(input);
            list.Sort();
            var result = new List<T>();
            var stack = new Stack<int>();
            stack.Push(1);

            for (int index = 0; index < pick; index++)
            {
                result.Add(input[0]);
            }

            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var value = stack.Pop();

                while (value <= num)
                {
                    result[index++] = list[value - 1];
                    value++;
                    stack.Push(value);
                    if (index == pick)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }
    }
}
