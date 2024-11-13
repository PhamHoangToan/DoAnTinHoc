using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class Taikhoan
    {
        private string m_tentaikhoan;
        private string m_matkhau;
        private int m_phanquyen;

        public String tentaikhoan
        {
            get { return m_tentaikhoan;}
            set { m_tentaikhoan = value;}
        }

        public string matkhau
        {
            get { return m_matkhau; }
            set { m_matkhau = value; }
        }
        public int phanquyen
        {
            get { return m_phanquyen; }
            set { m_phanquyen = value; }
        }
        public Taikhoan()
        {
            m_tentaikhoan = "";
            m_matkhau = "";
            m_phanquyen = 0;

        }
        public Taikhoan(string tentaikhoan, string matkhau, int phanquyen)
        {
            m_tentaikhoan = tentaikhoan;
            m_matkhau = matkhau;
            m_phanquyen=phanquyen;
           
        }
    }
}
