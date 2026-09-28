namespace bai4
{
    partial class FormDanhBa
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
            lblTen = new Label();
            lblSDT = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lstLienHe = new ListBox();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(372, 28);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(26, 15);
            lblTen.TabIndex = 8;
            lblTen.Text = "Tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(373, 61);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(28, 15);
            lblSDT.TabIndex = 7;
            lblSDT.Text = "SĐT";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(406, 23);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 23);
            txtTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(406, 58);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 23);
            txtSDT.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(581, 102);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(581, 135);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 27);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(581, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 27);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(581, 201);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 27);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(24, 15);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(310, 304);
            lstLienHe.TabIndex = 6;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 340);
            Controls.Add(lstLienHe);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lblSDT);
            Controls.Add(lblTen);
            Name = "FormDanhBa";
            Text = "FormDanhBa";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private Label lblSDT;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private ListBox lstLienHe;
    }
}