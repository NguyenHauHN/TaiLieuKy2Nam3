using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floyd
{
    class Program
    {
        const int MAX = 10000;
        public static int[,] d;
        public static int[,] p;
        public static int[,] a;
        public static int n;
        public static void FloydFunc()
        {
           
            int i, j, k;
            
            // khoi tao
            for(i = 1; i<= n; i++)
            {
                for(j = 1; j <= n; j++)
                {
                    d[i, j] = a[i, j];
                    p[i, j] = 0;
                }
            }

            for(k = 1; k <= n; k++)
            {
                for(i = 1; i <= n; i++)
                {
                    if(d[i,k] > 0 && d[i,k] < MAX)
                    {
                        for(j = 1; j<= n; j++)
                        {
                            if(d[k,j] > 0 && d[k,j] < MAX)
                            {
                                if(d[i,k] + d[k,j] < d[i, j])
                                {
                                    d[i, j] = d[i, k] + d[k, j];
                                    p[i, j] = k;
                                }
                            }
                        }
                    }
                }
            }


        }

        public static void DocFile()
        {
            int t, i, j;
            string[] element;
            
            string[] lines = System.IO.File.ReadAllLines(@"E:\Phân tích thiết kế giải thuật\Bài tập\Floyd\Data\input.txt");
            n = Convert.ToInt32(lines[0]);
            a = new int[n + 1, n + 1];
            for(i = 0; i < n + 1; i++)
            {
                for(j = 0; j < n+ 1; j++)
                {
                    if(i == j)
                    {
                        a[i, j] = 0;
                    }
                    else
                    {
                        a[i, j] = MAX;
                    }
                    
                }
            }
            for (t = 1; t < lines.Length; t++)
            {
                element = lines[t].Split(' ');
                a[Convert.ToInt32(element[0]), Convert.ToInt32(element[1])] = Convert.ToInt32(element[2]);
            }
        }

        public static void GhiFile()
        {
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\Floyd\Data\output.txt");
            int i, j;
            string line;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if(i != j)
                    {
                        if (p[i, j] == 0)
                        {
                            line = i + " ke voi " + j;
                        }
                        else
                        {
                            line = i + " -> " + j + " di qua " + p[i, j];
                        }

                        file.WriteLine(line);
                    }
                    
                }
            }
            file.Close();
        }

        static void Main(string[] args)
        {
            
            DocFile();
            d = new int[n +1, n + 1];
            p = new int[n +1, n + 1];
            FloydFunc();
            GhiFile();
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.WriteLine("Phan tu p[{0},{1}] = {2}", i, j, p[i, j]);
                }
            }

            System.Console.ReadKey();
        }
    }
}
