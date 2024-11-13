namespace Doantinhoc_QLTTAnhNgu
{
    [Serializable]
    internal class khoaHoc
    {
        private String m_makhoahoc;
        private String m_tenkhoahoc;
        private DateTime m_ngaybatdau;
        private DateTime m_ngayketthuc;


        public String makhoahoc
        {
            get { return m_makhoahoc; }
            set { m_makhoahoc = value; }

        }

        public String tenKhoahoc
        {
            get { return m_tenkhoahoc; }
            set { m_tenkhoahoc = value; }

        }

        public DateTime ngaybatdau
        {
            get { return m_ngaybatdau; }
            set { m_ngaybatdau = value; }
        }

        public DateTime ngayketthuc
        {
            get { return m_ngayketthuc; }
            set { m_ngayketthuc = value; }
        }

        public khoaHoc()
        {
            m_makhoahoc = "";
            m_tenkhoahoc = "";
            m_ngaybatdau = DateTime.Now;
            m_ngayketthuc = DateTime.Now;
        }

        public khoaHoc(String makhoahoc, String tenkhoahoc, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            makhoahoc = m_makhoahoc;
            tenkhoahoc = m_tenkhoahoc;
            ngaybatdau = m_ngaybatdau;
            ngayketthuc = m_ngayketthuc;
        }
    }
}