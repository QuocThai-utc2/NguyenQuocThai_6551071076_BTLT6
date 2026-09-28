namespace bai3
{
    partial class FormNhapDiem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã HS ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 25);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 25);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 25);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 25);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Điểm Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(24, 43);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(56, 23);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(98, 43);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(63, 23);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(175, 43);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(76, 23);
            txtToan.TabIndex = 2;
            txtToan.TextChanged += this.txtToan_TextChanged;
            txtToan.Enter += ChonHetNoiDung_Enter;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(271, 43);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(65, 23);
            txtVan.TabIndex = 3;
            txtVan.Enter += ChonHetNoiDung_Enter;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(372, 43);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(70, 23);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += ChonHetNoiDung_Enter;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(24, 72);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(105, 72);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(75, 23);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(24, 101);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(418, 229);
            lstKetQua.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 373);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhapDiem";
            Text = "FormNhapDiem";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private ErrorProvider errorProvider1;
    }
}
