using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // tao mang random

            int[] arr = new int[20];
            Random randNum = new Random();
            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = randNum.Next(0, 20);
            }
            MergeSortFunc(arr, 0, arr.Length - 1);
            int i;
            for (i = 0; i < arr.Length - 1; i++)
            {
                Console.Write("\t " + arr[i]);
            }
            Console.ReadKey();
        }

        public static void MergeSortFunc(int[] a, int l,int r){
            if(l >= r){
                return;
            }
            int t = Convert.ToInt32((l + r)/2);
            MergeSortFunc(a, l, t);
            MergeSortFunc(a, t + 1, r);
            Merge(a, l, r, t);
        }

        public static void Merge(int[] a, int l, int r, int t){
            int i = l;
            int j = t + 1;
            int p= l;
            int[] c = new int[1000];
            while(i <= t && j <= r){
                if (a[i] < a[j])
                {
                    c[p] = a[i];
                    i++;
                }
                else
                {
                    c[p] = a[j];
                    j++;
                }
                p++;
            }
            while (i <= t)
            {
                c[p] = a[i];
                i++;
                p++;
            }
            while (j <= r)
            {
                c[p] = a[j];
                j++;
                p++;
            }
            for (i = l; i <= r; i++)
            {
                a[i] = c[i];
            }
        }
    }
}
