using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class khoaHocView
    {
        public string makhoahoc
        {
            get; set;
        }

        public string tenkhoahoc
        {
            get; set;
        }

        public string ngaybatdau
        { get; set; }

        public string ngayketthuc { get; set; }

        public static List<khoaHocView> chuyendoi(List<khoaHoc> dskh)
        {
            List<khoaHocView> x = new List<khoaHocView>();
            foreach (khoaHoc a in dskh)
            {
                khoaHocView b = new khoaHocView();
                b.makhoahoc = a.makhoahoc;
                b.tenkhoahoc = a.tenKhoahoc;
                b.ngaybatdau = a.ngaybatdau.ToShortDateString();
                b.ngayketthuc = a.ngayketthuc.ToShortDateString();
                x.Add(b);
            }
            return x;
        }
    }
}
