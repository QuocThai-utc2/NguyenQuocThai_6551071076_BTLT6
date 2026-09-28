using System.Linq;
namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            string hoTen = txtHoTen.Text.Trim();
            if (hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và tối thiểu 3 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            string sdt = txtSDT.Text.Trim();
            bool sdtDungDinhDang = sdt.Length == 10 && sdt.StartsWith("0") && sdt.All(char.IsDigit);
            if (!sdtDungDinhDang)
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            string email = txtEmail.Text.Trim();
            int viTriAt = email.IndexOf('@');
            bool emailHopLe = viTriAt > 0 && email.IndexOf('.', viTriAt) > viTriAt + 1
                              && !email.EndsWith(".");
            if (!emailHopLe)
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa '@' và có dấu '.' phía sau '@' (vd: ten@gmail.com)");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            if (txtXacNhanMK.Text != txtMatKhau.Text || txtXacNhanMK.Text.Length == 0)
            {
                errorProvider1.SetError(txtXacNhanMK, "Xác nhận mật khẩu không khớp với mật khẩu");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}
