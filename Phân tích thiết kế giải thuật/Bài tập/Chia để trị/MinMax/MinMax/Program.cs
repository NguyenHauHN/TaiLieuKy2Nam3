using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int min = 0;
            int max = 0;
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(0, 100);
            }
            for (int k = 0; k < arr.Length - 1; k++)
            {
                Console.Write("\t" + arr[k]);
            }
            Console.WriteLine();
             MinMax(arr, 0, arr.Length - 1, ref min, ref max);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.ReadKey();
        }

        public static void MinMax(int[] a, int l, int r, ref int min,  ref int max)
        {
            int min1 = 0;
            int max1 = 0;
            int min2 = 0;
            int max2 = 0;
            int mid = (l + r) /2;
            if (l == r)
            {
                min = a[l];
                max = a[l];
            }
            else
            {
                MinMax(a, l, mid, ref min1, ref max1);
                MinMax(a, mid + 1, r,ref  min2,ref  max2);
                if (min1 < min2)
                {
                    min = min1;
                }
                else
                {
                    min = min2;
                }
                if (max1 > max2)
                {
                    max = max1;
                }
                else
                {
                    max = max2;
                }
            }

        }
    }
}
