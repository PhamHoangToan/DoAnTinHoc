using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class hocVienView
    {
        public string mahv { get; set; }
        public string tenhv { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string khoahoc { get; set; }
        public string lophoc { get; set; }
        public double diem { get; set; }

        public static List<hocVienView> chuyendoi(List<hocVien> dshv)
        {
            List<hocVienView> x = new List<hocVienView>();
            foreach (hocVien a in dshv)
            {
                hocVienView b = new hocVienView();
                b.mahv = a.mahv;
                b.tenhv = a.tenhv;
                b.ngaysinh = a.ngaysinh.ToShortDateString();
                b.gioitinh = (a.gioitinh == true) ? "Nam" : "Nữ";
                b.diachi = a.diachi;
                b.email = a.email;
                b.sdt = a.sdt;
                b.khoahoc = a.khoahoc;
                b.lophoc = a.lophoc;
                b.diem = a.diem;
                x.Add(b);
            }
            return x;
        }

    }
}
