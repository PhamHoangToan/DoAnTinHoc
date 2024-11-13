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
    public partial class Menu : Form
    {
        public bool isExit = true;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnhocvien_Click(object sender, EventArgs e)
        {
            FormHocVien a = new FormHocVien(1);
            a.Show();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormLopHoc a = new FormLopHoc(1);
            a.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKhoaHoc a = new FormKhoaHoc(1);
            a.Show();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGiaoVien a = new FormGiaoVien(1);
            a.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPhieuDangKi a = new FormPhieuDangKi(1);
            a.Show();
            this.Show();
        }




        public event EventHandler DangXuat;


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

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }

        }
    }
}
