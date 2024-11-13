using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class CxuLyKhoaHoc
    {
        private List<khoaHoc> dskh;
        

        public CxuLyKhoaHoc()
        {
            CtruyCapDuLieu data = CtruyCapDuLieu.khoitao();
            dskh = data.getdsKhoaHoc();
        }

        public List<khoaHoc> getdsKhoaHoc()
        {
            return dskh;
        }

        public khoaHoc tim(String makhoahoc)
        {
            foreach (khoaHoc a in dskh)
            {
                if (makhoahoc == a.makhoahoc)
                    return a;
            }
            return null;
        }

        public bool them(khoaHoc a)
        {
            khoaHoc t = tim(a.makhoahoc);
            if (t != null) { return false; }
            dskh.Add(a);
            return true;
        }

        public bool xoa(String makhoahoc)
        {
            khoaHoc t = tim(makhoahoc);
            if (t == null) { return false; }
            dskh.Remove(t);
            return true;
        }

        public bool sua(khoaHoc a)
        {
            khoaHoc t = tim(a.makhoahoc);
            t.makhoahoc = a.makhoahoc;
            t.tenKhoahoc = a.tenKhoahoc;
            t.ngaybatdau = a.ngaybatdau;
            t.ngayketthuc = a.ngayketthuc;
            return true;
        }
        public bool KiemTraKhoaHocTrongLopHoc(string maKhaohoc, List<lopHoc> dsLop)
        {
            foreach (var lop in dsLop)
            {
                if (lop.maKhoahoc == maKhaohoc)
                {
                    return true; // khóa có trong danh sách lớp học
                }
            }

            return false; // khóa không có trong danh sách lớp học
        }
        public bool Luufile(string tenfilekh)
        {
            try
            {
                FileStream fs = new FileStream(tenfilekh, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dskh);
                fs.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public bool docFile(string tenfilekh)
        {
            try
            {
                FileStream fs = new FileStream(tenfilekh, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dskh = bf.Deserialize(fs) as List<khoaHoc>;
                fs.Close();
                return true;
            }
            catch
            {
                dskh = new List<khoaHoc>();
                return false;
            }
        }
    }
}
