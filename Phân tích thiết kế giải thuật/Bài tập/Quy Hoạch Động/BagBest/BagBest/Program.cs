using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagBest
{
    class Program
    {
        public static List<int> d;
        public static int n, b;
        public static int[] w;
        public static int[] c;
        public static void DocFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"E:\Phân tích thiết kế giải thuật\Bài tập\BagBest\Data\input.txt");
            n = Convert.ToInt32(lines[0]);
            b = Convert.ToInt32(lines[1]);
            w = new int[n];
            c = new int[n];
            w = Array.ConvertAll(lines[2].Split(' '), int.Parse); 
            c = Array.ConvertAll(lines[3].Split(' '), int.Parse); 
        }

        public static void GhiFile(int bagBest)
        {
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\BagBest\Data\output.txt");
            string line;
            int dem = 1;
            int W = 0;
            file.WriteLine("Cac do vat lay di la: ");
            foreach (int t in d)
            {
                if(dem < d.Count)
                {
                    line = t + " , ";
                    
                }
                else
                {
                    line = t.ToString() ;
                }
                
                file.Write(line);
                dem++;
                W += w[t-1];
            }
            file.WriteLine();
            file.WriteLine("\nTong trong luong la: {0}", W);
            file.WriteLine("\nGia tri: {0}", bagBest);
            file.Close();
        }
        public static int BagBestFunc(int[,] MaxV, int n,int b, int[] w, int[] c)
        {
            int L, i;
            d = new List<int>();
            for(L = 0; L <= b; L++)
            {
                MaxV[0, L] = 0;
            }
            for(i = 0;i <= n; i++)
            {
                MaxV[i, 0] = 0;
            }
            for(i = 1; i <= n; i++)
            {
                for(L =1; L <= b; L++)
                {
                    MaxV[i, L] = MaxV[i - 1, L];
                    if(L > w[i - 1] && (MaxV[i - 1,L-w[i -1]] + c[i-1] > MaxV[i - 1,L]))
                    {
                        MaxV[i, L] = MaxV[i - 1,L - w[i-1]] + c[i-1];
                       
                    }
                }
            }
            return MaxV[n,b];

        }

        public static void TruyVet(int[,] MaxV, int n, int b, int[] w)
        {
            // neu MaxV[n,b] = MaxV[n-1,b] thi k chon n va truy sang MaxV[n-1,b]
            // nguoc lai chon n va truy sang MaxV[n-1, b-w[n]]
            int k = n;
            while(k > 0 && b > 0)
            {
                if (MaxV[k, b] != MaxV[k - 1, b])
                {
                    d.Add(k);
                    
                    b = b - w[k -1];
                }

                k = k - 1;
            }
        }


        static void Main(string[] args)
        {
            int j, weight = 0;
            string line;

            // nhap tu file
            DocFile();
            
            int[,] MaxV = new int[n + 1, b + 1];
            //goi ham
            int results = BagBestFunc(MaxV,n, b, w, c);
            // in ra man hinh cac do dk lay
            TruyVet(MaxV, n,b,w);
            GhiFile(results);
            System.Console.WriteLine("Cac do vat lay di la: ");
            for (j = 0; j < d.Count; j++)
            {
                line = d[j] + " , ";
                System.Console.Write(line);
                weight += w[d[j] - 1];
            }
            //in ra trong luong
            System.Console.WriteLine("\nTrong luong cac vat lay di la: {0}", weight);
            // in ra tong gia tri lay dk
            System.Console.WriteLine("\nTong gia tri: {0}", results);

            System.Console.ReadKey();
        }
    }
}
