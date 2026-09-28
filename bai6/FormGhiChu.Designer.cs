namespace bai6
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            lblTieuDe = new Label();
            txtTieuDe = new TextBox();
            lblMucDo = new Label();
            cboMucDoUuTien = new ComboBox();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            lblDemKyTu = new Label();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.BorderStyle = BorderStyle.FixedSingle;
            lblTieuDeForm.Dock = DockStyle.Top;
            lblTieuDeForm.Location = new Point(0, 0);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(400, 30);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "GHI CHÚ CÔNG VIỆC";
            lblTieuDeForm.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(16, 45);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(46, 15);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "Tiêu đề";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(16, 63);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(368, 23);
            txtTieuDe.TabIndex = 1;
            txtTieuDe.TextChanged += DanhDauThayDoi;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lblMucDo
            // 
            lblMucDo.AutoSize = true;
            lblMucDo.Location = new Point(16, 292);
            lblMucDo.Name = "lblMucDo";
            lblMucDo.Size = new Size(45, 15);
            lblMucDo.TabIndex = 7;
            lblMucDo.Text = "Priority";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(16, 310);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(180, 23);
            cboMucDoUuTien.TabIndex = 2;
            cboMucDoUuTien.SelectedIndexChanged += DanhDauThayDoi;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(16, 105);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(57, 15);
            lblNoiDung.TabIndex = 6;
            lblNoiDung.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(16, 124);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(368, 165);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // lblDemKyTu
            // 
            lblDemKyTu.AutoSize = true;
            lblDemKyTu.Location = new Point(326, 106);
            lblDemKyTu.Name = "lblDemKyTu";
            lblDemKyTu.Size = new Size(36, 15);
            lblDemKyTu.TabIndex = 5;
            lblDemKyTu.Text = "0/500";
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(284, 297);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(100, 28);
            btnLuuGhiChu.TabIndex = 4;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(400, 345);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(lblDemKyTu);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblMucDo);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblTieuDe;
        private TextBox txtTieuDe;
        private Label lblMucDo;
        private ComboBox cboMucDoUuTien;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private Label lblDemKyTu;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}