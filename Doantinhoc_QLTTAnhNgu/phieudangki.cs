namespace Doantinhoc_QLTTAnhNgu
{
    [Serializable]
    internal class phieudangki
    {
        private string m_maphieu;
        private DateTime m_ngaydangky;
        private string m_diachilap;
        private string m_nguoixacnhan;
        private double m_uudai;
        private double m_hocphi;
        private string m_malop;
        private string m_tenlop;
        private DateTime m_ngaybatdau;
        private DateTime m_ngayketthuc;
        private string m_mahv;
        private string m_tenhv;
        private DateTime m_ngaysinh;
        private bool m_gioitinh;
        private string m_sdt;
        private string m_diachi;
        private DateTime m_ngaycapnhat;
        private lopHoc m_lophoc;

        public double uudai
        {
            get { return m_uudai; }
            set { m_uudai = value; }
        }


        public string maphieu
        {
            get { return m_maphieu; }
            set { m_maphieu = value; }
        }

        public DateTime ngaydangki
        {
            get { return m_ngaydangky; }
            set { m_ngaydangky = value; }
        }
        public DateTime ngaycapnhat
        {
            get { return m_ngaycapnhat; }
            set { m_ngaycapnhat = value; }
        }

        public string diachilap
        {
            get { return m_diachilap; }
            set { m_diachilap = value; }
        }
        public string nguoixacnhan
        {
            get { return m_nguoixacnhan; }
            set { m_nguoixacnhan = value; }
        }
     
        public string Malop
        {
            get { return m_malop; }
            set { m_malop = value; }
        }
        public string Tenlop
        {
            get { return m_tenlop; }
            set { m_tenlop = value; }
        }
        public DateTime Ngaybatdau
        {
            get { return m_ngaybatdau; }
            set { m_ngaybatdau = value; }
        }

        public DateTime Ngayketthuc
        {
            get { return m_ngayketthuc; }
            set { m_ngayketthuc = value; }
        }
        public double hocphi
        {
            get { return m_hocphi; }
            set { m_hocphi = value; }
        }

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
        public string diachi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }

        public lopHoc LopHoc
        {
            get { return m_lophoc; }
            set { m_lophoc = value; }
        }

        public phieudangki()
        {
            m_maphieu = "";
            m_ngaydangky = DateTime.Now;
           
            m_diachilap = "";
            m_nguoixacnhan = "";
            m_uudai = 0;
            m_lophoc = null;
            //m_hocvien = null;
            m_ngaybatdau = DateTime.Now;
            m_ngayketthuc = DateTime.Now;
            m_malop = "";
            m_tenlop = "";
            m_hocphi = 0;
            m_mahv = "";
            m_tenhv = "";
            m_ngaysinh = DateTime.Now;
            m_gioitinh = false;
            m_sdt = "";
            m_diachi = "";
            m_ngaycapnhat = DateTime.Now;

        }

        public phieudangki(string maphieu, DateTime ngaydangki, string diachi, string nguoixacnhan, double uudai, hocVien hocvien, lopHoc lophoc,  List<phieudangki> chitietphieudki,  double hocphi, string malop, string tenlop,DateTime ngaybatdau,DateTime ngayketthuc, string mahv, string tenhv, DateTime ngaysinh, bool gioitinh, string sdt, string diachihv,DateTime ngaycapnhat, lopHoc lopHoc)
        {

            m_maphieu = maphieu;
            m_ngaydangky = ngaydangki;
            m_diachilap = diachi;
            m_nguoixacnhan = nguoixacnhan;
            m_ngaycapnhat = ngaycapnhat;
            m_hocphi = hocphi;
            m_uudai = uudai;
            m_lophoc = lopHoc;
            m_malop = malop;
            m_tenlop = tenlop;
            m_ngaybatdau = ngaybatdau;
            m_ngayketthuc = ngayketthuc;
            m_mahv = mahv;
            m_tenhv = tenhv;
            m_ngaysinh= ngaysinh;
            m_gioitinh= gioitinh;
            m_sdt = sdt;
            m_diachi= diachihv;
        }

        public double thanhtien()
        {

            return  m_hocphi;

        }
        public double thanhtienkhuyenmai()
        {

            return( m_hocphi - (m_hocphi * m_uudai));

        }

       
    }
}