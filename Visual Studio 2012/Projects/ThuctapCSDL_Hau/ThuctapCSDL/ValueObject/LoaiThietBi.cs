namespace ThuctapCSDL.ValueObject
{
    public class LoaiThietBi
    {
        private string maLoaiThietBi;
        private string tenLoaiThietBi;

        public string MaLoaiThietBi
        {
            get
            {
                return maLoaiThietBi;
            }
            set
            {
                maLoaiThietBi = value;
            }
        }

        public string TenLoaiThietBi
        {
            get
            {
                return tenLoaiThietBi;
            }
            set
            {
                tenLoaiThietBi = value;
            }
        }
    }
}
