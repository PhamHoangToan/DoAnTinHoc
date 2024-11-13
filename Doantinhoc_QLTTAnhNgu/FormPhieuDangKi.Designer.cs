namespace Doantinhoc_QLTTAnhNgu
{
    partial class FormPhieuDangKi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            cbmahv = new ComboBox();
            dtpngaysinhhv = new DateTimePicker();
            txtdiachihv = new TextBox();
            txttenhv = new TextBox();
            txtsdt = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dtpngaydangki = new DateTimePicker();
            txtuudai = new TextBox();
            txtdiachilap = new TextBox();
            txtnguoixacnhan = new TextBox();
            txtmaphieu = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txthocphi = new TextBox();
            label12 = new Label();
            btnxoa = new Button();
            btnlapphieu = new Button();
            groupBox6 = new GroupBox();
            dgvdanhsach = new DataGridView();
            btnsua = new Button();
            btnluu = new Button();
            tong = new Label();
            txttong = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label13 = new Label();
            cbmalop = new ComboBox();
            label14 = new Label();
            txttenlop = new TextBox();
            label15 = new Label();
            btntim = new Button();
            txttimma = new TextBox();
            label16 = new Label();
            dgvlichsu = new DataGridView();
            maphieu = new DataGridViewTextBoxColumn();
            ngaydangki = new DataGridViewTextBoxColumn();
            diachilap = new DataGridViewTextBoxColumn();
            nguoixacnhan = new DataGridViewTextBoxColumn();
            uudai = new DataGridViewTextBoxColumn();
            malop = new DataGridViewTextBoxColumn();
            tenlop = new DataGridViewTextBoxColumn();
            hocphi = new DataGridViewTextBoxColumn();
            mahv = new DataGridViewTextBoxColumn();
            tenhv = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            makhoahoc = new DataGridViewTextBoxColumn();
            ngaybatdau = new DataGridViewTextBoxColumn();
            ngayketthuc = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsach).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlichsu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã học viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên học viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 144);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Location = new Point(23, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(78, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(6, 80);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(61, 29);
            rdbNu.TabIndex = 1;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(3, 49);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 29);
            rdbNam.TabIndex = 0;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 201);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 265);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 5;
            label5.Text = "Số điện thoại";
            // 
            // cbmahv
            // 
            cbmahv.FormattingEnabled = true;
            cbmahv.Location = new Point(137, 39);
            cbmahv.Name = "cbmahv";
            cbmahv.Size = new Size(171, 33);
            cbmahv.TabIndex = 6;
            cbmahv.SelectedIndexChanged += cbmahv_SelectedIndexChanged;
            // 
            // dtpngaysinhhv
            // 
            dtpngaysinhhv.Location = new Point(129, 144);
            dtpngaysinhhv.Name = "dtpngaysinhhv";
            dtpngaysinhhv.Size = new Size(203, 31);
            dtpngaysinhhv.TabIndex = 7;
            // 
            // txtdiachihv
            // 
            txtdiachihv.Location = new Point(220, 198);
            txtdiachihv.Name = "txtdiachihv";
            txtdiachihv.Size = new Size(150, 31);
            txtdiachihv.TabIndex = 8;
            // 
            // txttenhv
            // 
            txttenhv.Location = new Point(129, 93);
            txttenhv.Name = "txttenhv";
            txttenhv.Size = new Size(203, 31);
            txttenhv.TabIndex = 9;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(277, 262);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(150, 31);
            txtsdt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(608, 9);
            label6.Name = "label6";
            label6.Size = new Size(0, 45);
            label6.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dtpngaydangki);
            groupBox2.Controls.Add(txtuudai);
            groupBox2.Controls.Add(txtdiachilap);
            groupBox2.Controls.Add(txtnguoixacnhan);
            groupBox2.Controls.Add(txtmaphieu);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(16, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 309);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phiếu";
            // 
            // dtpngaydangki
            // 
            dtpngaydangki.Location = new Point(162, 91);
            dtpngaydangki.Name = "dtpngaydangki";
            dtpngaydangki.Size = new Size(155, 31);
            dtpngaydangki.TabIndex = 11;
            // 
            // txtuudai
            // 
            txtuudai.Location = new Point(167, 242);
            txtuudai.Name = "txtuudai";
            txtuudai.Size = new Size(150, 31);
            txtuudai.TabIndex = 9;
            // 
            // txtdiachilap
            // 
            txtdiachilap.Location = new Point(167, 195);
            txtdiachilap.Name = "txtdiachilap";
            txtdiachilap.Size = new Size(150, 31);
            txtdiachilap.TabIndex = 8;
            // 
            // txtnguoixacnhan
            // 
            txtnguoixacnhan.Location = new Point(167, 141);
            txtnguoixacnhan.Name = "txtnguoixacnhan";
            txtnguoixacnhan.Size = new Size(150, 31);
            txtnguoixacnhan.TabIndex = 7;
            // 
            // txtmaphieu
            // 
            txtmaphieu.Location = new Point(167, 42);
            txtmaphieu.Name = "txtmaphieu";
            txtmaphieu.Size = new Size(150, 31);
            txtmaphieu.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 242);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 4;
            label11.Text = "Ưu đãi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 141);
            label10.Name = "label10";
            label10.Size = new Size(141, 25);
            label10.TabIndex = 3;
            label10.Text = "Người xác nhận ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 195);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 2;
            label9.Text = "Địa chỉ lập ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 88);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 1;
            label8.Text = "Ngày đăng kí";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 42);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 0;
            label7.Text = "Mã phiếu";
            // 
            // txthocphi
            // 
            txthocphi.Location = new Point(137, 139);
            txthocphi.Name = "txthocphi";
            txthocphi.Size = new Size(195, 31);
            txthocphi.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 139);
            label12.Name = "label12";
            label12.Size = new Size(74, 25);
            label12.TabIndex = 5;
            label12.Text = "Học phí";
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Transparent;
            btnxoa.BackgroundImage = Properties.Resources.delete1;
            btnxoa.BackgroundImageLayout = ImageLayout.Center;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Location = new Point(875, 380);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(90, 53);
            btnxoa.TabIndex = 16;
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnlapphieu
            // 
            btnlapphieu.BackColor = Color.Transparent;
            btnlapphieu.BackgroundImage = Properties.Resources.insert1;
            btnlapphieu.BackgroundImageLayout = ImageLayout.Center;
            btnlapphieu.FlatStyle = FlatStyle.Flat;
            btnlapphieu.Location = new Point(1009, 380);
            btnlapphieu.Name = "btnlapphieu";
            btnlapphieu.Size = new Size(108, 53);
            btnlapphieu.TabIndex = 17;
            btnlapphieu.UseVisualStyleBackColor = false;
            btnlapphieu.Click += btnlapphieu_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Transparent;
            groupBox6.Controls.Add(dgvdanhsach);
            groupBox6.Location = new Point(16, 571);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1878, 324);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách phiếu";
            // 
            // dgvdanhsach
            // 
            dgvdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsach.Columns.AddRange(new DataGridViewColumn[] { maphieu, ngaydangki, diachilap, nguoixacnhan, uudai, malop, tenlop, hocphi, mahv, tenhv, ngaysinh, gioitinh, sdt, diachi });
            dgvdanhsach.Location = new Point(6, 48);
            dgvdanhsach.Name = "dgvdanhsach";
            dgvdanhsach.RowHeadersWidth = 62;
            dgvdanhsach.RowTemplate.Height = 33;
            dgvdanhsach.Size = new Size(1860, 225);
            dgvdanhsach.TabIndex = 0;
            dgvdanhsach.CellClick += dgvdanhsach_CellClick;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.Transparent;
            btnsua.BackgroundImage = Properties.Resources.fix1;
            btnsua.BackgroundImageLayout = ImageLayout.Center;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.ForeColor = Color.Transparent;
            btnsua.Location = new Point(879, 441);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(86, 52);
            btnsua.TabIndex = 20;
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnluu
            // 
            btnluu.BackColor = Color.Transparent;
            btnluu.BackgroundImage = Properties.Resources.save1;
            btnluu.BackgroundImageLayout = ImageLayout.Center;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Location = new Point(1009, 444);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(108, 52);
            btnluu.TabIndex = 21;
            btnluu.UseVisualStyleBackColor = false;
            btnluu.Click += btnluu_Click;
            // 
            // tong
            // 
            tong.AutoSize = true;
            tong.BackColor = Color.Transparent;
            tong.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tong.Location = new Point(470, 942);
            tong.Name = "tong";
            tong.Size = new Size(182, 45);
            tong.TabIndex = 22;
            tong.Text = "TỔNG TIỀN";
            // 
            // txttong
            // 
            txttong.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txttong.Location = new Point(725, 942);
            txttong.Name = "txttong";
            txttong.Size = new Size(194, 50);
            txttong.TabIndex = 23;
            txttong.TextChanged += txttong_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cbmahv);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txttenhv);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dtpngaysinhhv);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtdiachihv);
            groupBox3.Controls.Add(txtsdt);
            groupBox3.Location = new Point(376, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(457, 355);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin học viên";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txthocphi);
            groupBox4.Controls.Add(cbmalop);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(txttenlop);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(853, 190);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(342, 184);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin lớp";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 37);
            label13.Name = "label13";
            label13.Size = new Size(102, 25);
            label13.TabIndex = 0;
            label13.Text = "Mã lớp học";
            // 
            // cbmalop
            // 
            cbmalop.FormattingEnabled = true;
            cbmalop.Location = new Point(137, 39);
            cbmalop.Name = "cbmalop";
            cbmalop.Size = new Size(195, 33);
            cbmalop.TabIndex = 6;
            cbmalop.SelectedIndexChanged += cbmalop_SelectedIndexChanged_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 97);
            label14.Name = "label14";
            label14.Size = new Size(69, 25);
            label14.TabIndex = 1;
            label14.Text = "Tên lớp";
            // 
            // txttenlop
            // 
            txttenlop.Location = new Point(129, 93);
            txttenlop.Name = "txttenlop";
            txttenlop.Size = new Size(203, 31);
            txttenlop.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(64, 0, 64);
            label15.Location = new Point(555, 27);
            label15.Name = "label15";
            label15.Size = new Size(373, 60);
            label15.TabIndex = 12;
            label15.Text = "Quản lý phiếu thu";
            // 
            // btntim
            // 
            btntim.BackColor = Color.Transparent;
            btntim.BackgroundImage = Properties.Resources.search1;
            btntim.BackgroundImageLayout = ImageLayout.Center;
            btntim.FlatStyle = FlatStyle.Flat;
            btntim.Location = new Point(860, 504);
            btntim.Name = "btntim";
            btntim.Size = new Size(89, 52);
            btntim.TabIndex = 24;
            btntim.UseVisualStyleBackColor = false;
            btntim.Click += btntim_Click;
            // 
            // txttimma
            // 
            txttimma.Location = new Point(970, 515);
            txttimma.Name = "txttimma";
            txttimma.Size = new Size(203, 31);
            txttimma.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(1009, 555);
            label16.Name = "label16";
            label16.Size = new Size(131, 25);
            label16.TabIndex = 12;
            label16.Text = "nhập mã phiếu";
            // 
            // dgvlichsu
            // 
            dgvlichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlichsu.Columns.AddRange(new DataGridViewColumn[] { makhoahoc, ngaybatdau, ngayketthuc });
            dgvlichsu.Location = new Point(1230, 244);
            dgvlichsu.Name = "dgvlichsu";
            dgvlichsu.RowHeadersWidth = 62;
            dgvlichsu.RowTemplate.Height = 33;
            dgvlichsu.Size = new Size(532, 225);
            dgvlichsu.TabIndex = 25;
            // 
            // maphieu
            // 
            maphieu.DataPropertyName = "maphieu";
            maphieu.HeaderText = "Mã Phiếu";
            maphieu.MinimumWidth = 8;
            maphieu.Name = "maphieu";
            maphieu.Width = 150;
            // 
            // ngaydangki
            // 
            ngaydangki.DataPropertyName = "ngaydangki";
            ngaydangki.HeaderText = "Ngày Đăng kí";
            ngaydangki.MinimumWidth = 8;
            ngaydangki.Name = "ngaydangki";
            ngaydangki.Width = 150;
            // 
            // diachilap
            // 
            diachilap.DataPropertyName = "diachilap";
            diachilap.HeaderText = "Địa chỉ Lập";
            diachilap.MinimumWidth = 8;
            diachilap.Name = "diachilap";
            diachilap.Width = 150;
            // 
            // nguoixacnhan
            // 
            nguoixacnhan.DataPropertyName = "nguoixacnhan";
            nguoixacnhan.HeaderText = "Người xác nhận";
            nguoixacnhan.MinimumWidth = 8;
            nguoixacnhan.Name = "nguoixacnhan";
            nguoixacnhan.Width = 150;
            // 
            // uudai
            // 
            uudai.DataPropertyName = "uudai";
            uudai.HeaderText = "Ưu Đãi";
            uudai.MinimumWidth = 8;
            uudai.Name = "uudai";
            uudai.Width = 150;
            // 
            // malop
            // 
            malop.DataPropertyName = "malop";
            malop.HeaderText = "Mã lớp";
            malop.MinimumWidth = 8;
            malop.Name = "malop";
            malop.Width = 150;
            // 
            // tenlop
            // 
            tenlop.DataPropertyName = "tenlop";
            tenlop.HeaderText = "Tên lớp";
            tenlop.MinimumWidth = 8;
            tenlop.Name = "tenlop";
            tenlop.Width = 150;
            // 
            // hocphi
            // 
            hocphi.DataPropertyName = "hocphi";
            hocphi.HeaderText = "Học Phí";
            hocphi.MinimumWidth = 8;
            hocphi.Name = "hocphi";
            hocphi.Width = 150;
            // 
            // mahv
            // 
            mahv.DataPropertyName = "mahv";
            mahv.HeaderText = "Mã học viên";
            mahv.MinimumWidth = 8;
            mahv.Name = "mahv";
            mahv.Width = 150;
            // 
            // tenhv
            // 
            tenhv.DataPropertyName = "tenhv";
            tenhv.HeaderText = "Tên học viên";
            tenhv.MinimumWidth = 8;
            tenhv.Name = "tenhv";
            tenhv.Width = 150;
            // 
            // ngaysinh
            // 
            ngaysinh.DataPropertyName = "ngaysinh";
            ngaysinh.HeaderText = "Ngày Sinh";
            ngaysinh.MinimumWidth = 8;
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Width = 150;
            // 
            // gioitinh
            // 
            gioitinh.DataPropertyName = "gioitinh";
            gioitinh.HeaderText = "Giới tính";
            gioitinh.MinimumWidth = 8;
            gioitinh.Name = "gioitinh";
            gioitinh.Width = 150;
            // 
            // sdt
            // 
            sdt.DataPropertyName = "sdt";
            sdt.HeaderText = "Số điện thoại";
            sdt.MinimumWidth = 8;
            sdt.Name = "sdt";
            sdt.Width = 150;
            // 
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa chỉ";
            diachi.MinimumWidth = 8;
            diachi.Name = "diachi";
            diachi.Width = 150;
            // 
            // makhoahoc
            // 
            makhoahoc.DataPropertyName = "makhoahoc";
            makhoahoc.HeaderText = "Mã khóa học";
            makhoahoc.MinimumWidth = 8;
            makhoahoc.Name = "makhoahoc";
            makhoahoc.Width = 150;
            // 
            // ngaybatdau
            // 
            ngaybatdau.DataPropertyName = "ngaybatdau";
            ngaybatdau.HeaderText = "Thời gian bắt đâu";
            ngaybatdau.MinimumWidth = 8;
            ngaybatdau.Name = "ngaybatdau";
            ngaybatdau.Width = 150;
            // 
            // ngayketthuc
            // 
            ngayketthuc.DataPropertyName = "ngayketthuc";
            ngayketthuc.HeaderText = "Thời gian kết thúc";
            ngayketthuc.MinimumWidth = 8;
            ngayketthuc.Name = "ngayketthuc";
            ngayketthuc.Width = 150;
            // 
            // FormPhieuDangKi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.form;
            ClientSize = new Size(1924, 1040);
            Controls.Add(dgvlichsu);
            Controls.Add(label16);
            Controls.Add(txttimma);
            Controls.Add(btntim);
            Controls.Add(label15);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(txttong);
            Controls.Add(tong);
            Controls.Add(btnluu);
            Controls.Add(btnsua);
            Controls.Add(groupBox6);
            Controls.Add(btnlapphieu);
            Controls.Add(btnxoa);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Name = "FormPhieuDangKi";
            Text = "FormPhieuDangKi";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdanhsach).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlichsu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private Label label4;
        private Label label5;
        private ComboBox cbmahv;
        private DateTimePicker dtpngaysinhhv;
        private TextBox txtdiachihv;
        private TextBox txttenhv;
        private TextBox txtsdt;
        private Label label6;
        private GroupBox groupBox2;
        private Label label9;
        private Label label7;
        private TextBox txthocphi;
        private TextBox txtuudai;
        private TextBox txtdiachilap;
        private TextBox txtnguoixacnhan;
        private TextBox txtmaphieu;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnxoa;
        private Button btnlapphieu;
        private GroupBox groupBox6;
        private Button btnsua;
        private Button btnluu;
        private Label tong;
        private TextBox txttong;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label13;
        private ComboBox cbmalop;
        private Label label14;
        private TextBox txttenlop;
        private Label label15;
        private Button btntim;
        private TextBox txttimma;
        private Label label16;
        private DateTimePicker dtpngaydangki;
        private Label label8;
        private DataGridViewTextBoxColumn makhoahoc;
        private DataGridViewTextBoxColumn tenkhoahoc;
        private DataGridView dgvdanhsach;
        private DataGridView dgvlichsu;
        private DataGridViewTextBoxColumn maphieu;
        private DataGridViewTextBoxColumn ngaydangki;
        private DataGridViewTextBoxColumn diachilap;
        private DataGridViewTextBoxColumn nguoixacnhan;
        private DataGridViewTextBoxColumn uudai;
        private DataGridViewTextBoxColumn malop;
        private DataGridViewTextBoxColumn tenlop;
        private DataGridViewTextBoxColumn hocphi;
        private DataGridViewTextBoxColumn mahv;
        private DataGridViewTextBoxColumn tenhv;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn ngaybatdau;
        private DataGridViewTextBoxColumn ngayketthuc;
    }
}