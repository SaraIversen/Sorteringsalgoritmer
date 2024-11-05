using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringsopgave
{
    public static class Bubblesorty
    {
        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;

                for (int i = 0; i <= n - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            n = n - 1;
            return array;
        }
    }
}
