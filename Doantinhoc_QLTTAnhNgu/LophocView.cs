using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class LophocView
    {
        public string Malop
        {
            get;
            set;
        }
        public string maGiaoVien
        {
            get;
            set;
        }
        public string tenGiaoVien
        {
            get;
            set;
        }

        public string maKhoahoc
        {
            get;
            set;
        }
        public string tenKhoahoc
        {
            get;
            set;
        }
        public string Tenlop
        {
            get;
            set;
        }
        public double Hocphi
        {
            get;
            set;
        }
        public string Khu
        {
            get;
            set;
        }
        public string Tang
        {
            get;
            set;
        }
        public static List<LophocView> chuyendoi(List<lopHoc> dslh)
        {
            List<LophocView> x = new List<LophocView>();
            foreach (lopHoc a in dslh)
            {
                LophocView b = new LophocView();
               b.Malop = a.Malop;
                b.maGiaoVien = a.maGiaoVien;
                b.tenGiaoVien = a.tenGiaoVien;
                b.maKhoahoc = a.maKhoahoc;
                b.tenKhoahoc = a.tenKhoahoc;
                b.Tenlop = a.Tenlop;
                b.Hocphi = a.Hocphi;
                b.Khu = a.Khu;
                b.Tang = a.Tang;
                x.Add(b);
            }
            return x;
        }
    }
}
