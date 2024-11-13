using Microsoft.VisualBasic.Devices;
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
    public partial class FormPhieuDangKi : Form
    {

        private Cxulyphieudangki xlPhieuDangKi;
        private CxuLyHocVien xlHocVien;
        private CxuLyKhoaHoc xlkhoahoc;
        private Cxulylophoc xlLopHoc;
        private int m_status;
        private phieudangki phieudangki;
        public FormPhieuDangKi(int status)
        {
            InitializeComponent();
            this.m_status = status;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            xlPhieuDangKi = new Cxulyphieudangki();
            xlHocVien = new CxuLyHocVien();
            xlLopHoc = new Cxulylophoc();
            phieudangki = new phieudangki();
            xlkhoahoc=new CxuLyKhoaHoc();
            string s = "Danhsachhocvien.txt";
            xlHocVien.docFile(s);
            string s1 = "Danhsachlop.txt";
            xlLopHoc.docFile(s1);
            string s2 = "Danhsachphieu.txt";

            xlPhieuDangKi.docFile(s2);
            string s3 = "Danhsachkhoa.txt";

            xlkhoahoc.docFile(s3);
            hienthiComboBoxmahocvien(xlHocVien.getdsHocVien());
            hienthiComboBoxmalophoc(xlLopHoc.getdsLopHoc());
            hienthiDSPhieuDangKi(xlPhieuDangKi.getdsphieudangki());
            //HienThiThongTinKhoaHoc();



        }

        private void hienthiComboBoxmahocvien(List<hocVien> ds)
        {
            cbmahv.DisplayMember = "mahv";
            cbmahv.ValueMember = "mahv";
            cbmahv.DataSource = ds;
        }



        private void hienthiComboBoxmalophoc(List<lopHoc> ds)
        {
            cbmalop.DisplayMember = "Malop";
            cbmalop.ValueMember = "Malop";
            cbmalop.DataSource = ds;
        }

        void hienthiPhieuDangKi(phieudangki x)
        {

        }

        void hienthiDSPhieuDangKi(List<phieudangki> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = PhieuDangKiView.chuyendoi(ds);
            dgvdanhsach.DataSource = bs;

        }
        void hienthiDSlop(List<phieudangki> ds)
        {

        }

        private void cbmahv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahocvien = cbmahv.SelectedValue.ToString();
            hocVien a = xlHocVien.Tim(mahocvien);

            txttenhv.Text = a.tenhv;
            dtpngaysinhhv.Value = a.ngaysinh;
            txtdiachihv.Text = a.diachi;
            txtsdt.Text = a.sdt;
            if (a.gioitinh == true) rdbNam.Checked = true;
            else rdbNu.Checked = true;

        }

        private void btnlapphieu_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {

                if (txtmaphieu.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã phiếu");
                    return;
                }
                phieudangki a = new phieudangki();
                a.maphieu = txtmaphieu.Text;
                a.ngaydangki = dtpngaydangki.Value;
                a.diachilap = txtdiachilap.Text;
                a.nguoixacnhan = txtnguoixacnhan.Text;
                a.uudai = double.Parse(txtuudai.Text);
                a.Malop = cbmalop.Text;
                a.Tenlop = txttenlop.Text;
                a.hocphi = double.Parse(txthocphi.Text);
                a.mahv = cbmahv.Text;
                a.tenhv = txttenhv.Text;
                a.ngaysinh = dtpngaysinhhv.Value;
                a.gioitinh = rdbNam.Checked;
                a.sdt = txtsdt.Text;
                a.diachi = txtdiachihv.Text;
                a.ngaycapnhat = DateTime.Now;


                if (xlPhieuDangKi.them(a) == false)
                {
                    MessageBox.Show("mã đã tồn tại ");

                }

                else
                {
                    txttong.Text = xlPhieuDangKi.thanhtienTong().ToString();
                    hienthiDSPhieuDangKi(xlPhieuDangKi.getdsphieudangki());
                    phieudangki = new phieudangki();

                }
                //xóa dữ liệu trên textbox
                txtmaphieu.Text = string.Empty;
                dtpngaydangki.Value = DateTimePicker.MinimumDateTime;
                txtdiachilap.Text = string.Empty;
                txtnguoixacnhan.Text = string.Empty;
                txtuudai.Text = string.Empty;
                cbmahv.Text = string.Empty;
                txttenhv.Text = string.Empty;
                dtpngaysinhhv.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtdiachihv.Text = string.Empty;
                txtsdt.Text = string.Empty;
                cbmalop.Text = string.Empty;
                txttenlop.Text = string.Empty;
                txthocphi.Text = string.Empty;
            }
        }

        private void dgvdanhsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvdanhsach.SelectedRows)
            {
                string mapt = r.Cells[0].Value.ToString();
                phieudangki ph = xlPhieuDangKi.tim(mapt);
                if (ph != null)
                {
                    txtmaphieu.Text = ph.maphieu;
                    dtpngaydangki.Value = ph.ngaydangki;
                    txtdiachilap.Text = ph.diachilap;
                    txtnguoixacnhan.Text = ph.nguoixacnhan;
                    txtuudai.Text = ph.uudai.ToString();
                    cbmahv.Text = ph.mahv;
                    txttenhv.Text = ph.tenhv;
                    dtpngaysinhhv.Value = ph.ngaysinh;
                    if (ph.gioitinh == true) rdbNam.Checked = true;
                    else rdbNu.Checked = true;
                    txtdiachihv.Text = ph.diachi;
                    txtsdt.Text = ph.sdt;
                    cbmalop.Text = ph.Malop;
                    txttenlop.Text = ph.Tenlop;
                    txthocphi.Text = ph.hocphi.ToString();


                    break;
                }
            }
        }

        private void cbmalop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string malophoc = cbmalop.SelectedValue.ToString();
            lopHoc a = xlLopHoc.tim(malophoc);
            txttenlop.Text = a.Tenlop;
            txthocphi.Text = a.Hocphi.ToString();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {

                foreach (DataGridViewRow r in dgvdanhsach.SelectedRows)
                {
                    string maphieu = r.Cells[0].Value.ToString();
                    xlPhieuDangKi.xoa(maphieu);
                }

                hienthiDSPhieuDangKi(xlPhieuDangKi.getdsphieudangki());
                //xóa dữ liệu textbox
                txtmaphieu.Text = string.Empty;
                dtpngaydangki.Value = DateTimePicker.MinimumDateTime;
                txtdiachilap.Text = string.Empty;
                txtnguoixacnhan.Text = string.Empty;
                txtuudai.Text = string.Empty;
                cbmahv.Text = string.Empty;
                txttenhv.Text = string.Empty;
                dtpngaysinhhv.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtdiachihv.Text = string.Empty;
                txtsdt.Text = string.Empty;
                cbmalop.Text = string.Empty;
                txttenlop.Text = string.Empty;
                txthocphi.Text = string.Empty;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                phieudangki a = new phieudangki();
                a.maphieu = txtmaphieu.Text;
                a.ngaydangki = dtpngaydangki.Value;
                a.diachilap = txtdiachilap.Text;
                a.nguoixacnhan = txtnguoixacnhan.Text;
                a.uudai = double.Parse(txtuudai.Text);
                a.Malop = cbmalop.Text;
                a.Tenlop = txttenlop.Text;
                a.hocphi = double.Parse(txthocphi.Text);
                a.mahv = cbmahv.Text;
                a.tenhv = txttenhv.Text;
                a.ngaysinh = dtpngaysinhhv.Value;
                a.gioitinh = rdbNam.Checked;
                a.sdt = txtsdt.Text;
                a.diachi = txtdiachihv.Text;
                a.ngaycapnhat = DateTime.Now;

                if (xlPhieuDangKi.sua(a) == false)
                {
                    MessageBox.Show("Thông tin lớp học này đã được lưu trước đó !");
                }
                else
                {
                    txttong.Text = xlPhieuDangKi.thanhtienTong().ToString();
                    hienthiDSPhieuDangKi(xlPhieuDangKi.getdsphieudangki());

                }
                //xóa dữ liệu textbox
                txtmaphieu.Text = string.Empty;
                dtpngaydangki.Value = DateTimePicker.MinimumDateTime;
                txtdiachilap.Text = string.Empty;
                txtnguoixacnhan.Text = string.Empty;
                txtuudai.Text = string.Empty;
                cbmahv.Text = string.Empty;
                txttenhv.Text = string.Empty;
                dtpngaysinhhv.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtdiachihv.Text = string.Empty;
                txtsdt.Text = string.Empty;
                cbmalop.Text = string.Empty;
                txttenlop.Text = string.Empty;
                txthocphi.Text = string.Empty;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string s2 = "Danhsachphieu.txt";
            xlPhieuDangKi.Luufile(s2);
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string maph = txttimma.Text;
            phieudangki ph = xlPhieuDangKi.tim(maph);

            if (ph != null)
            {
                txtmaphieu.Text = ph.maphieu;
                dtpngaydangki.Value = ph.ngaydangki;
                txtdiachilap.Text = ph.diachilap;
                txtnguoixacnhan.Text = ph.nguoixacnhan;
                txtuudai.Text = ph.uudai.ToString();
                cbmahv.Text = ph.mahv;
                txttenhv.Text = ph.tenhv;
                dtpngaysinhhv.Value = ph.ngaysinh;
                if (ph.gioitinh == true) rdbNam.Checked = true;
                else rdbNu.Checked = true;
                txtdiachihv.Text = ph.diachi;
                txtsdt.Text = ph.sdt;
                cbmalop.Text = ph.Malop;
                txttenlop.Text = ph.Tenlop;
                txthocphi.Text = ph.hocphi.ToString();

                hienthiDSPhieuDangKi(xlPhieuDangKi.getdsphieudangki());

                if (txttimma.Text != "")
                {
                    List<phieudangki> dsMoi = new List<phieudangki>();
                    foreach (phieudangki b in xlPhieuDangKi.getdsphieudangki())
                    {
                        if (b.maphieu == txttimma.Text)
                        {
                            dsMoi.Add(b);
                            hienthiDSPhieuDangKi(dsMoi);
                        }
                        else
                        {
                            hienthiDSPhieuDangKi(dsMoi);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã, Bạn hãy kiểm tra lại mã ");
            }
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                    string Malop = dgvdanhsach.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

                    // Sử dụng mã lớp để lấy giá trị từ cột "MaKhoaHoc" (giả sử)
                    string makhoahoc = xlLopHoc. GetMaKhoaHocFromMaLop(Malop);
                
                
              
               
                // Lấy giá trị từ ô cụ thể trong dòng được chọn và đặt nó vào ô textbox
                DataGridViewRow selectedRow = dgvdanhsach.Rows[e.RowIndex];
                string selectedValue = selectedRow.Cells["maphieu"].Value.ToString();
                string selectedValue1 = selectedRow.Cells["ngaydangki"].Value.ToString();
                string selectedValue2 = selectedRow.Cells["diachilap"].Value.ToString();
                string selectedValue3 = selectedRow.Cells["nguoixacnhan"].Value.ToString();
                string selectedValue4 = selectedRow.Cells["uudai"].Value.ToString();
                string selectedValue5 = selectedRow.Cells["malop"].Value.ToString();
                string selectedValue6 = selectedRow.Cells["tenlop"].Value.ToString();
                string selectedValue7 = selectedRow.Cells["hocphi"].Value.ToString();
                string selectedValue8 = selectedRow.Cells["mahv"].Value.ToString();
                string selectedValue9 = selectedRow.Cells["tenhv"].Value.ToString();
                string selectedValue10 = selectedRow.Cells["ngaysinh"].Value.ToString();
                string selectedValue11 = selectedRow.Cells["gioitinh"].Value.ToString();
                if (selectedValue11 == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                string selectedValue12 = selectedRow.Cells["sdt"].Value.ToString();
                string selectedValue13 = selectedRow.Cells["diachi"].Value.ToString();
               // makhoahoc=selectedValue
                txtmaphieu.Text = selectedValue;
                txtdiachilap.Text = selectedValue2;
                txtnguoixacnhan.Text = selectedValue3;
                txtuudai.Text = selectedValue4;
                cbmalop.Text = selectedValue5;
                txttenlop.Text = selectedValue6;
                txthocphi.Text = selectedValue7;
                cbmahv.Text = selectedValue8;
                txttenhv.Text = selectedValue9;
                //rdbNam.Text = selectedValue11;
                txtsdt.Text = selectedValue12;
                txtdiachihv.Text = selectedValue13;

                //
                List<khoaHoc> datadata = xlkhoahoc.getdsKhoaHoc();
                string valueMaKhoa = xlLopHoc.GetMaKhoaHocFromMaLop(selectedValue5);
               
                List<khoaHoc> data = xlLopHoc.timkhoahoc(valueMaKhoa, datadata);
               // dgvlichsu.Rows.Clear();
                HienThiThongTinKhoaHoc(data);
               
            }
        }

        private void txttong_TextChanged(object sender, EventArgs e)
        {


        }

        private void HienThiDuLieuDataGridView( List<khoaHoc> data)
        {
            // Thêm dữ liệu vào DataGridView
            var selectedColumns = data.Select(d => new { d.makhoahoc, d.ngaybatdau, d.ngayketthuc }).ToList();
            dgvlichsu.DataSource = selectedColumns;
            //Console.WriteLine(data);
            
        }

        private void HienThiThongTinKhoaHoc(List<khoaHoc> data)
        {

            if (data.Count > 0)
            {
                HienThiDuLieuDataGridView(data);
            }
        }



    }
}



