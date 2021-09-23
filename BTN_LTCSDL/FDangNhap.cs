using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_LTCSDL
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap()
        {
            MessageBox.Show("Dăng nhập");
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
                DangNhap();
            return base.ProcessDialogKey(keyData);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btDangNhap_MouseEnter(object sender, EventArgs e)
        {
            btDangNhap.BackColor = Color.FromArgb(62, 58, 214);
        }

        private void btDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btDangNhap.BackColor = Color.FromArgb(108, 99, 255);
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            //Này để focus nào txtDangNhap
            txtTenDangNhap.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
