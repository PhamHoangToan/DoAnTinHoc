using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doantinhoc_QLTTAnhNgu
{
    public partial class FormGiaoVien : Form
    {
        private CxuLyGiaoVien xlgv;
        private Cxulylophoc xllop;
        private int m_status;

        public FormGiaoVien(int status)
        {
            InitializeComponent();
            this.m_status = status;
        }

        private void hienthi(List<giaoVien> dsGV)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = giaoVienView.chuyenDoi(dsGV);
            dgvgv.DataSource = bs;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            xlgv = new CxuLyGiaoVien();
            xllop = new Cxulylophoc();
            string s = "Danhsachgiaovien.txt";
            xlgv.docFile(s);
            string s1 = "Danhsachlop.txt";
            xllop.docFile(s1);
            hienthi(xlgv.getdsgiaovien());

        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvgv.SelectedRows)
            {

                if (e.RowIndex >= 0 && e.RowIndex < dgvgv.Rows.Count)
                {
                    // Get the row
                    DataGridViewRow row = dgvgv.Rows[e.RowIndex];

                    // Check if the row is not null
                    if (row != null)
                    {
                        string magv = r.Cells[0].Value.ToString();
                        giaoVien a = xlgv.Tim(magv);
                        if (a != null)
                        {
                            txtmagv.Text = a.maGiaoVien;
                            txttengv.Text = a.tenGiaoVien;
                            dtpngaysinh.Value = a.ngaysinh;
                            txtdiachi.Text = a.diachi;
                            txtemail.Text = a.email;
                            txtsdt.Text = a.sdt;
                            

                            if (a.gioitinh == true) rdbNam.Checked = true;
                            else rdbNu.Checked = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("hhhh");
                        }
                    }
                }

            }
        }



        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                foreach (DataGridViewRow r in dgvgv.SelectedRows)
                {
                    string maGiaoVien = r.Cells[0].Value.ToString();

                    if (xlgv.KiemTraGiaoVienTrongLopHoc(maGiaoVien, xllop.getdsLopHoc()))
                    {
                        MessageBox.Show($"Giáo viên có mã {maGiaoVien} hiện  có trong Lớp học");
                    }
                    else
                    {
                        xlgv.xoa(maGiaoVien);
                    }
                }
                hienthi(xlgv.getdsgiaovien());
                //xoa du lieu textbox
                txtmagv.Text = string.Empty;
                txttengv.Text = string.Empty;
                dtpngaysinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtdiachi.Text = string.Empty;
                txtemail.Text = string.Empty;
                txtsdt.Text = string.Empty;
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                giaoVien a = new giaoVien();
                a.maGiaoVien = txtmagv.Text;
                a.tenGiaoVien = txttengv.Text;
                a.ngaysinh = dtpngaysinh.Value;
                a.gioitinh = rdbNam.Checked;
                a.email = txtemail.Text;
                a.diachi = txtdiachi.Text;
                

                a.sdt = txtsdt.Text;


                if (xlgv.sua(a) == false)
                {
                    MessageBox.Show("Thong tin khong duoc luu");
                }
                else
                {
                    hienthi(xlgv.getdsgiaovien());
                }
                //xoa du lieu textbox
                txtmagv.Text = string.Empty;
                txttengv.Text = string.Empty;
                dtpngaysinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtdiachi.Text = string.Empty;
                txtemail.Text = string.Empty;
                txtsdt.Text = string.Empty;
               
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {


            //for (int i = 0; i < xllop.getdsLopHoc().Count; i++)
            //{
            //    if (!xlgv.kiemtra(xllop.getdsLopHoc()[i].maGiaoVien))
            //    {
            //        xllop.getdsLopHoc()[i].maGiaoVien = "";
            //        xllop.getdsLopHoc()[i].tenGiaoVien = "";
            //    }

            //}
            //string s1 = "Danhsachlop.txt";
            //xllop.Luufile(s1);
            string s = "Danhsachgiaovien.txt";
            xlgv.Luufile(s);
        }



        private void dgvgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ ô cụ thể trong dòng được chọn và đặt nó vào ô textbox
                DataGridViewRow selectedRow = dgvgv.Rows[e.RowIndex];
                string selectedValue = selectedRow.Cells["magv"].Value.ToString();
                string selectedValue1 = selectedRow.Cells["tengv"].Value.ToString();
                string selectedValue2 = selectedRow.Cells["ngaysinh"].Value.ToString();
                string selectedValue3 = selectedRow.Cells["gioitinh"].Value.ToString();
                if (selectedValue3 == "Nam")
                    rdbNam.Checked = true;
                else if (selectedValue3 == "Nữ")
                    rdbNu.Checked = true;
                string selectedValue4 = selectedRow.Cells["diachi"].Value.ToString();
                string selectedValue5 = selectedRow.Cells["email"].Value.ToString();
                string selectedValue7 = selectedRow.Cells["sdt"].Value.ToString();
               


                txtmagv.Text = selectedValue;
                txttengv.Text = selectedValue1;
                txtdiachi.Text = selectedValue4;
                txtemail.Text = selectedValue5;
                txtsdt.Text = selectedValue7;
                

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                if (txtmagv.Text == "")
                {
                    MessageBox.Show("Chua nhap ma hoc vien");
                    return;
                }
                giaoVien a = new giaoVien();
                a.maGiaoVien = txtmagv.Text;
                a.tenGiaoVien = txttengv.Text;
                a.ngaysinh = dtpngaysinh.Value;
                a.gioitinh = rdbNam.Checked;
                a.email = txtemail.Text;
                a.diachi = txtdiachi.Text;
               
                a.sdt = txtsdt.Text;


                if (xlgv.Them(a) == false)
                {
                    MessageBox.Show("thong tin giao vien da duoc them truoc do");
                }
                else
                {
                    hienthi(xlgv.getdsgiaovien());
                }
                //xóa dữ liệu trên textbox
                txtmagv.Text = string.Empty;
                txttengv.Text = string.Empty;
                dtpngaysinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtdiachi.Text = string.Empty;
                txtemail.Text = string.Empty;
                txtsdt.Text = string.Empty;
              
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string magv = txttim.Text;
            giaoVien a = xlgv.Tim(magv);
            if (a != null)
            {
                a.maGiaoVien = txtmagv.Text;
                a.tenGiaoVien = txttengv.Text;
                a.ngaysinh = dtpngaysinh.Value;
                a.gioitinh = rdbNam.Checked;
                a.email = txtemail.Text;
                a.diachi = txtdiachi.Text;
               
                a.sdt = txtsdt.Text;


                hienthi(xlgv.getdsgiaovien());

                if (txttim.Text != "")
                {
                    List<giaoVien> dsMoi = new List<giaoVien>();
                    foreach (giaoVien b in xlgv.getdsgiaovien())
                    {
                        if (b.maGiaoVien == txttim.Text)
                        {
                            dsMoi.Add(b);
                            hienthi(dsMoi);
                        }
                        else
                        {
                            hienthi(dsMoi);
                        }
                    }
                }
                else
                {
                    txtmagv.Text = "";
                    txttengv.Text = "";
                    dtpngaysinh.Value = DateTime.Now;
                    rdbNam.Checked = false;
                    rdbNu.Checked = false;
                    txtdiachi.Text = "";
                    txtemail.Text = "";
                    txtsdt.Text = "";
                    

                    hienthi(xlgv.getdsgiaovien());

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy giáo viên, Bạn hãy kiểm tra lại mã ");
            }
        }
    }
}



