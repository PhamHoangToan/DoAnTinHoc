namespace Doantinhoc_QLTTAnhNgu
{
    partial class FormGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoVien));
            label7 = new Label();
            groupBox1 = new GroupBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            dtpngaysinh = new DateTimePicker();
            btntim = new Button();
            txttim = new TextBox();
            txtsdt = new TextBox();
            txtemail = new TextBox();
            txtdiachi = new TextBox();
            txttengv = new TextBox();
            txtmagv = new TextBox();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            btnluu = new Button();
            label11 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            dgvgv = new DataGridView();
            magv = new DataGridViewTextBoxColumn();
            tengv = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvgv).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 0, 64);
            label7.Location = new Point(885, 9);
            label7.Name = "label7";
            label7.Size = new Size(342, 54);
            label7.TabIndex = 2;
            label7.Text = "Quản lý giáo viên ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(btntim);
            groupBox1.Controls.Add(txttim);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txttengv);
            groupBox1.Controls.Add(txtmagv);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 745);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin giáo viên ";
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
            btntim.BackgroundImage = (Image)resources.GetObject("btntim.BackgroundImage");
            btntim.BackgroundImageLayout = ImageLayout.Center;
            btntim.FlatStyle = FlatStyle.Flat;
            btntim.Location = new Point(250, 680);
            btntim.Name = "btntim";
            btntim.Size = new Size(77, 53);
            btntim.TabIndex = 23;
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // txttim
            // 
            txttim.Location = new Point(178, 626);
            txttim.Name = "txttim";
            txttim.Size = new Size(165, 31);
            txttim.TabIndex = 22;
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
            // txttengv
            // 
            txttengv.Location = new Point(192, 86);
            txttengv.Name = "txttengv";
            txttengv.Size = new Size(165, 31);
            txttengv.TabIndex = 16;
            // 
            // txtmagv
            // 
            txtmagv.Location = new Point(192, 38);
            txtmagv.Name = "txtmagv";
            txtmagv.Size = new Size(165, 31);
            txtmagv.TabIndex = 15;
            // 
            // btnsua
            // 
            btnsua.BackgroundImage = (Image)resources.GetObject("btnsua.BackgroundImage");
            btnsua.BackgroundImageLayout = ImageLayout.Center;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.Location = new Point(307, 537);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(77, 63);
            btnsua.TabIndex = 14;
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackgroundImage = (Image)resources.GetObject("btnxoa.BackgroundImage");
            btnxoa.BackgroundImageLayout = ImageLayout.Center;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Location = new Point(204, 537);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(77, 63);
            btnxoa.TabIndex = 13;
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.BackgroundImage = (Image)resources.GetObject("btnthem.BackgroundImage");
            btnthem.BackgroundImageLayout = ImageLayout.Center;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.Location = new Point(115, 537);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(65, 63);
            btnthem.TabIndex = 12;
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnluu
            // 
            btnluu.BackgroundImage = (Image)resources.GetObject("btnluu.BackgroundImage");
            btnluu.BackgroundImageLayout = ImageLayout.Center;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Location = new Point(18, 537);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(74, 63);
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
            label11.Text = "Tìm thông tin\r\n   giáo viên\r\n(nhập mã)\r\n";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 344);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 6;
            label1.Text = "Số điện thoại";
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
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(14, 246);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(14, 190);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(14, 136);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(14, 86);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên giáo viên";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(14, 38);
            label12.Name = "label12";
            label12.Size = new Size(114, 25);
            label12.TabIndex = 0;
            label12.Text = "Mã giáo viên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgvgv);
            groupBox2.Location = new Point(475, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1235, 725);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách giáo viên";
            // 
            // dgvgv
            // 
            dgvgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvgv.Columns.AddRange(new DataGridViewColumn[] { magv, tengv, ngaysinh, gioitinh, diachi, email, sdt });
            dgvgv.GridColor = SystemColors.ControlDarkDark;
            dgvgv.Location = new Point(31, 65);
            dgvgv.Name = "dgvgv";
            dgvgv.RowHeadersWidth = 62;
            dgvgv.RowTemplate.Height = 33;
            dgvgv.Size = new Size(1147, 225);
            dgvgv.TabIndex = 0;
            dgvgv.CellClick += dgvgv_CellClick;
            dgvgv.CellContentClick += dgv_RowEnter;
            // 
            // magv
            // 
            magv.DataPropertyName = "magv";
            magv.HeaderText = "Mã gv";
            magv.MinimumWidth = 8;
            magv.Name = "magv";
            magv.Width = 150;
            // 
            // tengv
            // 
            tengv.DataPropertyName = "tengv";
            tengv.HeaderText = "Tên GV";
            tengv.MinimumWidth = 8;
            tengv.Name = "tengv";
            tengv.Width = 150;
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
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa chỉ";
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
            // FormGiaoVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.form;
            ClientSize = new Size(1924, 889);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Name = "FormGiaoVien";
            Text = "FormGiaoVien";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private GroupBox groupBox1;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private DateTimePicker dtpngaysinh;
        private Button btntim;
        private TextBox txttim;
        private TextBox txtsdt;
        private TextBox txtemail;
        private TextBox txtdiachi;
        private TextBox txttengv;
        private TextBox txtmagv;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private Button btnluu;
        private Label label11;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private GroupBox groupBox2;
        private DataGridView dgvgv;
        private DataGridViewTextBoxColumn magv;
        private DataGridViewTextBoxColumn tengv;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn sdt;
    }
}