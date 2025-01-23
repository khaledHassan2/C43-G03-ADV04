using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool ConFuncDelegate(int obj);
    internal class Helper
    {
        public static List<int> FindNumbers(List<int> numbers,ConFuncDelegate con)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    //if (numbers[i] % 2 == 1)
                    if (con?.Invoke(numbers[i])==true)
                        Result.Add(numbers[i]);
                }
            }
            return Result;
        }
        public static List<int> FindOddNumbers(List<int> numbers)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]%2==1)
                                       Result.Add(numbers[i]);
                }
            }
            return Result;
        }
        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                        Result.Add(numbers[i]);
                }
            }
            return Result;
        }
    }
}
