using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            test3();
            Console.ReadKey();
        }
        static void test3()
        {
            List<SinhVien> svList = new List<SinhVien>();
            SinhVien s1 = new SinhVien("01", "nguyễn văn a", 20);
            SinhVien s2 = new SinhVien("02", "nguyễn văn b", 20);
            SinhVien s3 = new SinhVien("03", "Hoàng văn c", 20);
            svList.Add(s1);
            svList.Add(s2);
            svList.Add(s3);
            for (int i = 0; i < svList.Count; i++)
            {
                if (svList[i].Hoten.Substring(0,5) == "Hoàng")
                {
                    svList[i].InSV();
                }
            }
        }
    }
}
