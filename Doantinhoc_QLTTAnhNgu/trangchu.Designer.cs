namespace Doantinhoc_QLTTAnhNgu
{
    partial class trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangchu));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txttaikhoan = new TextBox();
            txtmatkhau = new TextBox();
            button2 = new Button();
            cbpass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(567, 140);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG QUẢN LÍ \r\nTRUNG TÂM ANH NGỮ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.login1;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(87, 351);
            button1.Name = "button1";
            button1.Size = new Size(92, 79);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 187);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 242);
            label3.Name = "label3";
            label3.Size = new Size(133, 38);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txttaikhoan
            // 
            txttaikhoan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txttaikhoan.Location = new Point(193, 193);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(206, 37);
            txttaikhoan.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(193, 245);
            txtmatkhau.Multiline = true;
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(206, 31);
            txtmatkhau.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.exit1;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(244, 351);
            button2.Name = "button2";
            button2.Size = new Size(83, 79);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cbpass
            // 
            cbpass.AutoSize = true;
            cbpass.BackColor = Color.Transparent;
            cbpass.FlatStyle = FlatStyle.Flat;
            cbpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbpass.Location = new Point(193, 297);
            cbpass.Name = "cbpass";
            cbpass.Size = new Size(192, 36);
            cbpass.TabIndex = 7;
            cbpass.Text = "Hiện mật khẩu";
            cbpass.UseVisualStyleBackColor = false;
            cbpass.CheckedChanged += cbpass_CheckedChanged;
            // 
            // trangchu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 499);
            Controls.Add(cbpass);
            Controls.Add(button2);
            Controls.Add(txtmatkhau);
            Controls.Add(txttaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "trangchu";
            Text = "trangchu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txttaikhoan;
        private TextBox txtmatkhau;
        private Button button2;
        private CheckBox cbpass;
    }
}