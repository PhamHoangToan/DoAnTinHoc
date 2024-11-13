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
    public partial class trangchu : Form
    {
        List<Taikhoan> listtk = Danhsachtaikhoan.Instance.dstk;
        public trangchu()
        {
            InitializeComponent();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            int islogin = kiemtradangnhap(txttaikhoan.Text, txtmatkhau.Text);
            if (islogin >= 0)
            {

                if (islogin == 1)
                {
                    Menu a = new Menu();
                    a.Show();
                    a.DangXuat += A_DangXuat;

                }
                else if (islogin == 0)
                {
                    Quyenhocvien a = new Quyenhocvien();
                    a.Show();
                    a.DangXuat += Phanquyen_DangXuat;

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("mật khẩu sai Hoặc tài khoản sai");
                //txttaikhoan.Focus();
            }
            txttaikhoan.Text = string.Empty;
            txtmatkhau.Text = string.Empty;

        }

        private void A_DangXuat(object? sender, EventArgs e)
        {
            (sender as Menu).isExit = false;

            (sender as Menu).Close();

            this.Show();
        }
        private void Phanquyen_DangXuat(object? sender, EventArgs e)
        {

            (sender as Quyenhocvien).isExit = false;

            (sender as Quyenhocvien).Close();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int kiemtradangnhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listtk.Count; i++)
            {
                if (tentaikhoan == listtk[i].tentaikhoan && matkhau == listtk[i].matkhau)
                {
                    return listtk[i].phanquyen;
                }
            }
            return -1;
        }

        private void cbpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpass.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
        }
    }
}
