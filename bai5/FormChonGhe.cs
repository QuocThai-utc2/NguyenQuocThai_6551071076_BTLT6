using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe() : this("")
        {
        }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            foreach (char hang in "ABC")
            {
                for (int so = 1; so <= 5; so++)
                {
                    lstGhe.Items.Add(hang.ToString() + so);
                }
            }

            GheChon = gheHienTai;

            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = "Đang chọn: " + lstGhe.SelectedItem;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;   
            }

            GheChon = lstGhe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;  
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}