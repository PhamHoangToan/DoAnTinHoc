using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doantinhoc_QLTTAnhNgu
{
    internal class Danhsachtaikhoan
    {
        private static Danhsachtaikhoan instance;
        public static Danhsachtaikhoan Instance
        {
            get { if(instance==null)
                    instance=new Danhsachtaikhoan();
                return instance; }
            set { instance = value; }
        }
        List<Taikhoan> m_dstk;
        public List<Taikhoan> dstk
        {
            get { return m_dstk; }
            set { m_dstk = value; }
        }
       
        Danhsachtaikhoan()
        {
            dstk = new List<Taikhoan>();
            dstk.Add(new Taikhoan("admin","123",1));
            dstk.Add(new Taikhoan("hocvien", "456",0));
        }
    }
}
