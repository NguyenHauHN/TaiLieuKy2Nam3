using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiToan8Hau
{
    class Program
    {
        public static int[] a;
        public static int[] b;
        public static Dictionary<int, int> c;
        public static int[] x;
        public static int dem;
        //public static int

        public static void Init()
        {
            int k;
            for (k = 1; k <= 8; k++)
            {
                a[k] = 1;
            }
            for (k = 2; k <= 16; k++)
            {
                b[k] = 1;
            }
            for (k = -7; k <= 7; k++)
            {
                c.Add(k, 1);
            }
        }
        public static void Try(int i)
        {
            int j;
            for (j = 1; j <= 8; j++)
            {
                if (a[j] == 1 && b[i + j] == 1 && c[i - j] == 1)
                {
                    x[i] = j;
                    a[j] = 0;
                    b[i + j] = 0;
                    c[i - j] = 0;
                    if (i < 8)
                    {
                        Try(i + 1);

                    }
                    else
                    {
                        Print();
                        GhiFile();

                    }
                    a[j] = 1;
                    b[i + j] = 1;
                    c[i - j] = 1;

                }
            }
        }

        public static void Print()
        {
            int i, j;
            dem++;
            System.Console.WriteLine("Phuong an nghiem thu {0}", dem);
            for (i = 1; i <= 8; i++)
            {
                
                System.Console.WriteLine("x[{0}] : {1}", i, x[i]);
                
            }
        }

        public static void GhiFile()
        {
            int i;
            System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\Quay lui\BaiToan8Hau\Data\output.txt");
            string line = null;
            file.WriteLine("Phuong an nghiem thu {0}", dem);
            for(i = 1; i <=8; i++)
            {
                line = "x[" + i.ToString() + "] = " + x[i].ToString();
                file.WriteLine(line);

            }
            file.Close();
        }

        static void Main(string[] args)
        {
            a = new int[9];
            b = new int[17];
            c = new Dictionary<int, int>();
            x = new int[9];
            dem = 0;
            // khoi tao
            Init();
            //bat dau xep
            Try(1);
            System.Console.ReadKey();
        }
    }
}
