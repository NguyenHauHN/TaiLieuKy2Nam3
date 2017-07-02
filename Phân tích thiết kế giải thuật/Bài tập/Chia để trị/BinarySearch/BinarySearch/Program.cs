using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20]; 

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(0, 100);
            }
            QuickSort(arr, 0, arr.Length - 1);
            for (int j = 0; j < arr.Length - 1; j++)
            {
                Console.Write("\t" + arr[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Nhap khoa: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int idx = BinarySearch(arr,x, 0, arr.Length - 1);
            Console.WriteLine("Vi tri tim thay: " + idx);
            Console.ReadKey();
        }
        //tim kiem
        public static int BinarySearch(int[] a, int x, int l, int r)
        {
            int mid;
            if (l > r) return 0;
            mid = (l + r) / 2;
            if (x == a[mid])
            {
                return mid;
            }
            else
            {
                if (x > a[mid])
                {
                    return BinarySearch(a, x, mid + 1, r);
                }
                else
                {
                    return BinarySearch(a, x, l, mid - 1);

                }

            }
        }

        // sap xep mang
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
