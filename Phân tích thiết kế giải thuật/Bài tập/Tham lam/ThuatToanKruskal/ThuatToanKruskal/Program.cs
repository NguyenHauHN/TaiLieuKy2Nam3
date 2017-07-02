using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanKruskal
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
                line = t.s + "," + t.e + "," + t.w ;
                file.WriteLine(line);
                System.Console.WriteLine(t.s + " ..... " + t.e + " ..... " + t.w);
            }
            
            file.Close();
        }

        public static List<Edge> Kruskal()
        {

            //Bước 1: Sắp xếp các cạnh của đồ thị theo thứ tự trọng số tăng dần.
            Graph = Graph.OrderBy(p => p.w).ToList();
            // ta gắn đỉnh i của đồ thị một nhãn là i
            int i = 1, j;
            Dictionary<string, int> Labels = new Dictionary<string, int>();
            foreach (Edge edge in Graph)
            {
                if (!Labels.ContainsKey(edge.e.ToString()))
                {
                    Labels.Add(edge.e.ToString(), i++);
                }
                if (!Labels.ContainsKey(edge.s.ToString()))
                {
                    Labels.Add(edge.s.ToString(), i++);
                }
            }
            //Bước 2: Khởi tạo T:= Ø
            List<Edge> Tree = new List<Edge>();
            //Bước 3: Lần lượt lấy từng cạnh thuộc danh sách đã sắp xếp.Nếu T+{ e} không chứa chu trình thì gán T:= T +{ e}.
            foreach (Edge edge in Graph)
            {
                int s = edge.s;
                int e = edge.e;
                //Nếu hai đầu cạnh e có cùng nhãn (tức là nhãn của e.v1 và nhãn của e.v2 bằng nhau) thì T+{ e}
                //tạo chu trình, ta không đưa e vào T.

                //Ngược lại[nếu Label(e.v1) != Label(e.v2)] thì ta đưa e vào T và thực hiện công việc ghép nhãn bằng cách:
                //            lab1 = Min(Label(e.v1), Label(e.v2))
                //lab2 = Max(Label(e.v1), Label(e.v2))
                //Sửa nhãn của tất cả các đỉnh nào có nhãn là lab2 thành nhãn lab1
                if (Labels[s.ToString()] != Labels[e.ToString()])
                {
                    Tree.Add(edge);
                    int lab1 = Math.Min(Labels[s.ToString()], Labels[e.ToString()]);
                    int lab2 = Math.Max(Labels[e.ToString()], Labels[s.ToString()]);

                    for(j = 1; j<= Labels.Count; j++)
                    {
                        if(Labels[j.ToString()] == lab2)
                        {
                            Labels[j.ToString()] = lab1;
                        }
                    }
                }
                //Bước 4: Nếu T đủ n-1 phần tử thì dừng, ngược lại làm tiếp bước 2.
                if (Tree.Count == SoDinh - 1)
                {
                    break;
                }
            }


            return Tree;
        }
        static void Main(string[] args)
        {
            InitGraph();
            List<Edge> T = new List<Edge>();
            T = Kruskal();
            PrintGraph(T);
            System.Console.ReadKey();
        }
    }
}
