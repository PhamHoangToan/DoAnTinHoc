using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class Cxulylophoc
    {
        private List<lopHoc> dsLop;
        private List<khoaHoc> dskhoahoc;

        
      


        public Cxulylophoc()
        {
            CtruyCapDuLieu data = CtruyCapDuLieu.khoitao();
            dsLop = data.getdsLopHoc();

        }

        public List<lopHoc> getdsLopHoc()
        {
            return dsLop;
            
        }
        
        public lopHoc tim(string maLopHoc)
        {
            foreach (lopHoc a in dsLop)
            {
                if (a.Malop == maLopHoc)
                { return a; }
            }
            return null;
        }

        public bool them(lopHoc a)
        {
            lopHoc t = tim(a.Malop);
            if (t != null)
                return false;
            dsLop.Add(a);
            return true;
        }

        public bool xoa(string maLopHoc)
        {
            lopHoc t = tim(maLopHoc);
            if (t == null) return false;
            dsLop.Remove(t);
            return true;
        }

        public bool sua(lopHoc a)
        {
            lopHoc t = tim(a.Malop);
            if (t == null)
                return false;
            t.Malop = a.Malop;
            t.Tenlop = a.Tenlop;
            t.Hocphi = a.Hocphi;
            t.Khu = a.Khu;
            t.Tang = a.Tang;
            t.maKhoahoc = a.maKhoahoc;
            t.tenKhoahoc=a.tenKhoahoc;
            t.maGiaoVien = a.maGiaoVien;
            t.tenGiaoVien=a.tenGiaoVien;
            return true;
        }
        public bool KiemTraLopHocTrongPhieuDangKy(string maLop, List<phieudangki> dsPhieuDangKy)
        {
            foreach (var phieu in dsPhieuDangKy)
            {
                if (phieu.Malop == maLop)
                {
                    return true; // lớp có trong danh sách phiếu đăng ký
                }
            }

            return false; // lớp không có trong danh sách phiếu đăng ký
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

       


        public List<khoaHoc> timkhoahoc(string makhoahoc,List<khoaHoc> dskhoahoc)
        {

            List<khoaHoc> array = dskhoahoc.FindAll(kh => kh.makhoahoc.Equals(makhoahoc, StringComparison.OrdinalIgnoreCase));

            return array;
        }
        public string GetMaKhoaHocFromMaLop(string Malop)
        {
            foreach (lopHoc a in dsLop)
            {
                if (Malop == a.Malop)
                {
                    return a.maKhoahoc;
                }
            }

            // Trả về null hoặc giá trị mặc định tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public bool Luufile(string tenfilelh)
        {
            try
            {
                FileStream fs = new FileStream(tenfilelh, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsLop);
                fs.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public bool docFile(string tenfilelh)
        {
            try
            {
                FileStream fs = new FileStream(tenfilelh, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsLop = bf.Deserialize(fs) as List<lopHoc>;
                fs.Close();
                return true;
            }
            catch
            {
                dsLop = new List<lopHoc>();
                return false;
            }
        }


    }
}
