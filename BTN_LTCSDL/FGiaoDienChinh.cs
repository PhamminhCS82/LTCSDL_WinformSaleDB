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
    public partial class FGiaoDienChinh : Form
    {
        public FGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            panel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseChildForm()
        {
            panel1.Controls.Clear();
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            OpenChildForm(new FSanPham());
        }

        private void btDonHang_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            OpenChildForm(new FDonHang());
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            OpenChildForm(new FKhachHang());
        }
    }
}
