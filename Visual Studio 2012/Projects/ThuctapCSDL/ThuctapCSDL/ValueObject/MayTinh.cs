using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuctapCSDL.ValueObject
{
    public class MayTinh
    {
        public string MaMay { set; get; }

        public string TenMay { set; get; }

        public string TinhTrang { set; get; }

        public string CauHinh { set; get; }

        public DateTime NgayLapDat { set; get; }

        public string MaPhong { set; get; }
    }
}
