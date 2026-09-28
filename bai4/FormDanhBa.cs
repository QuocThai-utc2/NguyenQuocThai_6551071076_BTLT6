using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private string LayTen(string lienHe)
        {
            int viTri = lienHe.LastIndexOf(" - ");
            return viTri >= 0 ? lienHe.Substring(0, viTri) : lienHe;
        }

        private string LaySDT(string lienHe)
        {
            int viTri = lienHe.LastIndexOf(" - ");
            return viTri >= 0 ? lienHe.Substring(viTri + 3) : "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại.",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lienHe = $"{ten} - {sdt}";

            if (_indexDangSua >= 0)
            {
                lstLienHe.Items[_indexDangSua] = lienHe;
                _indexDangSua = -1;

                txtTen.Clear();
                txtSDT.Clear();

                MessageBox.Show("Cập nhật thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items.Add(lienHe);

                txtTen.Clear();
                txtSDT.Clear();

                MessageBox.Show("Thêm thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lienHe = lstLienHe.SelectedItem.ToString();
            txtTen.Text = LayTen(lienHe);
            txtSDT.Text = LaySDT(lienHe);

            _indexDangSua = lstLienHe.SelectedIndex;  
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = lstLienHe.SelectedIndex;
            string ten = LayTen(lstLienHe.SelectedItem.ToString());

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten + "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(index);

                // Giữ cho _indexDangSua luôn trỏ đúng
                if (_indexDangSua == index)
                {
                    _indexDangSua = -1;
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (_indexDangSua > index)
                {
                    _indexDangSua--;
                }

                MessageBox.Show("Xóa liên hệ thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }

            if (txtTen.Text.Trim() != "" || txtSDT.Text.Trim() != "")
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (ketQua == DialogResult.Cancel)
                {
                    e.Cancel = true;      
                }
                else if (ketQua == DialogResult.No)
                {
                    txtTen.Clear();      
                    txtSDT.Clear();
                }
          
            }
        }
    }
}