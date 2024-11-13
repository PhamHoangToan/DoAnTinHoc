using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doantinhoc_QLTTAnhNgu
{
    public partial class Quyenhocvien : Form
    {
        public event EventHandler DangXuat;
        public bool isExit = true;
        public Quyenhocvien()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormLopHoc a = new FormLopHoc(0);
            a.Show();
            this.Show();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            isExit = false;
            DangXuat(this, new EventArgs());
            this.Close();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGiaoVien a = new FormGiaoVien(0);
            a.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKhoaHoc a = new FormKhoaHoc(0);
            a.Show();
            this.Show();
        }

        private void btnhocvien_Click(object sender, EventArgs e)
        {
            FormHocVien a = new FormHocVien(0);
            a.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPhieuDangKi a = new FormPhieuDangKi(0);
            a.Show();
            this.Show();
        }
    }
}
