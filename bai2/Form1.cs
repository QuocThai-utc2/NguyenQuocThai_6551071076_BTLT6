using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BaoLoi(TextBox txt, string thongBao, CancelEventArgs e)
        {
            e.Cancel = true;
            errorProvider1.SetError(txt, thongBao);
            txt.BackColor = Color.MistyRose;
        }


        private void BaoDung(TextBox txt)
        {
            errorProvider1.SetError(txt, "");
            txt.BackColor = Color.Honeydew;
        }

        private bool TryParseNgay(string s, out DateTime ngay)
        {
            return DateTime.TryParseExact(s.Trim(), "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay);
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Honeydew;
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                BaoLoi(txtHoTen, "Họ tên không được để trống", e);
            else
                BaoDung(txtHoTen);
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string s = txtCCCD.Text.Trim();
            if (s.Length != 12 || !s.All(char.IsDigit))
                BaoLoi(txtCCCD, "CCCD phải gồm đúng 12 chữ số", e);
            else
                BaoDung(txtCCCD);
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            if (!TryParseNgay(txtNgayNhan.Text, out ngayNhan))
                BaoLoi(txtNgayNhan, "Ngày không hợp lệ, nhập theo dạng dd/MM/yyyy", e);
            else if (ngayNhan.Date < DateTime.Today)
                BaoLoi(txtNgayNhan, "Ngày nhận phòng không được nhỏ hơn hôm nay", e);
            else
                BaoDung(txtNgayNhan);
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayTra, ngayNhan;
            if (!TryParseNgay(txtNgayTra.Text, out ngayTra))
            {
                BaoLoi(txtNgayTra, "Ngày không hợp lệ, nhập theo dạng dd/MM/yyyy", e);
            }
            else if (!TryParseNgay(txtNgayNhan.Text, out ngayNhan))
            {
                BaoLoi(txtNgayTra, "Vui lòng nhập ngày nhận phòng hợp lệ trước", e);
            }
            else if (ngayTra.Date <= ngayNhan.Date)
            {
                BaoLoi(txtNgayTra, "Ngày trả phải lớn hơn ngày nhận phòng", e);
            }
            else
            {
                BaoDung(txtNgayTra);
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int so;
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out so) || so < 1 || so > 4)
                BaoLoi(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4", e);
            else
                BaoDung(txtSoNguoiLon);
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int so;
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out so) || so < 0 || so > 3)
                BaoLoi(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3", e);
            else
                BaoDung(txtSoTreEm);
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy",
                CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            int soDem = (ngayTra - ngayNhan).Days;

            string thongTin =
                "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Người lớn: " + txtSoNguoiLon.Text.Trim() + "\n" +
                "Trẻ em: " + txtSoTreEm.Text.Trim();

            MessageBox.Show(thongTin, "Đặt phòng thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
