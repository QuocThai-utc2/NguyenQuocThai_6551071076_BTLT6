namespace bai5
{
    partial class FormBanVe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            lblPhim = new Label();
            lblSuatChieu = new Label();
            lblGhe = new Label();
            txtTenKhach = new TextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(24, 25);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(61, 15);
            lblTenKhach.TabIndex = 10;
            lblTenKhach.Text = "Tên khách";
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(24, 60);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(35, 15);
            lblPhim.TabIndex = 9;
            lblPhim.Text = "Phim";
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(24, 95);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(62, 15);
            lblSuatChieu.TabIndex = 8;
            lblSuatChieu.Text = "Suất chiếu";
            // 
            // lblGhe
            // 
            lblGhe.AutoSize = true;
            lblGhe.Location = new Point(24, 130);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(74, 15);
            lblGhe.TabIndex = 7;
            lblGhe.Text = "Ghế đã chọn";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(110, 22);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(220, 23);
            txtTenKhach.TabIndex = 0;
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Mai", "Đào, Phở và Piano", "Lật Mặt 7", "Inside Out 2" });
            cboPhim.Location = new Point(110, 57);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(220, 23);
            cboPhim.TabIndex = 1;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "09:00", "12:30", "15:00", "18:30", "21:00" });
            cboSuatChieu.Location = new Point(110, 92);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(220, 23);
            cboSuatChieu.TabIndex = 2;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(110, 127);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(130, 23);
            txtGheDaChon.TabIndex = 3;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(24, 173);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(80, 25);
            btnChonGhe.TabIndex = 4;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(110, 170);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(100, 28);
            btnDatVe.TabIndex = 5;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(230, 170);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 28);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 351);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblGhe);
            Controls.Add(lblSuatChieu);
            Controls.Add(lblPhim);
            Controls.Add(lblTenKhach);
            Name = "FormBanVe";
            Text = "Bán vé xem phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private Label lblPhim;
        private Label lblSuatChieu;
        private Label lblGhe;
        private TextBox txtTenKhach;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}