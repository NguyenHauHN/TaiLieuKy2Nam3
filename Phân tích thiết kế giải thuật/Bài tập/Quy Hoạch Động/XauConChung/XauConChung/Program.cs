using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XauConChung
{
    class Program
    {
        public static int[,] c;
        public static int[,] b;
        public static List<char> d;
        public static string X;
        public static string Y;
        public static void DocFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"E:\Phân tích thiết kế giải thuật\Bài tập\XauConChung\Data\input.txt");
            X = lines[0];
            Y = lines[1];
        }
        public static void GhiFile()
        {
            int k;
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\XauConChung\Data\output.txt");
            file.WriteLine("Day con chung dai nhat la: ");
            for(k = d.Count -1; k>= 0; k--)
            {
                file.Write(d[k]);
            }
            file.Close();
        }
        public static void XauConChungFunc(string X, string Y)
        {
            int i, j;
            c = new int[X.Length + 1, Y.Length + 1];
            b = new int[X.Length + 1, Y.Length + 1];
            for (i = 1; i <= X.Length; i++)
            {
                c[i, 0] = 0;
            }
            for (j = 1; j <= Y.Length; j++)
            {
                c[0, j] = 0;
            }
            for(i = 1; i<= X.Length ; i++)
            {
                for(j = 1; j <= Y.Length; j++)
                {
                    if(X[i-1] == Y[j-1])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        b[i, j] = 0;
                    }
                    else
                    {
                        if(c[i - 1,j] >= c[i, j - 1])
                        {
                            c[i, j] = c[i - 1, j];
                            b[i, j] = 1;
                        }
                        else
                        {
                            c[i, j] = c[i, j - 1];
                            b[i, j] = 2;
                        }
                       
                    }
                }
            }

        }

        public static void TruyVet(string X, int i,int j)
        {
            
            if (i == 0 && j == 0)
                return;
            if(i > 0 && j > 0)
            {
                if (b[i, j] == 0)
                {
                    d.Add(X[i -1]);
                    TruyVet(X, i - 1, j - 1);
                    
                }
                else if (b[i, j] == 1)
                {
                    TruyVet(X, i - 1, j);
                }
                else
                    TruyVet(X, i, j - 1);
            }
           

        }

        static void Main(string[] args)
        {
            int t;
            DocFile();
            d = new List<char>();
            XauConChungFunc(X, Y);
            TruyVet(X, X.Length, Y.Length);
            GhiFile();
            System.Console.WriteLine("Day con chung dai nhat tim duoc la: ");
            for(t = d.Count -1; t>= 0; t--)
            {
                System.Console.Write(d[t]);
            }
            System.Console.ReadKey();
        }
    }
}
