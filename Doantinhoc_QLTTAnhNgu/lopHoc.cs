namespace Doantinhoc_QLTTAnhNgu
{
    [Serializable]
    internal class lopHoc
    {
        private string m_malop;
        private string m_maGiaoVien;
        private string m_tenGiaoVien;
        private string m_makhoahoc;
        private string m_tenkhoahoc;
        //private DateTime m_ngaybatdau;
        //private DateTime m_ngayketthuc;
        private string m_tenlop;
        private double m_hocphi;
        private string m_khu;
        private string m_tang;
        private khoaHoc m_khoahoc;

        public string Malop
        {
            get { return m_malop; }
            set { m_malop = value; }
        }
        public string maGiaoVien
        {
            get { return m_maGiaoVien; }
            set { m_maGiaoVien = value; }
        }
        public string tenGiaoVien
        {
            get { return m_tenGiaoVien; }
            set { m_tenGiaoVien = value; }
        }

        public string maKhoahoc
        {
            get { return m_makhoahoc; }
            set { m_makhoahoc = value; }
        }
        public string tenKhoahoc
        {
            get { return m_tenkhoahoc; }
            set { m_tenkhoahoc = value; }
        }
        public khoaHoc khoahoc
        {
            get { return m_khoahoc; }
            set { m_khoahoc= value; }
        }
        //public DateTime Ngaybatdau
        //{
        //    get { return m_ngaybatdau; }
        //    set { m_ngaybatdau = value; }
        //}

        //public DateTime Ngayketthuc
        //{
        //    get { return m_ngayketthuc; }
        //    set { m_ngayketthuc = value; }
        //}
        public string Tenlop
        {
            get { return m_tenlop; }
            set { m_tenlop = value; }
        }
        public double Hocphi
        {
            get { return m_hocphi; }
            set { m_hocphi = value; }
        }
        public string Khu
        {
            get { return m_khu; }
            set { m_khu = value; }
        }
        public string Tang
        {
            get { return m_tang; }
            set { m_tang = value; }
        }

        public lopHoc()
        {
            m_malop = "";
            m_maGiaoVien = "";
            m_tenGiaoVien = "";
            m_makhoahoc = "";
            m_tenkhoahoc = "";
            //m_ngaybatdau=DateTime.Now;
            //m_ngayketthuc=DateTime.Now;
            m_tenlop = "";
            m_hocphi = 0;
            m_khu = "";
            m_tang = "";
           // m_khoahoc = null;
        }

        public lopHoc(string malop,string magiaovien,string tengiaovien, string makhoa, string tenkhoahoc, DateTime ngaybatdau, DateTime ngayketthuc ,string tenlop, double hocphi, string khu, string tang,khoaHoc khoahoc)
        {
            m_malop = malop;
            m_maGiaoVien=magiaovien;
            m_tenGiaoVien = tengiaovien;
            m_makhoahoc = makhoa;
            m_tenkhoahoc=tenkhoahoc;
            //m_ngaybatdau = ngaybatdau;
            //m_ngayketthuc = ngayketthuc;
            m_tenlop = tenlop;
            m_hocphi = hocphi;
            m_khu = khu;
            m_tang = tang;
            m_khoahoc=khoahoc;
        }
    }
}
