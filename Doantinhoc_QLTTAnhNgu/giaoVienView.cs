using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class giaoVienView
    {
        public string magv { get; set; }
        public string tengv { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
       
        


        public static List<giaoVienView> chuyenDoi(List<giaoVien> dsgv)
        {
            List<giaoVienView> x = new List<giaoVienView>();
            foreach (giaoVien a in dsgv)
            {
                giaoVienView b = new giaoVienView();
                b.magv = a.maGiaoVien;
                b.tengv = a.tenGiaoVien;
                b.ngaysinh = a.ngaysinh.ToShortDateString();
                b.gioitinh = (a.gioitinh == true) ? "Nam" : "Nữ";
                b.diachi = a.diachi;
                b.email = a.email;
                b.sdt = a.sdt;
               

                x.Add(b);
            }
            return x;
        }

    }
}
