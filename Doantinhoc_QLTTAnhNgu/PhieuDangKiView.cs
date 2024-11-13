using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class PhieuDangKiView
    {
        public string maphieu
        {
            get; set;
        }
        public string ngaydangki
        {
            get; set;
        }

       
        public string diachilap
        {
            get; set;
        }
        public string nguoixacnhan
        {
            get; set;
        }
        public string malop
        {
            get; set;
        }
        public string tenlop
        {
            get; set;
        }
        public double hocphi
        {
            get; set;
        }
        public double uudai
        {
            get; set;
        }
       
        public string mahv
        {
            get; set;
        }
      
        public string tenhv
        {
            get; set;
        }
       
        public string ngaysinh
        {
            get; set;
        }
        public string gioitinh
        {
            get; set;
        }

        public string sdt
        {
            get; set;
        }
        public string diachi
        {
            get; set;
        }

       
        public static List<PhieuDangKiView> chuyendoi(List<phieudangki> dsphieu)
        {
            List<PhieuDangKiView> a = new List<PhieuDangKiView>();
            foreach (phieudangki b in dsphieu)
            {
                PhieuDangKiView c = new PhieuDangKiView();
                c.maphieu = b.maphieu;
                c.ngaydangki = b.ngaydangki.ToShortDateString();
                c.diachilap = b.diachilap;
                c.nguoixacnhan = b.nguoixacnhan;
                c.uudai = b.uudai;
                c.malop = b.Malop;
                c.tenlop = b.Tenlop;
                c.hocphi = b.hocphi;
                c.mahv = b.mahv;
                c.tenhv = b.tenhv;
                c.ngaysinh = b.ngaysinh.ToShortDateString();
                c.gioitinh = (b.gioitinh == true) ? "Nam" : "Nữ";
                c.sdt = b.sdt;
                c.diachi = b.diachi;
              
                
                a.Add(c);
            }
            return a;
        }
       

    }
}
