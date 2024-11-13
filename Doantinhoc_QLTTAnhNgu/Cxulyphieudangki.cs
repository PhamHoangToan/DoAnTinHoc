using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class Cxulyphieudangki
    {
        private List<phieudangki> dsphieudangki;
        

        public Cxulyphieudangki()
        {
            CtruyCapDuLieu data = CtruyCapDuLieu.khoitao();
            dsphieudangki = data.getdsPhieuDangKi();

        }
        public List<phieudangki> getdsphieudangki()
        {
            return dsphieudangki;
        }

        public phieudangki tim(string maphieu)
        {
            foreach (phieudangki a in dsphieudangki)
            {
                if (a.maphieu == maphieu)
                { return a; }
            }
            return null;
        }
        public bool them(phieudangki a)
        {
            phieudangki t = tim(a.maphieu);
            if (t == null)
            {
                dsphieudangki.Add(a);
                return true;
            }
            return false;

        }

        public bool xoa(string maphieu)
        {
            phieudangki t = tim(maphieu);
            if (t == null)
                return false;
            dsphieudangki.Remove(t);
            return true;
        }
        public double thanhtienTong()
        {

            double s = 0;
            foreach (phieudangki a in dsphieudangki)
            {
                s = a.thanhtienkhuyenmai();
            }
            return s;
        }

        public bool kiemtralop(string Malop, List<hocVien> dshocvien)
        {
            foreach (var hv in dshocvien)
            {
                if (hv.lophoc == Malop)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Luufile(string tenfiledk)
        {
            try
            {
                FileStream fs = new FileStream(tenfiledk, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsphieudangki);
                fs.Close();
                return true;

            }
            catch 
            {
                return false;
            }
        }
        public bool sua(phieudangki a)
        {
            phieudangki t = tim(a.maphieu) ;
            if (t == null)
                return false;
            t.maphieu = a.maphieu;
            t.ngaydangki = a.ngaydangki;
            t.diachilap=a.diachilap;
            t.nguoixacnhan=a.nguoixacnhan;
            t.uudai=a.uudai;
            t.Malop = a.Malop;
            t.Tenlop = a.Tenlop;
            t.hocphi = a.hocphi;
            t.mahv = a.mahv;
            t.tenhv = a.tenhv;
            t.ngaysinh = a.ngaysinh;
            t.gioitinh = a.gioitinh;
            t.sdt=a.sdt;
            t.diachi=a.diachi;
            return true;
        }

        public bool docFile(string tenfiledk)
        {
            try
            {
                FileStream fs = new FileStream(tenfiledk, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsphieudangki = bf.Deserialize(fs) as List<phieudangki>;
                fs.Close();
                return true;
            }
            catch
            {
                dsphieudangki = new List<phieudangki>();
                return false;
            }
        }


    }
}

