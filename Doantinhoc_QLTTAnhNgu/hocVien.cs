using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{

    [Serializable]
    internal class hocVien
    {
        private string m_mahv;
        private string m_tenhv;
        private DateTime m_ngaysinh;
        private bool m_gioitinh;
        private string m_sdt;
        private string m_email;
        private string m_diachi;
        private string m_lophoc;
        private string m_khoahoc;
        private double m_diem;


        public String mahv
        {
            get { return m_mahv; }
            set { m_mahv = value; }
        }
        public string tenhv
        {
            get { return m_tenhv; }
            set { m_tenhv = value; }
        }
        public DateTime ngaysinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }
        public bool gioitinh
        {
            get { return m_gioitinh; }
            set { m_gioitinh = value; }
        }
        public string sdt
        {
            get { return m_sdt; }
            set { m_sdt = value; }

        }
        public string email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        public string diachi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
        public string lophoc
        {
            get { return m_lophoc; }
            set { m_lophoc = value; }
        }
        public string khoahoc
        {
            get { return m_khoahoc; }
            set { m_khoahoc = value; }
        }
        public double diem
        {
            get { return m_diem; }
            set { m_diem = value; }
        }

        public hocVien()
        {
            m_mahv = "";
            m_tenhv = "";
            m_ngaysinh = DateTime.Now;
            m_gioitinh = false;
            m_sdt = "";
            m_email = "";
            m_diachi = "";
            m_lophoc = "";
            m_khoahoc = "";
            m_diem = 0;

        }

        public hocVien(string mahv, string tenhv, DateTime ngaysinh, bool gioitinh, string sdt, string email, string diachi, string lophoc, string khoahoc, double diem)
        {
            m_mahv = mahv;
            m_tenhv = tenhv;
            m_ngaysinh = ngaysinh;
            m_gioitinh = gioitinh;
            m_sdt = sdt;
            m_email = email;
            m_diachi = diachi;
            m_lophoc = lophoc;
            m_khoahoc = khoahoc;
            m_diem = diem;

        }
    }
}

