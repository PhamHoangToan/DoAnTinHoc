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


    public partial class FormLopHoc : Form
    {
        private Cxulylophoc xuLyLopHoc;
        private CxuLyKhoaHoc xlKhoaHoc;
        private CxuLyGiaoVien xlgiaovien;
        private Cxulyphieudangki xlphieu;
        private int m_status;
        private int courseId;
        public FormLopHoc(int status)
        {
            InitializeComponent();
            this.m_status = status;
            this.courseId = courseId;
        }

        private void hienThi(List<lopHoc> dsLop)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LophocView.chuyendoi(dsLop);
            dgv.DataSource = bs;


            //hienThi(xuLyLopHoc.getdsLopHoc());
            hienthiComboBoxmagiaovien(xlgiaovien.getdsgiaovien());
            hienthiComboBoxmakhoahoc(xlKhoaHoc.getdsKhoaHoc());
        }
        private void hienthiComboBoxmagiaovien(List<giaoVien> ds)
        {


            cbmagiaovien.DisplayMember = "maGiaoVien";
            cbmagiaovien.ValueMember = "maGiaoVien";
            cbmagiaovien.DataSource = ds;
        }

        private void hienthiComboBoxmakhoahoc(List<khoaHoc> ds)
        {
            cbmakhoa.DisplayMember = "makhoahoc";
            cbmakhoa.ValueMember = "makhoahoc";
            cbmakhoa.DataSource = ds;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < xlphieu.getdsphieudangki().Count; i++)
            //{
            //    if (!xuLyLopHoc.kiemtra(xlphieu.getdsphieudangki()[i].Malop))
            //    {
            //        xlphieu.getdsphieudangki()[i].Malop = "";
            //        xlphieu.getdsphieudangki()[i].Tenlop = "";
            //        xlphieu.getdsphieudangki()[i].hocphi = 0;
            //    }

            //}
            string s = "Danhsachlop.txt";
            xuLyLopHoc.Luufile(s);
            //string s1 = "Danhsachphieu.txt";
            //xlphieu.Luufile(s1);




        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {

                if (cbmalop.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã lớp học!");
                    return;
                }
                lopHoc a = new lopHoc();
                a.Malop = cbmalop.Text;
                a.Tenlop = txttenlop.Text;
                a.Hocphi = double.Parse(txthocphi.Text);
                a.Khu = txtkhu.Text;
                a.Tang = txttang.Text;
                a.maKhoahoc = cbmakhoa.Text;
                a.tenKhoahoc = txttenkhoa.Text;
                a.maGiaoVien = cbmagiaovien.Text;
                a.tenGiaoVien = txttengiaovien.Text;


                if (!xuLyLopHoc.them(a) )
                {
                    MessageBox.Show("Thông tin lớp học này đã được lưu trước đó!");
                }
                else
                {
                    hienThi(xuLyLopHoc.getdsLopHoc());
                }
                //xóa dữ liệu trên textbox
                cbmalop.Text = string.Empty;
                txttenlop.Text = string.Empty;
                txthocphi.Text = string.Empty;
                txtkhu.Text = string.Empty;
                txttang.Text = string.Empty;
                cbmakhoa.Text = string.Empty;
                txttenkhoa.Text = string.Empty;
                cbmagiaovien.Text = string.Empty;
                txttengiaovien.Text = string.Empty;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    string maLop = r.Cells[0].Value.ToString();

                    if (xuLyLopHoc.KiemTraLopHocTrongPhieuDangKy(maLop, xlphieu.getdsphieudangki()))
                    {
                        MessageBox.Show($"Lớp học có mã {maLop} hiện không có trong phiếu đăng ký");
                    }
                    else
                    {
                        xuLyLopHoc.xoa(maLop);
                    }
                }

                hienThi(xuLyLopHoc.getdsLopHoc());
                //xóa dữ liệu trên textbox
                cbmalop.Text = string.Empty;
                txttenlop.Text = string.Empty;
                txthocphi.Text = string.Empty;
                txtkhu.Text = string.Empty;
                txttang.Text = string.Empty;
                cbmakhoa.Text = string.Empty;
                txttenkhoa.Text = string.Empty;
                cbmagiaovien.Text = string.Empty;
                txttengiaovien.Text = string.Empty;
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                    
                    lopHoc a = new lopHoc();
                    a.Malop = cbmalop.Text;
                    a.Tenlop = txttenlop.Text;
                    a.Hocphi = double.Parse(txthocphi.Text);
                    a.Khu = txtkhu.Text;
                    a.Tang = txttang.Text;
                    a.maKhoahoc = cbmakhoa.Text;
                    a.tenKhoahoc = txttenkhoa.Text;
                    a.maGiaoVien = cbmagiaovien.Text;
                    a.tenGiaoVien = txttengiaovien.Text;
                    List<lopHoc> dsLopHoc = xuLyLopHoc.getdsLopHoc();
                    lopHoc classCapture = dsLopHoc.Find(value => value.Malop == a.Malop);
                    a.maKhoahoc = classCapture.maKhoahoc ?? a.maKhoahoc;
                    if (!xuLyLopHoc.sua(a))
                    {
                        MessageBox.Show("Thông tin lớp học này đã được lưu trước đó !");
                    }
                    else
                    {
                        hienThi(xuLyLopHoc.getdsLopHoc());
                    }
                   
                    }
                

            
                //xóa dữ liệu trên textbox
                cbmalop.Text = string.Empty;
                txttenlop.Text = string.Empty;
                txthocphi.Text = string.Empty;
                txtkhu.Text = string.Empty;
                txttang.Text = string.Empty;
                cbmakhoa.Text = string.Empty;
                txttenkhoa.Text = string.Empty;
                cbmagiaovien.Text = string.Empty;
                txttengiaovien.Text = string.Empty;
            
        }
       
        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mamh = r.Cells[0].Value.ToString();
                lopHoc a = xuLyLopHoc.tim(mamh);
                if (a != null)
                {
                    cbmalop.Text = a.Malop;
                    txttenlop.Text = a.Tenlop;
                    txthocphi.Text = a.Hocphi.ToString();
                    txtkhu.Text = a.Khu;
                    txttang.Text = a.Tang;
                    cbmakhoa.Text = a.maKhoahoc;
                    txttenkhoa.Text = a.tenKhoahoc;
                    cbmagiaovien.Text = a.maGiaoVien;
                    txttengiaovien.Text = a.tenGiaoVien;
                    break;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            xuLyLopHoc = new Cxulylophoc();
            xlKhoaHoc = new CxuLyKhoaHoc();
            xlgiaovien = new CxuLyGiaoVien();
            xlphieu = new Cxulyphieudangki();
            string s = "Danhsachlop.txt";
            xuLyLopHoc.docFile(s);
            string s1 = "Danhsachkhoa.txt";
            xlKhoaHoc.docFile(s1);
            string s2 = "Danhsachgiaovien.txt";
            xlgiaovien.docFile(s2);
            string s3 = "Danhsachphieu.txt";
            xlphieu.docFile(s3);
            hienThi(xuLyLopHoc.getdsLopHoc());

        }

        private void txttim_Click(object sender, EventArgs e)
        {
            string malop = txttimlop.Text;
            lopHoc a = xuLyLopHoc.tim(malop);
            if (a != null)
            {
                cbmalop.Text = a.Malop;
                txttenlop.Text = a.Tenlop;
                txthocphi.Text = a.Hocphi.ToString();
                txtkhu.Text = a.Khu;
                txttang.Text = a.Tang;

                hienThi(xuLyLopHoc.getdsLopHoc());

                if (txttimlop.Text != "")
                {
                    List<lopHoc> dsMoi = new List<lopHoc>();
                    foreach (lopHoc b in xuLyLopHoc.getdsLopHoc())
                    {
                        if (b.Malop == txttimlop.Text)
                        {
                            dsMoi.Add(b);
                            hienThi(dsMoi);
                        }
                        else
                        {
                            hienThi(dsMoi);
                        }
                    }
                }
                else
                {
                    cbmalop.Text = "";
                    txttenlop.Text = "";
                    txthocphi.Text = "";
                    txtkhu.Text = "";
                    txttang.Text = "";

                    hienThi(xuLyLopHoc.getdsLopHoc());

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học , Bạn hãy kiểm tra lại mã ");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ ô cụ thể trong dòng được chọn và đặt nó vào ô textbox
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                string selectedValue = selectedRow.Cells["malop"].Value.ToString();
                string selectedValue1 = selectedRow.Cells["tenlop"].Value.ToString();
                string selectedValue2 = selectedRow.Cells["hocphi"].Value.ToString();
                string selectedValue3 = selectedRow.Cells["khu"].Value.ToString();
                string selectedValue4 = selectedRow.Cells["tang"].Value.ToString();
                string selectedValue5 = selectedRow.Cells["makhoahoc"].Value.ToString();
                string selectedValue6 = selectedRow.Cells["tenKhoahoc"].Value.ToString();
                string selectedValue7 = selectedRow.Cells["magiaovien"].Value.ToString();
                string selectedValue8 = selectedRow.Cells["tenGiaoVien"].Value.ToString();


                cbmalop.Text = selectedValue;
               
                txttenlop.Text = selectedValue1;
                txthocphi.Text = selectedValue2;
                txtkhu.Text = selectedValue3;
                txttang.Text = selectedValue4;
                cbmakhoa.Text = selectedValue5;
                txttenkhoa.Text = selectedValue6;
                cbmagiaovien.Text = selectedValue7;
                txttengiaovien.Text = selectedValue8;
            }
        }

        private void cbmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhoahoc = cbmakhoa.SelectedValue.ToString();
            khoaHoc a = xlKhoaHoc.tim(makhoahoc);
            txttenkhoa.Text = a.tenKhoahoc;

        }

        private void cbmagiaovien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGiaoVien = cbmagiaovien.SelectedValue.ToString();
            giaoVien a = xlgiaovien.Tim(maGiaoVien);
            txttengiaovien.Text = a.tenGiaoVien;
        }

    }

}

