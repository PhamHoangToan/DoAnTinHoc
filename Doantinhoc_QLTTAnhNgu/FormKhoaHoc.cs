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
    public partial class FormKhoaHoc : Form
    {
        private CxuLyKhoaHoc xulykhoahoc;
        private Cxulylophoc xllop;
        private int m_status;

        public FormKhoaHoc(int status)
        {
            InitializeComponent();
            this.m_status = status;
        }

        private void hienthi(List<khoaHoc> dskh)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = khoaHocView.chuyendoi(dskh);
            dgv.DataSource = bs;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < xllop.getdsLopHoc().Count; i++)
            //{
            //    if (!xulykhoahoc.kiemtra(xllop.getdsLopHoc()[i].maKhoahoc))
            //    {
            //        xllop.getdsLopHoc()[i].maKhoahoc = "";
            //        xllop.getdsLopHoc()[i].tenKhoahoc = "";
            //    }

            //}
            //string s1 = "Danhsachlop.txt";
            //xllop.Luufile(s1);
            string s = "Danhsachkhoa.txt";
            xulykhoahoc.Luufile(s);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                khoaHoc a = new khoaHoc();
                a.makhoahoc = cbmakhoa.Text;
                a.tenKhoahoc = txttenkhoa.Text;
                a.ngaybatdau = dtpngaybatdau.Value;
                a.ngayketthuc = dtpngayketthuc.Value;
                if (cbmakhoa.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã khóa học!");
                    return;
                }

                if (xulykhoahoc.them(a) == false)
                {
                    MessageBox.Show("Thông tin khóa học này đã được lưu trước đó !");
                }
                else
                {
                    hienthi(xulykhoahoc.getdsKhoaHoc());
                }
                //xóa dữ liệu trên textbox
                cbmakhoa.Text = string.Empty;
                txttenkhoa.Text = string.Empty;
                dtpngaybatdau.Value = DateTimePicker.MinimumDateTime;
                dtpngayketthuc.Value = DateTimePicker.MinimumDateTime;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    string maKhoahoc = r.Cells[0].Value.ToString();

                    if (xulykhoahoc.KiemTraKhoaHocTrongLopHoc(maKhoahoc, xllop.getdsLopHoc()))
                    {
                        MessageBox.Show($"Khóa học có mã {maKhoahoc} hiện không có trong lớp học");
                    }
                    else
                    {
                        xulykhoahoc.xoa(maKhoahoc);
                    }
                }
                hienthi(xulykhoahoc.getdsKhoaHoc());
                //xóa dữ liệu trên textbox
                cbmakhoa.Text = string.Empty;
                txttenkhoa.Text = string.Empty;
                dtpngaybatdau.Value = DateTimePicker.MinimumDateTime;
                dtpngayketthuc.Value = DateTimePicker.MinimumDateTime;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                khoaHoc a = new khoaHoc();
                a.makhoahoc = cbmakhoa.Text;
                a.tenKhoahoc = txttenkhoa.Text;
                a.ngaybatdau = dtpngaybatdau.Value;
                a.ngayketthuc = dtpngayketthuc.Value;
                if (xulykhoahoc.sua(a) == false)
                {
                    MessageBox.Show("Thông tin khóa học này đã được thay đổi !");
                }
                else
                {
                    hienthi(xulykhoahoc.getdsKhoaHoc());
                }
                //xóa dữ liệu trên textbox
                cbmakhoa.Text = string.Empty;
                txttenkhoa.Text = string.Empty;
                dtpngaybatdau.Value = DateTimePicker.MinimumDateTime;
                dtpngayketthuc.Value = DateTimePicker.MinimumDateTime;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string makh = txttimkhoa.Text;
            khoaHoc a = xulykhoahoc.tim(makh);
            if (a != null)
            {
                cbmakhoa.Text = a.makhoahoc;
                txttenkhoa.Text = a.tenKhoahoc;
                dtpngaybatdau.Value = a.ngaybatdau;
                dtpngayketthuc.Value = a.ngayketthuc;

                hienthi(xulykhoahoc.getdsKhoaHoc());
                if (cbmakhoa.Text != "")
                {
                    List<khoaHoc> dsmoi = new List<khoaHoc>();
                    foreach (khoaHoc b in xulykhoahoc.getdsKhoaHoc())
                    {
                        if (b.makhoahoc == txttimkhoa.Text)
                        {
                            dsmoi.Add(b);
                            hienthi(dsmoi);
                        }
                        else
                        {
                            hienthi(dsmoi);
                        }
                    }
                }
                else
                {
                    cbmakhoa.Text = "";
                    txttenkhoa.Text = "";
                    dtpngaybatdau.Value = DateTime.Now;
                    dtpngayketthuc.Value = DateTime.Now;
                    hienthi(xulykhoahoc.getdsKhoaHoc());

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy khóa học, Bạn hãy kiểm tra lại mã ");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            xulykhoahoc = new CxuLyKhoaHoc();
            xllop = new Cxulylophoc();
            string s = "Danhsachkhoa.txt";
            xulykhoahoc.docFile(s);
            string s1 = "Danhsachlop.txt";
            xllop.docFile(s1);
            hienthi(xulykhoahoc.getdsKhoaHoc());
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mamh = r.Cells[0].Value.ToString();
                khoaHoc a = xulykhoahoc.tim(mamh);
                if (a != null)
                {
                    cbmakhoa.Text = a.makhoahoc;
                    txttenkhoa.Text = a.tenKhoahoc;
                    dtpngaybatdau.Value = a.ngaybatdau;
                    dtpngayketthuc.Value = a.ngayketthuc;

                    break;

                }
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ ô cụ thể trong dòng được chọn và đặt nó vào ô textbox
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                string selectedValue = selectedRow.Cells["makhoahoc"].Value.ToString();
                string selectedValue1 = selectedRow.Cells["tenkhoahoc"].Value.ToString();


                cbmakhoa.Text = selectedValue;
                txttenkhoa.Text = selectedValue1;

            }
        }

        private void FormKhoaHoc_Shown(object sender, EventArgs e)
        {

        }
    }
}
