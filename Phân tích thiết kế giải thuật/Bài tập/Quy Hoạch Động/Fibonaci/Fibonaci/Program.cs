using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        public static int FibonaciFunc(int n, int[] F)
        {
            F[0] = 0;
            F[1] = 1;
            int k;
            if(n > 1)
            {
                for(k = 2; k <= n; k++)
                {
                    F[k] = F[k - 1] + F[k - 2];
                }
            }
            return F[n];
        }

        static void Main(string[] args)
        {
            int[] F;
            int n = 0;
            System.Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(System.Console.ReadLine());
            F = new int[n + 1];
            int results = FibonaciFunc(n, F);
            System.Console.WriteLine("Ket qua: {0}", results);
            System.Console.ReadKey();
        }
    }
}
