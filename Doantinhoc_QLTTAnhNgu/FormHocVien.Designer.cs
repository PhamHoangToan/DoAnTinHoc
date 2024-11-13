namespace Doantinhoc_QLTTAnhNgu
{
    partial class FormHocVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocVien));
            groupBox1 = new GroupBox();
            cblophoc = new ComboBox();
            cbkhoahoc = new ComboBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            dtpngaysinh = new DateTimePicker();
            btntim = new Button();
            txttim = new TextBox();
            txtdiem = new TextBox();
            txtsdt = new TextBox();
            txtemail = new TextBox();
            txtdiachi = new TextBox();
            txttenhv = new TextBox();
            txtmahv = new TextBox();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            btnluu = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvhv = new DataGridView();
            mahv = new DataGridViewTextBoxColumn();
            tenhv = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            lophoc = new DataGridViewTextBoxColumn();
            khoahoc = new DataGridViewTextBoxColumn();
            diem = new DataGridViewTextBoxColumn();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cblophoc);
            groupBox1.Controls.Add(cbkhoahoc);
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(btntim);
            groupBox1.Controls.Add(txttim);
            groupBox1.Controls.Add(txtdiem);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txttenhv);
            groupBox1.Controls.Add(txtmahv);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 745);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học viên ";
            // 
            // cblophoc
            // 
            cblophoc.FormattingEnabled = true;
            cblophoc.Items.AddRange(new object[] { "TA01", "TA02", "TA03", "TA04", "TA05" });
            cblophoc.Location = new Point(192, 391);
            cblophoc.Name = "cblophoc";
            cblophoc.Size = new Size(165, 33);
            cblophoc.TabIndex = 28;
            // 
            // cbkhoahoc
            // 
            cbkhoahoc.FormattingEnabled = true;
            cbkhoahoc.Items.AddRange(new object[] { "TACB", "TANC", "TAGT" });
            cbkhoahoc.Location = new Point(188, 452);
            cbkhoahoc.Name = "cbkhoahoc";
            cbkhoahoc.Size = new Size(169, 33);
            cbkhoahoc.TabIndex = 27;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(282, 178);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(61, 29);
            rdbNu.TabIndex = 26;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(188, 178);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 29);
            rdbNam.TabIndex = 25;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(196, 133);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(161, 31);
            dtpngaysinh.TabIndex = 24;
            // 
            // btntim
            // 
            btntim.BackgroundImage = Properties.Resources.search1;
            btntim.BackgroundImageLayout = ImageLayout.Center;
            btntim.FlatStyle = FlatStyle.Flat;
            btntim.Location = new Point(250, 679);
            btntim.Name = "btntim";
            btntim.Size = new Size(77, 54);
            btntim.TabIndex = 23;
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // txttim
            // 
            txttim.Location = new Point(139, 629);
            txttim.Name = "txttim";
            txttim.Size = new Size(188, 31);
            txttim.TabIndex = 22;
            // 
            // txtdiem
            // 
            txtdiem.Location = new Point(192, 511);
            txtdiem.Name = "txtdiem";
            txtdiem.Size = new Size(165, 31);
            txtdiem.TabIndex = 21;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(192, 344);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(165, 31);
            txtsdt.TabIndex = 19;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(192, 293);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(165, 31);
            txtemail.TabIndex = 18;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(192, 243);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(165, 31);
            txtdiachi.TabIndex = 17;
            // 
            // txttenhv
            // 
            txttenhv.Location = new Point(192, 86);
            txttenhv.Name = "txttenhv";
            txttenhv.Size = new Size(165, 31);
            txttenhv.TabIndex = 16;
            // 
            // txtmahv
            // 
            txtmahv.Location = new Point(192, 38);
            txtmahv.Name = "txtmahv";
            txtmahv.Size = new Size(165, 31);
            txtmahv.TabIndex = 15;
            // 
            // btnsua
            // 
            btnsua.BackgroundImage = Properties.Resources.fix1;
            btnsua.BackgroundImageLayout = ImageLayout.Center;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.Location = new Point(282, 559);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(77, 64);
            btnsua.TabIndex = 14;
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackgroundImage = Properties.Resources.delete1;
            btnxoa.BackgroundImageLayout = ImageLayout.Center;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Location = new Point(192, 559);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(77, 64);
            btnxoa.TabIndex = 13;
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.BackgroundImage = Properties.Resources.insert1;
            btnthem.BackgroundImageLayout = ImageLayout.Center;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.Location = new Point(98, 559);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(77, 64);
            btnthem.TabIndex = 12;
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnluu
            // 
            btnluu.BackgroundImage = Properties.Resources.save1;
            btnluu.BackgroundImageLayout = ImageLayout.Center;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Location = new Point(6, 559);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(77, 64);
            btnluu.TabIndex = 11;
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 626);
            label11.Name = "label11";
            label11.Size = new Size(119, 75);
            label11.TabIndex = 10;
            label11.Text = "Tìm thông tin\r\n   học viên\r\n(nhập mã)\r\n";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 517);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 9;
            label10.Text = "Điểm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 455);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 8;
            label9.Text = "Khóa học ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 399);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 7;
            label8.Text = "Lớp học";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 344);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 6;
            label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 296);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 246);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 190);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 136);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 86);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên học viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 38);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã học viên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgvhv);
            groupBox2.Location = new Point(413, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1499, 697);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách học viên";
            // 
            // dgvhv
            // 
            dgvhv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhv.Columns.AddRange(new DataGridViewColumn[] { mahv, tenhv, ngaysinh, gioitinh, diachi, email, sdt, lophoc, khoahoc, diem });
            dgvhv.Location = new Point(16, 36);
            dgvhv.Name = "dgvhv";
            dgvhv.RowHeadersWidth = 62;
            dgvhv.RowTemplate.Height = 33;
            dgvhv.Size = new Size(1483, 411);
            dgvhv.TabIndex = 0;
            dgvhv.CellClick += dgv_CellClick;
            dgvhv.RowEnter += dataGridView1_RowEnter;
            // 
            // mahv
            // 
            mahv.DataPropertyName = "mahv";
            mahv.HeaderText = "Mã hv";
            mahv.MinimumWidth = 8;
            mahv.Name = "mahv";
            mahv.Width = 150;
            // 
            // tenhv
            // 
            tenhv.DataPropertyName = "tenhv";
            tenhv.HeaderText = "Tên hv";
            tenhv.MinimumWidth = 8;
            tenhv.Name = "tenhv";
            tenhv.Width = 150;
            // 
            // ngaysinh
            // 
            ngaysinh.DataPropertyName = "ngaysinh";
            ngaysinh.HeaderText = "Ngày sinh";
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
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa chỉ ";
            diachi.MinimumWidth = 8;
            diachi.Name = "diachi";
            diachi.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.Width = 150;
            // 
            // sdt
            // 
            sdt.DataPropertyName = "sdt";
            sdt.HeaderText = "Số điện thoại";
            sdt.MinimumWidth = 8;
            sdt.Name = "sdt";
            sdt.Width = 150;
            // 
            // lophoc
            // 
            lophoc.DataPropertyName = "lophoc";
            lophoc.HeaderText = "Lớp học ";
            lophoc.MinimumWidth = 8;
            lophoc.Name = "lophoc";
            lophoc.Width = 150;
            // 
            // khoahoc
            // 
            khoahoc.DataPropertyName = "khoahoc";
            khoahoc.HeaderText = "Khóa học";
            khoahoc.MinimumWidth = 8;
            khoahoc.Name = "khoahoc";
            khoahoc.Width = 150;
            // 
            // diem
            // 
            diem.DataPropertyName = "diem";
            diem.HeaderText = "Điểm";
            diem.MinimumWidth = 8;
            diem.Name = "diem";
            diem.Width = 150;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 0, 64);
            label12.Location = new Point(663, 30);
            label12.Name = "label12";
            label12.Size = new Size(325, 54);
            label12.TabIndex = 27;
            label12.Text = "Quản Lý học viên";
            // 
            // FormHocVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 914);
            Controls.Add(label12);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormHocVien";
            Text = "FormHocVien";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnthem;
        private Button btnluu;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnsua;
        private Button btnxoa;
        private GroupBox groupBox2;
        private DataGridView dgvhv;
        private DataGridViewTextBoxColumn mahv;
        private DataGridViewTextBoxColumn tenhv;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn lophoc;
        private DataGridViewTextBoxColumn khoahoc;
        private DataGridViewTextBoxColumn diem;
        private TextBox txtemail;
        private TextBox txtdiachi;
        private TextBox txttenhv;
        private TextBox txtmahv;
        private TextBox txtsdt;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private DateTimePicker dtpngaysinh;
        private Button btntim;
        private TextBox txttim;
        private TextBox txtdiem;
        private Label label12;
        private ComboBox cbkhoahoc;
        private ComboBox cblophoc;
    }
}