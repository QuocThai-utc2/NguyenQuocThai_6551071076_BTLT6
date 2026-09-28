using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai6
{
    public partial class FormChinh : Form
    {
        private int _soThuTu = 0;  

        public FormChinh()
        {
            InitializeComponent();
            CapNhatSoGhiChu(null);
        }

        private void CapNhatSoGhiChu(Form dangDong)
        {
            int dem = 0;
            foreach (Form f in this.MdiChildren)
            {
                if (f != dangDong && !f.IsDisposed)
                {
                    dem++;
                }
            }
            lblSoGhiChu.Text = "Số ghi chú đang mở: " + dem;
        }

        private void GhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatSoGhiChu((Form)sender);
        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            _soThuTu++;

            FormGhiChu f = new FormGhiChu();   
            f.Text = "Ghi chú " + _soThuTu;
            f.MdiParent = this;                
            f.FormClosed += GhiChu_FormClosed;
            f.Show();

            CapNhatSoGhiChu(null);
        }

        private void mnuSapXepCuaSo_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);   
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}