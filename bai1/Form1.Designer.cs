namespace bai1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(150, 98);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(193, 23);
            txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(150, 127);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(193, 23);
            txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(150, 185);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(193, 23);
            txtMatKhau.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 98);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 131);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "SĐT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 162);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 191);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 217);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 9;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(151, 214);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(192, 23);
            txtXacNhanMK.TabIndex = 10;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.CornflowerBlue;
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(151, 253);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(81, 31);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(259, 253);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(84, 31);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(228, 28);
            label6.TabIndex = 14;
            label6.Text = "Đăng ký tài khoản mới";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 47);
            label7.Name = "label7";
            label7.Size = new Size(172, 15);
            label7.TabIndex = 15;
            label7.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 343);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Label label6;
    }
}
