  using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{

    internal class CxuLyGiaoVien
    {
        private List<giaoVien> dsGV;
        
        public CxuLyGiaoVien()
        {
            CtruyCapDuLieu data = CtruyCapDuLieu.khoitao();
            dsGV = data.getdsGiaoVien();
        }

        public List<giaoVien> getdsgiaovien()
        { return dsGV; }

        public giaoVien Tim(String magv)
        {
            foreach (giaoVien a in dsGV)
            {
                if (a.maGiaoVien == magv)
                { return a; }
            }
            return null;
        }

        public bool Them(giaoVien a)
        {
            giaoVien t = Tim(a.maGiaoVien);
            if (t != null)
                return false;
            dsGV.Add(a);
            return true;
        }

        public bool xoa(string magv)
        {
            giaoVien t = Tim(magv);
            if (t == null) return false;
            dsGV.Remove(t);
            return true;
        }

        public bool sua(giaoVien a)
        {
            giaoVien t = Tim(a.maGiaoVien);
            if (t == null) return false;
            t.tenGiaoVien = a.tenGiaoVien;
            t.gioitinh = a.gioitinh;
            t.ngaysinh = a.ngaysinh;
            t.sdt = a.sdt;
            t.email = a.email;
            t.diachi = a.diachi;
           
            
            return true;
        }

        //public giaoVien cat(string text)
        //{
        //    if (text != null)
        //    {
        //        text = text.Replace("{", "");
        //        text = text.Replace("}", "");
        //        string[] lines = text.Split(new char[] { '-' });
        //        giaoVien gv = new giaoVien();
        //        gv.maGiaoVien = lines[0];
        //        gv.tenGiaoVien = lines[1];
        //        gv.ngaysinh = DateTime.Parse(lines[2]);
        //        gv.gioitinh = lines[3] == "True" || false;
        //        gv.sdt = lines[4];
        //        gv.email = lines[5];
        //        gv.diachi = lines[6];
        //        gv.lophoc = lines[7];


        //        return gv;

        //    }
        //    return null;
        //}

        //public List<giaoVien> getdata()
        //{
        //    string text = docFile(SAVE_TEACHER);
        //    string[] lines = text.Split(new char[] { '\n' });
        //    List<giaoVien> dshv = new List<giaoVien>();
        //    lines.ToList().ForEach(x =>
        //    {
        //        if (!x.Equals(""))
        //        {
        //            dshv.Add(cat(x));
        //        }

        //    });
        //    return dshv;
        //}
        public bool Luufile(string tenfilegv)
        {
            try
            {
                FileStream fs = new FileStream(tenfilegv, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsGV);
                fs.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public bool KiemTraGiaoVienTrongLopHoc(string maGiaoVien, List<lopHoc> dsLop)
        {
            foreach (var lop in dsLop)
            {
                if (lop.maGiaoVien == maGiaoVien)
                {
                    return true; // khóa có trong danh sách lớp học
                }
            }

            return false; // khóa không có trong danh sách lớp học
        }

        public bool docFile(string tenfilegv)
        {
            try
            {
                FileStream fs = new FileStream(tenfilegv, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsGV = bf.Deserialize(fs) as List<giaoVien>;
                fs.Close();
                return true;
            }
            catch
            {
                dsGV = new List<giaoVien>();
                return false;
            }
        }
    }
}
