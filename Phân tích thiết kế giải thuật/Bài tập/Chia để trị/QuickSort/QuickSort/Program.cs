using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 3, 1, 7, 8, 2, 6, 9 };
            //int[] arr = { 3, 1, 7, 8, 2, 6, 9 };
            //Random randNum = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = randNum.Next(0, 100);
            //}
            QuickSort(arr, 0, arr.Length - 1);
            for (int j = 0; j < arr.Length - 1; j++)
            {
                Console.Write("\t" + arr[j]);
            }
            Console.ReadKey();
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public static int Partition(int[] a, int l, int r)
        {
            int x = a[l];
            int i = l + 1;
            int j = r;
            while (i < j)
            {
                while (i < j && a[i] < x)
                {
                    i++;
                }
                while (j >= i && a[j] >= x)
                {
                    j--;
                }
                if (i < j) Swap(ref a[i], ref a[j]);
            }
            Swap(ref a[l], ref a[j]);
            return j;
        }

        public static void QuickSort(int[] a, int l, int r)
        {
            if (l >= r) return;
            int i = Partition(a, l, r);
            QuickSort(a, l, i - 1);
            QuickSort(a, i + 1, r);

        }
    }
}
