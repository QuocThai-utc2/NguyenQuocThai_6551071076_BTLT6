namespace bai5
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.FormattingEnabled = true;
            lstGhe.Location = new Point(24, 20);
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(110, 229);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(155, 25);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(100, 15);
            lblGheDaChon.Text = "Đang chọn: (chưa chọn)";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(155, 190);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(100, 27);
            btnXacNhan.TabIndex = 1;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(155, 223);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(100, 27);
            btnBoQua.TabIndex = 2;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 275);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(lstGhe);
            Name = "FormChonGhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn ghế";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnBoQua;
    }
}