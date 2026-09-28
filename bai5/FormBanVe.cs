using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai5
{
    public partial class FormBanVe : Form
    {
        private const int GIA_VE = 75000;

        public FormBanVe()
        {
            InitializeComponent();
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string tenKhach = txtTenKhach.Text.Trim();

            if (string.IsNullOrEmpty(tenKhach)
                || cboPhim.SelectedIndex < 0
                || cboSuatChieu.SelectedIndex < 0
                || string.IsNullOrEmpty(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách, chọn phim, suất chiếu và ghế.",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin =
                "Khách hàng: " + tenKhach + "\n" +
                "Phim: " + cboPhim.SelectedItem + "\n" +
                "Suất chiếu: " + cboSuatChieu.SelectedItem + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: " + GIA_VE.ToString("N0") + "đ/vé";

            MessageBox.Show(thongTin, "Đặt vé thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }
    }
}