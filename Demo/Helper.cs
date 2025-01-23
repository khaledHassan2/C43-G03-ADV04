using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // public delegate bool ConFuncDelegate(int obj);
     public delegate bool ConFuncDelegate<T>(T obj);

    internal class Helper
    {
        public static List<T> FindNumbers<T>(List<T> numbers,ConFuncDelegate<T> con)
        {
            List<T> Result = new List<T>();
            if (numbers is not null &&con is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    //if (numbers[i] % 2 == 1)
                   // if (con?.Invoke(numbers[i])==true)
                        if (con(numbers[i]))
                            Result.Add(numbers[i]);
                }
                return Result;
            }
            return Result;
        }
        //public static List<int> FindOddNumbers(List<int> numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (numbers is not null)
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {
        //            if (numbers[i]%2==1)
        //                               Result.Add(numbers[i]);
        //        }
        //    }
        //    return Result;
        //}
        //public static List<int> FindEvenNumbers(List<int> numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (numbers is not null)
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {
        //            if (numbers[i] % 2 == 0)
        //                Result.Add(numbers[i]);
        //        }
        //    }
        //    return Result;
        //}
    }
}
