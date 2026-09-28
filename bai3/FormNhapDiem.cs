using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyPress += TextBox_KeyPress_Enter;
                }
            }
        }

        private void TextBox_KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;   // chặn tiếng "bíp"

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void ChonHetNoiDung_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            decimal toan, van, anh;
            if (!KiemTraDiem(txtToan, out toan)) hopLe = false;
            if (!KiemTraDiem(txtVan, out van)) hopLe = false;
            if (!KiemTraDiem(txtAnh, out anh)) hopLe = false;

            if (!hopLe)
            {
                return;
            }

            string dong = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{toan} V:{van} A:{anh}";
            lstKetQua.Items.Add(dong);

            XoaTrang();
        }

        private bool KiemTraDiem(TextBox txt, out decimal diem)
        {
            if (decimal.TryParse(txt.Text.Trim(), out diem) && diem >= 0m && diem <= 10m)
            {
                errorProvider1.SetError(txt, "");
                return true;
            }

            errorProvider1.SetError(txt, "Điểm phải là số từ 0.0 đến 10.0");
            return false;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            txtMaHS.Focus();
        }
    }
}