namespace Doantinhoc_QLTTAnhNgu
{
    public partial class FormHocVien : Form
    {
        private CxuLyHocVien xuly;
        private Cxulyphieudangki xulyphieu;
        private int m_status;

        public FormHocVien(int status)
        {
            InitializeComponent();
            this.m_status = status;
        }
        private void hienthi(List<hocVien> dsHV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = hocVienView.chuyendoi(dsHV);
            dgvhv.DataSource = bs;
        }



        private void btnthem_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                if (txtmahv.Text == "")
                {
                    MessageBox.Show("Chua nhap ma hoc vien");
                    return;
                }
                if (txtdiem.Text == "")
                {
                    MessageBox.Show("Chua nhap diem");
                    return;
                }
                hocVien a = new hocVien();
                a.mahv = txtmahv.Text;
                a.tenhv = txttenhv.Text;
                a.ngaysinh = dtpngaysinh.Value;
                a.gioitinh = rdbNam.Checked;
                a.email = txtemail.Text;
                a.diachi = txtdiachi.Text;
                a.lophoc = cblophoc.Text;
                a.khoahoc = cbkhoahoc.Text;
                a.sdt = txtsdt.Text;
                //a.diem = double.Parse(txtdiem.Text);
                if (double.TryParse(txtdiem.Text, out double diemValue))
                {
                    a.diem = diemValue;
                }
                else
                {
                    MessageBox.Show("Nhap diem khong hop le");
                    return;
                }
                if (xuly.Them(a) == false)
                {
                    MessageBox.Show("thong tin hoc vien da duoc them truoc do");
                }
                else
                {
                    hienthi(xuly.getdsHocVien());
                }
                //xóa dữ liệu trên textbox
                txtmahv.Text = string.Empty;
                txttenhv.Text = string.Empty;
                dtpngaysinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtemail.Text = string.Empty;
                txtdiachi.Text = string.Empty;
                cblophoc.Text = string.Empty;
                cbkhoahoc.Text = string.Empty;
                txtsdt.Text = string.Empty;
                txtdiem.Text = string.Empty;
            }

        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                foreach (DataGridViewRow r in dgvhv.SelectedRows)
                {
                    string maHocVien = r.Cells[0].Value.ToString();

                    if (xuly.KiemTraSinhVienTrongPhieuDangKy(maHocVien, xulyphieu.getdsphieudangki()))
                    {
                        MessageBox.Show($"Học sinh có mã {maHocVien} hiện  có trong phiếu đăng ký");
                    }
                    else
                    {
                        xuly.xoa(maHocVien);
                    }
                }

                // Gọi hienthi để cập nhật hiển thị sau khi xóa
                hienthi(xuly.getdsHocVien());


