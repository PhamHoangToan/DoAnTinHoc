using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class CxuLyHocVien
    {
        private List<hocVien> dsHV;
        
       

        public CxuLyHocVien()
        {
            CtruyCapDuLieu data = CtruyCapDuLieu.khoitao();
            dsHV = data.getdsHocVien();
        }

        public List<hocVien> getdsHocVien()
        { return dsHV; }

        public hocVien Tim(String mahv)
        {
            foreach (hocVien a in dsHV)
            {
                if (a.mahv == mahv)
                { return a; }
            }
            return null;
        }
        //public hocVien cat(string text)
        //{
        //    if (text != null)
        //    {
        //        text = text.Replace("{", "");
        //        text = text.Replace("}", "");
        //        string[] lines = text.Split(new char[] { '-' });
        //        hocVien hv = new hocVien();
        //        hv.mahv = lines[0];
        //        hv.tenhv = lines[1];
        //        hv.ngaysinh = DateTime.Parse(lines[2]);
        //        hv.gioitinh = lines[3] == "True" || false;
        //        hv.sdt = lines[4];
        //        hv.email = lines[5];
        //        hv.diachi = lines[6];
        //        hv.lophoc = lines[7];
        //        hv.khoahoc = lines[8];
        //        hv.diem = Double.Parse(lines[9]);
        //        return hv;

        //    }
        //    return null;
        //}

        //public List<hocVien> getdata()
        //{
        //    string text =docFile("danhsach.txt");
        //    string[] lines = text.Split(new char[] { '\n' });
        //    List<hocVien> dshv = new List<hocVien>();
        //    lines.ToList().ForEach(x =>
        //    {
        //        if (!x.Equals(""))
        //        {
        //            dshv.Add(cat(x));
        //        }

        //    });
        //    return dshv;
        //}
        public bool Them(hocVien a)
        {
            hocVien t = Tim(a.mahv);
            if (t != null)
                return false;
            dsHV.Add(a);
            return true;
        }

        public bool xoa(string mahv)
        {
            hocVien t = Tim(mahv);
            if (t == null) return false;
            dsHV.Remove(t);
            return true;
        }

        public bool sua(hocVien a)
        {
            hocVien t = Tim(a.mahv);
            if (t == null) return false;
            t.tenhv = a.tenhv;
            t.gioitinh = a.gioitinh;
            t.ngaysinh = a.ngaysinh;
            t.sdt = a.sdt;
            t.email = a.email;
            t.diachi = a.diachi;
            t.khoahoc = a.khoahoc;
            t.lophoc = a.lophoc;
            t.diem = a.diem;
            //dsHV.Add(a);
            return true;
        }

        public bool KiemTraSinhVienTrongPhieuDangKy(string maHocVien, List<phieudangki> dsPhieuDangKy)
        {
            foreach (var phieu in dsPhieuDangKy)
            {
                if (phieu.mahv == maHocVien)
                {
                    return true; // Sinh viên có trong danh sách phiếu đăng ký
                }
            }

            return false; // Sinh viên không có trong danh sách phiếu đăng ký
        }
        public bool Luufile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsHV);
                fs.Close();
                return true;

            }catch (Exception ex)
            {
                return false;
            }


        }

        public bool docFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsHV = bf.Deserialize(fs) as List<hocVien>;
                fs.Close();
                return true;
            }
            catch
            {
                dsHV=new List<hocVien>();
                return false;
            }
        }

    }
}

