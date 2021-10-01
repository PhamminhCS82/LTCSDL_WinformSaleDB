using BTN_LTCSDL.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTN_LTCSDL
{
    public partial class FDangNhap : Form
    {
        BUS_QuanLy busQL;
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap()
        {
            User u = new User();
            u.Username = txtTenDangNhap.Text;
            u.Password = txtMatKhau.Text;
            if (busQL.KTDangNhap(u))
            {
                this.Hide();
                FGiaoDienChinh f = new FGiaoDienChinh();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
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
            busQL = new BUS_QuanLy();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
