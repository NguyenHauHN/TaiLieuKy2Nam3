using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayConCoTongLonNhat
{
    class Program
    {
        public static int[] a;
        public static int s;
        public static int e;
        public static void SubMax()
        {
            int s1 = 1;
            int i;
            int MaxS = a[0];
            int MaxE = a[0];
            s = e = 1;
            int n = a.Length;
            for (i = 1; i < n; i++)
            {
                if(MaxE > 0)
                {
                    MaxE = MaxE + a[i];
                }
                else
                {
                    MaxE = a[i];
                    s1 = i;
                }

                if(MaxE > MaxS)
                {
                    MaxS = MaxE;
                    e = i;
                    s = s1;
                }
            }

        }
        static void Main(string[] args)
        {
            int j;
            a = new int[] { 13, -15, 2, 18, 4, 8, 0, -5, -8 };
            SubMax();
            System.Console.WriteLine("Ket qua thu duoc: ");
            for(j =s; j <= e; j++)
            {
                if(j == e)
                {
                    System.Console.Write(a[j]);
                }
                else
                {
                    System.Console.Write(a[j] + ",");
                }
                
            }
            System.Console.ReadKey();
        }
    }
}
