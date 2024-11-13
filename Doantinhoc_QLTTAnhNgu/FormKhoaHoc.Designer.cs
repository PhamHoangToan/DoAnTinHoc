namespace Doantinhoc_QLTTAnhNgu
{
    partial class FormKhoaHoc
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
            cbmakhoa = new ComboBox();
            btntim = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            btnluu = new Button();
            txttimkhoa = new TextBox();
            dtpngayketthuc = new DateTimePicker();
            dtpngaybatdau = new DateTimePicker();
            txttenkhoa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv = new DataGridView();
            makhoahoc = new DataGridViewTextBoxColumn();
            tenkhoahoc = new DataGridViewTextBoxColumn();
            ngaybatdau = new DataGridViewTextBoxColumn();
            ngayketthuc = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cbmakhoa);
            groupBox1.Controls.Add(btntim);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(txttimkhoa);
            groupBox1.Controls.Add(dtpngayketthuc);
            groupBox1.Controls.Add(dtpngaybatdau);
            groupBox1.Controls.Add(txttenkhoa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khóa học ";
            // 
            // cbmakhoa
            // 
            cbmakhoa.FormattingEnabled = true;
            cbmakhoa.Items.AddRange(new object[] { "TACB", "TANC", "TAGT" });
            cbmakhoa.Location = new Point(191, 52);
            cbmakhoa.Name = "cbmakhoa";
            cbmakhoa.Size = new Size(147, 33);
            cbmakhoa.TabIndex = 28;
            // 
            // btntim
            // 
            btntim.BackgroundImage = Properties.Resources.search1;
            btntim.BackgroundImageLayout = ImageLayout.Center;
            btntim.FlatStyle = FlatStyle.Flat;
            btntim.Location = new Point(246, 417);
            btntim.Name = "btntim";
            btntim.Size = new Size(75, 47);
            btntim.TabIndex = 14;
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnsua
            // 
            btnsua.BackgroundImage = Properties.Resources.fix1;
            btnsua.BackgroundImageLayout = ImageLayout.Center;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.Location = new Point(288, 277);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 61);
            btnsua.TabIndex = 13;
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackgroundImage = Properties.Resources.delete1;
            btnxoa.BackgroundImageLayout = ImageLayout.Center;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Location = new Point(188, 277);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 61);
            btnxoa.TabIndex = 12;
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.BackgroundImage = Properties.Resources.insert1;
            btnthem.BackgroundImageLayout = ImageLayout.Center;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.Location = new Point(98, 277);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 61);
            btnthem.TabIndex = 11;
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnluu
            // 
            btnluu.BackgroundImage = Properties.Resources.save1;
            btnluu.BackgroundImageLayout = ImageLayout.Center;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Location = new Point(6, 277);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(75, 61);
            btnluu.TabIndex = 10;
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // txttimkhoa
            // 
            txttimkhoa.Location = new Point(188, 361);
            txttimkhoa.Name = "txttimkhoa";
            txttimkhoa.Size = new Size(150, 31);
            txttimkhoa.TabIndex = 9;
            // 
            // dtpngayketthuc
            // 
            dtpngayketthuc.Location = new Point(191, 225);
            dtpngayketthuc.Name = "dtpngayketthuc";
            dtpngayketthuc.Size = new Size(147, 31);
            dtpngayketthuc.TabIndex = 8;
            // 
            // dtpngaybatdau
            // 
            dtpngaybatdau.Location = new Point(191, 170);
            dtpngaybatdau.Name = "dtpngaybatdau";
            dtpngaybatdau.Size = new Size(147, 31);
            dtpngaybatdau.TabIndex = 7;
            // 
            // txttenkhoa
            // 
            txttenkhoa.Location = new Point(188, 111);
            txttenkhoa.Name = "txttenkhoa";
            txttenkhoa.Size = new Size(150, 31);
            txttenkhoa.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 361);
            label6.Name = "label6";
            label6.Size = new Size(138, 75);
            label6.TabIndex = 4;
            label6.Text = "Nhập thông tin \r\n    khóa học\r\n(nhập mã)\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 231);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày kết thúc ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 166);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 2;
            label4.Text = "Ngày bắt đầu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 111);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 1;
            label3.Text = "Tên khóa học ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã khóa học ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(519, 18);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "Quản lý khóa học ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgv);
            groupBox2.Location = new Point(406, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(705, 491);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khóa học ";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { makhoahoc, tenkhoahoc, ngaybatdau, ngayketthuc });
            dgv.Location = new Point(16, 30);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(672, 225);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentClick += dgv_RowEnter;
            dgv.RowEnter += dgv_RowEnter;
            // 
            // makhoahoc
            // 
            makhoahoc.DataPropertyName = "makhoahoc";
            makhoahoc.HeaderText = "Mã khóa học ";
            makhoahoc.MinimumWidth = 8;
            makhoahoc.Name = "makhoahoc";
            makhoahoc.Width = 150;
            // 
            // tenkhoahoc
            // 
            tenkhoahoc.DataPropertyName = "tenkhoahoc";
            tenkhoahoc.HeaderText = "Tên khóa học ";
            tenkhoahoc.MinimumWidth = 8;
            tenkhoahoc.Name = "tenkhoahoc";
            tenkhoahoc.Width = 150;
            // 
            // ngaybatdau
            // 
            ngaybatdau.DataPropertyName = "ngaybatdau";
            ngaybatdau.HeaderText = "Ngày bắt đầu ";
            ngaybatdau.MinimumWidth = 8;
            ngaybatdau.Name = "ngaybatdau";
            ngaybatdau.Width = 150;
            // 
            // ngayketthuc
            // 
            ngayketthuc.DataPropertyName = "ngayketthuc";
            ngayketthuc.HeaderText = "Ngày kết thúc";
            ngayketthuc.MinimumWidth = 8;
            ngayketthuc.Name = "ngayketthuc";
            ngayketthuc.Width = 150;
            // 
            // FormKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.form;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1132, 587);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormKhoaHoc";
            Text = "FormKhoaHoc";
            Load += Form3_Load;
            Shown += FormKhoaHoc_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private Button btnluu;
        private TextBox txttimkhoa;
        private DateTimePicker dtpngayketthuc;
        private DateTimePicker dtpngaybatdau;
        private TextBox txttenkhoa;
        private Button btntim;
        private GroupBox groupBox2;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn makhoa;
        private DataGridViewTextBoxColumn tenkhoa;
        private DataGridViewTextBoxColumn ngaybatdau;
        private DataGridViewTextBoxColumn ngayketthuc;
        private DataGridViewTextBoxColumn makhoahoc;
        private DataGridViewTextBoxColumn tenkhoahoc;
        private ComboBox cbmakhoa;
    }
}