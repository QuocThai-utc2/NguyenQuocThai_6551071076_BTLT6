namespace bai6
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            mnuTep = new ToolStripMenuItem();
            mnuMoGhiChuMoi = new ToolStripMenuItem();
            mnuSapXepCuaSo = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuXepTang = new ToolStripMenuItem();
            mnuXepNgang = new ToolStripMenuItem();
            mnuXepDoc = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep, mnuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTep
            // 
            mnuTep.DropDownItems.AddRange(new ToolStripItem[] { mnuMoGhiChuMoi, mnuSapXepCuaSo, mnuThoat });
            mnuTep.Name = "mnuTep";
            mnuTep.Size = new Size(39, 20);
            mnuTep.Text = "Tệp";
            // 
            // mnuMoGhiChuMoi
            // 
            mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
            mnuMoGhiChuMoi.Size = new Size(159, 22);
            mnuMoGhiChuMoi.Text = "Mở ghi chú mới";
            mnuMoGhiChuMoi.Click += mnuMoGhiChuMoi_Click;
            // 
            // mnuSapXepCuaSo
            // 
            mnuSapXepCuaSo.Name = "mnuSapXepCuaSo";
            mnuSapXepCuaSo.Size = new Size(159, 22);
            mnuSapXepCuaSo.Text = "Sắp xếp cửa sổ";
            mnuSapXepCuaSo.Click += mnuSapXepCuaSo_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(159, 22);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuXepNgang, mnuXepDoc });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(55, 20);
            mnuCuaSo.Text = "Cửa sổ";
            // 
            // mnuXepTang
            // 
            mnuXepTang.Name = "mnuXepTang";
            mnuXepTang.Size = new Size(131, 22);
            mnuXepTang.Text = "Xếp tầng";
            mnuXepTang.Click += mnuXepTang_Click;
            // 
            // mnuXepNgang
            // 
            mnuXepNgang.Name = "mnuXepNgang";
            mnuXepNgang.Size = new Size(131, 22);
            mnuXepNgang.Text = "Xếp ngang";
            mnuXepNgang.Click += mnuXepNgang_Click;
            // 
            // mnuXepDoc
            // 
            mnuXepDoc.Name = "mnuXepDoc";
            mnuXepDoc.Size = new Size(131, 22);
            mnuXepDoc.Text = "Xếp dọc";
            mnuXepDoc.Click += mnuXepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoGhiChu });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoGhiChu
            // 
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(126, 17);
            lblSoGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "FormChinh";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTep;
        private ToolStripMenuItem mnuMoGhiChuMoi;
        private ToolStripMenuItem mnuSapXepCuaSo;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuXepTang;
        private ToolStripMenuItem mnuXepNgang;
        private ToolStripMenuItem mnuXepDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoGhiChu;
    }
}