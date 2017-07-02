using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanDijktra
{
    class Program
    {
        const int MAX = 10000;
        //tao cau truc canh
        public struct Edge
        {
            public int s;
            public int e;
            public int w;
            public Edge(int _s, int _e, int _w)
            {
                s = _s;
                e = _e;
                w = _w;
            }
        }

        // tao do thi
        public static List<Edge> Graph;
        public static int SoDinh;
        public static int DinhDau;

        // khoi tao do thi
        //c1: nhap du lieu cung
        //public static void InitGraph()
        //{
        //    Graph = new List<Edge>();
        //    Graph.Add(new Edge(1, 2, 33));
        //    Graph.Add(new Edge(1, 3, 17));
        //    Graph.Add(new Edge(2, 3, 18));
        //    Graph.Add(new Edge(2, 4, 20));
        //    Graph.Add(new Edge(3, 4, 16));
        //    Graph.Add(new Edge(3, 5, 4));
        //    Graph.Add(new Edge(4, 5, 9));
        //    Graph.Add(new Edge(4, 6, 8));
        //    Graph.Add(new Edge(5, 6, 14));
        //    // tinh so dinh cua do thi
        //    List<int> dsDinh = new List<int>();
        //    foreach (Edge edge in Graph)
        //    {
        //        if (!dsDinh.Contains(edge.s))
        //        {
        //            dsDinh.Add(edge.s);
        //        }
        //        if (!dsDinh.Contains(edge.e))
        //        {
        //            dsDinh.Add(edge.e);
        //        }
        //    }
        //    SoDinh = dsDinh.Count;
        //    DinhDau = Graph[0].s;
        //}

        //c2: nhap tu file txt
        public static void InitGraph()
        {
            string[] lines = System.IO.File.ReadAllLines(@"E:\Phân tích thiết kế giải thuật\Bài tập\ThuatToanDijktra\Data\input1.txt");
            string[] elements;
            Graph = new List<Edge>();
            foreach (string line in lines)
            {
                elements = line.Split(' ');
                Graph.Add(new Edge(Convert.ToInt32(elements[0]), Convert.ToInt32(elements[1]), Convert.ToInt32(elements[2])));

            }
            // tinh so dinh cua do thi

            List<int> dsDinh = new List<int>();
            foreach (Edge edge in Graph)
            {
                if (!dsDinh.Contains(edge.s))
                {
                    dsDinh.Add(edge.s);
                }
                if (!dsDinh.Contains(edge.e))
                {
                    dsDinh.Add(edge.e);
                }
            }
            SoDinh = dsDinh.Count;
            DinhDau = Graph[0].s;
        }

        public static void PrintGraph(List<int> Tree)
        {
            System.Console.WriteLine("Do thi co {0} dinh va {1} canh", SoDinh, Graph.Count);
            System.Console.WriteLine("Duong di ngan nhat tu dinh {0} den cac dinh con lai la :");
            // ghi vao file va in ra man hinh
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\ThuatToanDijktra\Data\output.txt");
            string line;
            int dem = 1;
            foreach (var t in Tree)
            {
                if(dem < Tree.Count)
                {
                    line = t + " -> ";
                }
                else
                {
                    line = t.ToString();
                }
                dem++;
                file.Write(line);
                System.Console.Write(line);
            }

            file.Close();
        }

        public static List<int> Dijktra()
        {
            List<int> T = new List<int>();
            List<int> DanhDau = new List<int>();
            // khoi tao
            Dictionary<int, int> labels = new Dictionary<int, int>();
           
            labels.Add(DinhDau, 0);
            T.Add(Graph[0].s);
            DanhDau.Add(Graph[0].s);
            foreach (Edge edge in Graph)
            {
                if (!labels.ContainsKey(edge.s))
                {
                    labels.Add(edge.s, MAX);
                }
                if (!labels.ContainsKey(edge.e))
                {
                    labels.Add(edge.e, MAX);
                }

            }
            
            while (DanhDau.Count < SoDinh)
            {
                // Cap nhat lai nhan
                var Edges = Graph.Where(p => (p.s == DinhDau) || (p.e == DinhDau));
                foreach (Edge edge in Edges)
                {
                    if (edge.s == DinhDau && labels[DinhDau] + edge.w < labels[edge.e])
                    {
                        labels[edge.e] = labels[DinhDau] + edge.w;
                    }
                    else if (edge.e == DinhDau && labels[DinhDau] + edge.w < labels[edge.s])
                    {
                        labels[edge.s] = labels[DinhDau] + edge.w;

                    }
                }
                // Khoi tao lai cac gia tri va ghi nhan dinh
                var min = labels.OrderBy(kvp => kvp.Value);
                foreach(var item in min)
                {
                    if (!DanhDau.Contains(item.Key))
                    {
                        DinhDau = item.Key;
                        break;
                    }
                }
                DanhDau.Add(DinhDau);
                T.Add(DinhDau);
            }
            return T;
        }
        static void Main(string[] args)
        {
            List<int> Tree = new List<int>();
            InitGraph();
            Tree = Dijktra();
            PrintGraph(Tree);
            System.Console.ReadKey();
        }
    }
}
