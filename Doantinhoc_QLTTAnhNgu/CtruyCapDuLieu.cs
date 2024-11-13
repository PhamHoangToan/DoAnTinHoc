using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class CtruyCapDuLieu
    {
        private static CtruyCapDuLieu m_data = null;
        private List<hocVien> m_dsHocVien;
        private List<khoaHoc> m_dsKhoaHoc;
        private List<lopHoc> m_dsLopHoc;
        private List<giaoVien> m_dsGiaoVien;
        private List<phieudangki> m_dsPhieuDangKi;



        private CtruyCapDuLieu()
        {
            m_dsHocVien = new List<hocVien>();
            m_dsKhoaHoc = new List<khoaHoc>();
            m_dsLopHoc = new List<lopHoc>();
            m_dsGiaoVien = new List<giaoVien>();
            m_dsPhieuDangKi = new List<phieudangki>();

        }

        public static CtruyCapDuLieu khoitao()
        {
            if (m_data == null)
            {
                m_data = new CtruyCapDuLieu();
            }
            return m_data;
        }

        public List<hocVien> getdsHocVien()
        {
            return m_dsHocVien;
        }

        public List<khoaHoc> getdsKhoaHoc()
        {
            return m_dsKhoaHoc;
        }

        public List<lopHoc> getdsLopHoc()
        {
            return m_dsLopHoc;
        }

        public List<giaoVien> getdsGiaoVien()
        {
            return m_dsGiaoVien;
        }
        public List<phieudangki> getdsPhieuDangKi()
        {
            return m_dsPhieuDangKi;
        }

    }
}

