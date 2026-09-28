namespace bai2
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
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnDatPhong = new Button();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(63, 42);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(353, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(63, 103);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(353, 23);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(63, 170);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(353, 23);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(63, 236);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(353, 23);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 81);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 146);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 212);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Ngày trả phòng";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Font = new Font("Segoe UI", 15F);
            btnDatPhong.Location = new Point(63, 395);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(353, 41);
            btnDatPhong.TabIndex = 8;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(63, 295);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(353, 23);
            txtSoNguoiLon.TabIndex = 9;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(66, 356);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(350, 23);
            txtSoTreEm.TabIndex = 10;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 272);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 11;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 332);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 12;
            label6.Text = "Số trẻ em";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(btnDatPhong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Button btnDatPhong;
        private TextBox txtSoTreEm;
        private TextBox txtSoNguoiLon;
        private Label label6;
        private Label label5;
    }
}
