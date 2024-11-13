namespace Doantinhoc_QLTTAnhNgu
{
    [Serializable]
    internal class giaoVien
    {
        private string m_maGiaoVien;
        private string m_tenGiaoVien;
        private DateTime m_ngaySinh;
        private bool m_gioiTinh;
        private string m_sdt;
        private string m_email;
        private string m_diachi;
       
      

        public String maGiaoVien
        {
            get { return m_maGiaoVien; }
            set { m_maGiaoVien = value; }
        }
        public string tenGiaoVien
        {
            get { return m_tenGiaoVien; }
            set { m_tenGiaoVien = value; }
        }
        public DateTime ngaysinh
        {
            get { return m_ngaySinh; }
            set { m_ngaySinh = value; }
        }
        public bool gioitinh
        {
            get { return m_gioiTinh; }
            set { m_gioiTinh = value; }
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
      
        


        public giaoVien()
        {
            m_maGiaoVien = "";
            m_tenGiaoVien = "";
            m_ngaySinh = DateTime.Now;
            m_gioiTinh = false;
            m_sdt = "";
            m_email = "";
            m_diachi = "";
           
        


        }

        public giaoVien(string magv, string tengv, DateTime ngaysinh, bool gioitinh, string sdt, string email, string diachi)
        {
            m_maGiaoVien = magv;
            m_tenGiaoVien = tengv;
            m_ngaySinh = ngaysinh;
            m_gioiTinh = gioitinh;
            m_sdt = sdt;
            m_email = email;
            m_diachi = diachi;
           


        }
    }
}
