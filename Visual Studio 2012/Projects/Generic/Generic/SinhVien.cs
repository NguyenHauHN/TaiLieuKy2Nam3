using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class SinhVien
    {
        public string Ma;
        public string Hoten;
        public int Tuoi;
        public SinhVien(string ma, string hoten, int tuoi)
        {
            Ma = ma;
            Hoten = hoten;
            Tuoi = tuoi;
        }
        public void InSV()
        {
            Console.WriteLine("Sinh viên có mã " + this.Ma + " , họ tên " + this.Hoten + " , tuổi " + this.Tuoi + ".");
        }
        
    }
}