                //xóa dữ liệu textbox
                txtmahv.Text = string.Empty;
                txttenhv.Text = string.Empty;
                dtpngaysinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtemail.Text = string.Empty;
                txtdiachi.Text = string.Empty;
                cblophoc.Text = string.Empty;
                cbkhoahoc.Text = string.Empty;
                txtsdt.Text = string.Empty;
                txtdiem.Text = string.Empty;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {

                hocVien a = new hocVien();
                a.mahv = txtmahv.Text;
                a.tenhv = txttenhv.Text;
                a.ngaysinh = dtpngaysinh.Value;
                a.gioitinh = rdbNam.Checked;
                a.email = txtemail.Text;
                a.diachi = txtdiachi.Text;
                a.lophoc = cblophoc.Text;
                a.khoahoc = cbkhoahoc.Text;
                a.sdt = txtsdt.Text;
                a.diem = double.Parse(txtdiem.Text);

                if (xuly.sua(a) == false)
                {
                    MessageBox.Show("Thong tin khong duoc luu");
                }
                else
                {
                    hienthi(xuly.getdsHocVien());
                }
                //xóa dữ liệu trên textbox
                txtmahv.Text = string.Empty;
                txttenhv.Text = string.Empty;
                dtpngaysinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtemail.Text = string.Empty;
                txtdiachi.Text = string.Empty;
                cblophoc.Text = string.Empty;
                cbkhoahoc.Text = string.Empty;
                txtsdt.Text = string.Empty;
                txtdiem.Text = string.Empty;
            }

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string mahv = txttim.Text;
            hocVien a = xuly.Tim(mahv);
            if (a != null)
            {
                txtmahv.Text = a.mahv;
                txttenhv.Text = a.tenhv;
                dtpngaysinh.Value = a.ngaysinh;
                txtdiachi.Text = a.diachi;
                txtemail.Text = a.email;
                txtsdt.Text = a.sdt;
                cblophoc.Text = a.lophoc;
                cbkhoahoc.Text = a.khoahoc;
                txtdiem.Text = a.diem.ToString();
                if (a.gioitinh == true)
                    rdbNam.Checked = true;
                else rdbNu.Checked = true;

                hienthi(xuly.getdsHocVien());

                if (txttim.Text != "")
                {
                    List<hocVien> dsMoi = new List<hocVien>();
                    foreach (hocVien b in xuly.getdsHocVien())
                    {
                        if (b.mahv == txttim.Text)
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
                    txtmahv.Text = "";
                    txttenhv.Text = "";
                    dtpngaysinh.Value = DateTime.Now;
                    rdbNam.Checked = true;
                    txtdiachi.Text = "";
                    txtemail.Text = "";
                    txtsdt.Text = "";
                    cblophoc.Text = "";
                    cbkhoahoc.Text = "";
                    txtdiem.Text = "";

                    hienthi(xuly.getdsHocVien());

                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy học viên, Bạn hãy kiểm tra lại mã ");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvhv.SelectedRows)
            {
                string mamh = r.Cells[0].Value.ToString();
                hocVien a = xuly.Tim(mamh);
                if (a != null)
                {
                    txtmahv.Text = a.mahv;
                    txttenhv.Text = a.tenhv;
                    dtpngaysinh.Value = a.ngaysinh;
                    txtdiachi.Text = a.diachi;
                    txtemail.Text = a.email;
                    txtsdt.Text = a.sdt;
                    cblophoc.Text = a.lophoc;
                    cbkhoahoc.Text = a.khoahoc;
                    txtdiem.Text = a.diem.ToString();
                    if (a.gioitinh == true) rdbNam.Checked = true;
                    else rdbNu.Checked = true;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xuly = new CxuLyHocVien();
            xulyphieu = new Cxulyphieudangki();
            string s = "Danhsachhocvien.txt";
            xuly.docFile(s);
            string s1 = "Danhsachphieu.txt";
            xulyphieu.docFile(s1);
            hienthi(xuly.getdsHocVien());

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (m_status == 1)
            {
                //for (int i = 0; i < xulyphieu.getdsphieudangki().Count; i++)
                //{
                //    if (!xuly.kiemtra(xulyphieu.getdsphieudangki()[i].mahv))
                //    {
                //        xulyphieu.getdsphieudangki()[i].mahv = "";
                //        xulyphieu.getdsphieudangki()[i].tenhv = "";
                //        xulyphieu.getdsphieudangki()[i].ngaysinh = DateTime.MinValue; // Sử dụng DateTime.MinValue làm giá trị mặc định
                //        xulyphieu.getdsphieudangki()[i].gioitinh = false; /// Gán giá trị null cho gioitinh
                //        xulyphieu.getdsphieudangki()[i].diachi = "";
                //        xulyphieu.getdsphieudangki()[i].sdt = "";
                //    }

                //}

                //string s1 = "Danhsachphieu.txt";
                //xulyphieu.Luufile(s1);
                string s = "Danhsachhocvien.txt";
                xuly.Luufile(s);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ ô cụ thể trong dòng được chọn và đặt nó vào ô textbox
                DataGridViewRow selectedRow = dgvhv.Rows[e.RowIndex];
                string selectedValue = selectedRow.Cells["mahv"].Value.ToString();
                string selectedValue1 = selectedRow.Cells["tenhv"].Value.ToString();

                //DateTime selectedValue2 =(DateTime) selectedRow.Cells["ngaysinh"].Value;
                string selectedValue3 = selectedRow.Cells["gioitinh"].Value.ToString();
                if (selectedValue3 == "Nam")
                    rdbNam.Checked = true;
                else if(selectedValue3 == "Nữ")
                    rdbNu.Checked = true;
                string selectedValue4 = selectedRow.Cells["diachi"].Value.ToString();
                string selectedValue5 = selectedRow.Cells["email"].Value.ToString();
                string selectedValue6 = selectedRow.Cells["sdt"].Value.ToString();
                string selectedValue7 = selectedRow.Cells["lophoc"].Value.ToString();
                string selectedValue8 = selectedRow.Cells["khoahoc"].Value.ToString();
                string selectedValue9 = selectedRow.Cells["diem"].Value.ToString();

                txtmahv.Text = selectedValue;
                txttenhv.Text = selectedValue1;
                //dtpngaysinh.Value =selectedValue2;
                //rdbNam.Text = selectedValue3;
                //rdbNu.Checked = bool.Parse(selectedValue3);
                txtdiachi.Text = selectedValue4;
                txtemail.Text = selectedValue5;
                txtsdt.Text = selectedValue6;
                cblophoc.Text = selectedValue7;
                cbkhoahoc.Text = selectedValue8;
                txtdiem.Text = selectedValue9;
            }
        }


    }

}