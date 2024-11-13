namespace Doantinhoc_QLTTAnhNgu
{
    partial class FormLopHoc
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
            groupBox1 = new GroupBox();
            cbmalop = new ComboBox();
            txttimlop = new TextBox();
            txthocphi = new TextBox();
            txttang = new TextBox();
            txtkhu = new TextBox();
            txttenlop = new TextBox();
            txttim = new Button();
            label6 = new Label();
            btnsua = new Button();
            btnxoa = new Button();
            btnThem = new Button();
            btnluu = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv = new DataGridView();
            malop = new DataGridViewTextBoxColumn();
            tenlop = new DataGridViewTextBoxColumn();
            hocphi = new DataGridViewTextBoxColumn();
            khu = new DataGridViewTextBoxColumn();
            tang = new DataGridViewTextBoxColumn();
            makhoahoc = new DataGridViewTextBoxColumn();
            tenKhoahoc = new DataGridViewTextBoxColumn();
            magiaovien = new DataGridViewTextBoxColumn();
            tenGiaoVien = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label8 = new Label();
            txttenkhoa = new TextBox();
            cbmakhoa = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            txttengiaovien = new TextBox();
            label19 = new Label();
            cbmagiaovien = new ComboBox();
            label20 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cbmalop);
            groupBox1.Controls.Add(txttimlop);
            groupBox1.Controls.Add(txthocphi);
            groupBox1.Controls.Add(txttang);
            groupBox1.Controls.Add(txtkhu);
            groupBox1.Controls.Add(txttenlop);
            groupBox1.Controls.Add(txttim);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 499);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp học";
            // 
            // cbmalop
            // 
            cbmalop.FormattingEnabled = true;
            cbmalop.Items.AddRange(new object[] { "TA01", "TA02", "TA03", "TA04", "TA05" });
            cbmalop.Location = new Point(191, 43);
            cbmalop.Name = "cbmalop";
            cbmalop.Size = new Size(165, 33);
            cbmalop.TabIndex = 29;
            // 
            // txttimlop
            // 
            txttimlop.Location = new Point(198, 400);
            txttimlop.Name = "txttimlop";
            txttimlop.Size = new Size(158, 31);
            txttimlop.TabIndex = 16;
            // 
            // txthocphi
            // 
            txthocphi.Location = new Point(191, 270);
            txthocphi.Name = "txthocphi";
            txthocphi.Size = new Size(165, 31);
            txthocphi.TabIndex = 15;
            // 
            // txttang
            // 
            txttang.Location = new Point(191, 219);
            txttang.Name = "txttang";
            txttang.Size = new Size(165, 31);
            txttang.TabIndex = 14;
            // 
            // txtkhu
            // 
            txtkhu.Location = new Point(191, 167);
            txtkhu.Name = "txtkhu";
            txtkhu.Size = new Size(165, 31);
            txtkhu.TabIndex = 13;
            // 
            // txttenlop
            // 
            txttenlop.Location = new Point(191, 109);
            txttenlop.Name = "txttenlop";
            txttenlop.Size = new Size(165, 31);
            txttenlop.TabIndex = 12;
            // 
            // txttim
            // 
            txttim.BackgroundImage = Properties.Resources.search1;
            txttim.BackgroundImageLayout = ImageLayout.Center;
            txttim.FlatStyle = FlatStyle.Flat;
            txttim.Location = new Point(279, 443);
            txttim.Name = "txttim";
            txttim.Size = new Size(69, 50);
            txttim.TabIndex = 10;
            txttim.UseVisualStyleBackColor = true;
            txttim.Click += txttim_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 400);
            label6.Name = "label6";
            label6.Size = new Size(133, 75);
            label6.TabIndex = 9;
            label6.Text = "Nhập thông tin\r\n    lớphọc\r\n(nhập mã)";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnsua
            // 
            btnsua.BackgroundImage = Properties.Resources.fix1;
            btnsua.BackgroundImageLayout = ImageLayout.Center;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.Location = new Point(279, 325);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(69, 61);
            btnsua.TabIndex = 8;
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackgroundImage = Properties.Resources.delete1;
            btnxoa.BackgroundImageLayout = ImageLayout.Center;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Location = new Point(191, 325);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(69, 61);
            btnxoa.TabIndex = 7;
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackgroundImage = Properties.Resources.insert1;
            btnThem.BackgroundImageLayout = ImageLayout.Center;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(99, 325);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(69, 61);
            btnThem.TabIndex = 6;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnluu
            // 
            btnluu.BackgroundImage = Properties.Resources.save1;
            btnluu.BackgroundImageLayout = ImageLayout.Center;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Location = new Point(14, 325);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(69, 61);
            btnluu.TabIndex = 5;
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 276);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 4;
            label5.Text = "Học phí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 219);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 3;
            label4.Text = "Tầng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 167);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "Khu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 109);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên lớp ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgv);
            groupBox2.Location = new Point(447, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1408, 423);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lớp học ";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { malop, tenlop, hocphi, khu, tang, makhoahoc, tenKhoahoc, magiaovien, tenGiaoVien });
            dgv.Location = new Point(17, 34);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(1391, 383);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            dgv.RowEnter += dgv_RowEnter;
            // 
            // malop
            // 
            malop.DataPropertyName = "malop";
            malop.HeaderText = "Mã lớp học";
            malop.MinimumWidth = 8;
            malop.Name = "malop";
            malop.Width = 150;
            // 
            // tenlop
            // 
            tenlop.DataPropertyName = "tenlop";
            tenlop.HeaderText = "Tên lớp học";
            tenlop.MinimumWidth = 8;
            tenlop.Name = "tenlop";
            tenlop.Width = 150;
            // 
            // hocphi
            // 
            hocphi.DataPropertyName = "hocphi";
            hocphi.HeaderText = "Học phí";
            hocphi.MinimumWidth = 8;
            hocphi.Name = "hocphi";
            hocphi.Width = 150;
            // 
            // khu
            // 
            khu.DataPropertyName = "khu";
            khu.HeaderText = "Khu";
            khu.MinimumWidth = 8;
            khu.Name = "khu";
            khu.Width = 150;
            // 
            // tang
            // 
            tang.DataPropertyName = "tang";
            tang.HeaderText = "Tầng";
            tang.MinimumWidth = 8;
            tang.Name = "tang";
            tang.Width = 150;
            // 
            // makhoahoc
            // 
            makhoahoc.DataPropertyName = "makhoahoc";
            makhoahoc.HeaderText = "Mã khóa";
            makhoahoc.MinimumWidth = 8;
            makhoahoc.Name = "makhoahoc";
            makhoahoc.Width = 150;
            // 
            // tenKhoahoc
            // 
            tenKhoahoc.DataPropertyName = "tenKhoahoc";
            tenKhoahoc.HeaderText = "Tên khóa";
            tenKhoahoc.MinimumWidth = 8;
            tenKhoahoc.Name = "tenKhoahoc";
            tenKhoahoc.Width = 150;
            // 
            // magiaovien
            // 
            magiaovien.DataPropertyName = "magiaovien";
            magiaovien.HeaderText = "Mã giáo viên";
            magiaovien.MinimumWidth = 8;
            magiaovien.Name = "magiaovien";
            magiaovien.Width = 150;
            // 
            // tenGiaoVien
            // 
            tenGiaoVien.DataPropertyName = "tenGiaoVien";
            tenGiaoVien.HeaderText = "Tên giáo viên";
            tenGiaoVien.MinimumWidth = 8;
            tenGiaoVien.Name = "tenGiaoVien";
            tenGiaoVien.Width = 150;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txttenkhoa);
            groupBox3.Controls.Add(cbmakhoa);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txttengiaovien);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(cbmagiaovien);
            groupBox3.Controls.Add(label20);
            groupBox3.Location = new Point(24, 625);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 256);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khóa học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 86);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 20;
            label8.Text = "Tên khóa học";
            // 
            // txttenkhoa
            // 
            txttenkhoa.Location = new Point(136, 86);
            txttenkhoa.Name = "txttenkhoa";
            txttenkhoa.Size = new Size(158, 31);
            txttenkhoa.TabIndex = 19;
            // 
            // cbmakhoa
            // 
            cbmakhoa.FormattingEnabled = true;
            cbmakhoa.Location = new Point(136, 39);
            cbmakhoa.Name = "cbmakhoa";
            cbmakhoa.Size = new Size(158, 33);
            cbmakhoa.TabIndex = 18;
            cbmakhoa.SelectedIndexChanged += cbmakhoa_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 75);
            label14.Name = "label14";
            label14.Size = new Size(0, 25);
            label14.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 32);
            label13.Name = "label13";
            label13.Size = new Size(115, 25);
            label13.TabIndex = 0;
            label13.Text = "Mã khóa học";
            // 
            // txttengiaovien
            // 
            txttengiaovien.Location = new Point(136, 176);
            txttengiaovien.Name = "txttengiaovien";
            txttengiaovien.Size = new Size(158, 31);
            txttengiaovien.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 134);
            label19.Name = "label19";
            label19.Size = new Size(114, 25);
            label19.TabIndex = 1;
            label19.Text = "Mã giáo viên";
            // 
            // cbmagiaovien
            // 
            cbmagiaovien.FormattingEnabled = true;
            cbmagiaovien.Location = new Point(136, 131);
            cbmagiaovien.Name = "cbmagiaovien";
            cbmagiaovien.Size = new Size(158, 33);
            cbmagiaovien.TabIndex = 15;
            cbmagiaovien.SelectedIndexChanged += cbmagiaovien_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 179);
            label20.Name = "label20";
            label20.Size = new Size(115, 25);
            label20.TabIndex = 2;
            label20.Text = "Tên giáo viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 0, 64);
            label7.Location = new Point(596, 45);
            label7.Name = "label7";
            label7.Size = new Size(423, 74);
            label7.TabIndex = 17;
            label7.Text = "Quản lý lớp học\r\n";
            // 
            // FormLopHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.form;
            ClientSize = new Size(1867, 1050);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormLopHoc";
            Text = "FormLopHoc";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txttim;
        private Label label6;
        private Button btnsua;
        private Button btnxoa;
        private Button btnThem;
        private Button btnluu;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txttimlop;
        private TextBox txthocphi;
        private TextBox txttang;
        private TextBox txtkhu;
        private TextBox txttenlop;
        private DataGridView dgv;
        private GroupBox groupBox3;
        private ComboBox cbmakhoa;
        private Label label14;
        private Label label13;
        private TextBox txttengiaovien;
        private Label label19;
        private ComboBox cbmagiaovien;
        private Label label20;
        private Label label7;
        private Label label8;
        private TextBox txttenkhoa;
        private DataGridViewTextBoxColumn malop;
        private DataGridViewTextBoxColumn tenlop;
        private DataGridViewTextBoxColumn hocphi;
        private DataGridViewTextBoxColumn khu;
        private DataGridViewTextBoxColumn tang;
        private DataGridViewTextBoxColumn makhoahoc;
        private DataGridViewTextBoxColumn tenKhoahoc;
        private DataGridViewTextBoxColumn magiaovien;
        private DataGridViewTextBoxColumn tenGiaoVien;
        private ComboBox cbmalop;
    }
}