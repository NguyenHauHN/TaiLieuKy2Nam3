using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuctapCSDL.ValueObject
{
    public class ChiTietPhieuNhap
    {
        private string maPhieu;
        private string tenTB;
        private int soLuong;

        public string MaPhieu
        {
            get 
            {
                return maPhieu;
            }
            set {
                maPhieu = value;
            }
        }
        public string TenTB
        {
            get
            {
                return tenTB;
            }
            set
            {
                tenTB = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }

    }
}
