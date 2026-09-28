using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace bai6
{
    public partial class FormGhiChu : Form
    {
        private const int GIOI_HAN_KY_TU = 500;
        private const int GIOI_HAN_TIEU_DE = 50;

        private bool _daThayDoi = false;   

        public FormGhiChu()
        {
            InitializeComponent();

            cboMucDoUuTien.SelectedIndex = 0;   
            _daThayDoi = false;             
        }

        private void DanhDauThayDoi(object sender, EventArgs e)
        {
            _daThayDoi = true;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                if (_daThayDoi)
                {
                    DialogResult ketQua = MessageBox.Show(
                        "Ghi chú có nội dung chưa lưu. Bạn có chắc muốn đóng không?",
                        "Xác nhận đóng",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (ketQua != DialogResult.Yes)
                    {
                        return;
                    }
                }

                this.Close();
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool laKyTuNhap = !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter;

            int doDaiSauKhiXoa = txtNoiDung.TextLength - txtNoiDung.SelectionLength;

            if (laKyTuNhap && doDaiSauKhiXoa >= GIOI_HAN_KY_TU)
            {
                e.Handled = true;  
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            if (txtNoiDung.TextLength > GIOI_HAN_KY_TU)
            {
                txtNoiDung.Text = txtNoiDung.Text.Substring(0, GIOI_HAN_KY_TU);
                txtNoiDung.SelectionStart = txtNoiDung.TextLength;
            }

            lblDemKyTu.Text = txtNoiDung.TextLength + "/" + GIOI_HAN_KY_TU;
            _daThayDoi = true;
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.UseVisualStyleBackColor = true;   
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (tieuDe.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (tieuDe.Length > GIOI_HAN_TIEU_DE)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề tối đa " + GIOI_HAN_TIEU_DE + " ký tự");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;  
            }

            this.Text = txtTieuDe.Text.Trim();
            _daThayDoi = false;

            MessageBox.Show("Đã lưu ghi chú", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}