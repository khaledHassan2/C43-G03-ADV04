using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingAlgorithms
    {
        public static void BubbleSortAsc(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length-i-1; j++)
                    {
                        if (array[j] > array[j+1])
                            Swap(ref array[j], ref array[j+1]);
                        
                    }

                }
            }
        }
        public static void BubbleSortDec(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length-i-1; j++)
                    {
                        if (array[j] < array[j + 1])
                            Swap(ref array[j], ref array[j + 1]);

                    }

                }
            }
        }
        public static void BubbleSort(int[] array, SptrtingTypesFunDelegate StFunc)
        {
            if (array is not null /*&&StFunc is not null*/)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        //if (array[j] < array[j + 1])
                        if (StFunc?.Invoke(array[j], array[j+1])==true)
                            Swap(ref array[j], ref array[j + 1]);

                    }

                }
            }
        }
        private static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y=temp;
        }
    }
}
