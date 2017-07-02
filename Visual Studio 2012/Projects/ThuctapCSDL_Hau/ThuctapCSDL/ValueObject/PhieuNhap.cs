using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuctapCSDL.ValueObject
{
    public class PhieuNhap
    {
        private string maPhieu;
        private string ngayNhap;
        private string maNCC;
        public string MaPhieu{
            get
            {
                return maPhieu;
            }
            set
            {
                maPhieu = value;
            }
        }

        public string NgayNhap
        {
            get
            {
                return ngayNhap;
            }
            set
            {
                ngayNhap = value;
            }
        }

        public string MaNCC
        {
            get
            {
                return maNCC;
            }
            set
            {
                maNCC = value;
            }
        }
    }
}
