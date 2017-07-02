using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThuatToanPrim
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

        //}

        //c2: nhap tu file txt
        public static void InitGraph()
        {
            string[] lines = System.IO.File.ReadAllLines(@"E:\Phân tích thiết kế giải thuật\Bài tập\Data\prim.txt");
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
        }

        public static void PrintGraph(List<Edge> Tree)
        {
            System.Console.WriteLine("Do thi co {0} dinh va {1} canh", SoDinh, Graph.Count);
            System.Console.WriteLine("Cay khung toi thieu tim duoc la:");
            // ghi vao file va in ra man hinh
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\Data\output.txt");
            string line;
            foreach (Edge t in Tree)
            {
                line = t.s + "," + t.e + "," + t.w;
                file.WriteLine(line);
                System.Console.WriteLine(t.s + " ..... " + t.e + " ..... " + t.w);
            }

            file.Close();
        }

        public static List<Edge> Prim()
        {
            List<Edge> Tree = new List<Edge>();
            List<int> DanhDau = new List<int>();
            //chon dinh tuy y va danh dau la da xet
            DanhDau.Add(Graph[0].s);
            // lap lai cho toi khi danh dau het cac dinh
            while (DanhDau.Count < SoDinh)
            {
                // tim canh co 1 dinh thuoc do thi va co canh nho nhat
                var Edges = Graph.Where(p => (DanhDau.Contains(p.s) && !DanhDau.Contains(p.e)) || (!DanhDau.Contains(p.s) && DanhDau.Contains(p.e)));
                var min = Edges.Min(p => p.w);
                var minEdge = Edges.Where(p => p.w == min).First();
                // them canh nay vao Tree dong thoi remove canh nay o do thi ban dau
                Tree.Add(minEdge);
                Graph.Remove(minEdge);
                // danh dau cac dinh cua canh nay la da xet
                if (!DanhDau.Contains(minEdge.s))
                {
                    DanhDau.Add(minEdge.s);
                }
                if (!DanhDau.Contains(minEdge.e))
                {
                    DanhDau.Add(minEdge.e);
                }
            }

            return Tree;
        }
        static void Main(string[] args)
        {
            InitGraph();
            List<Edge> T = new List<Edge>();
            T = Prim();
            PrintGraph(T);
            System.Console.ReadKey();
        }
    }
}
