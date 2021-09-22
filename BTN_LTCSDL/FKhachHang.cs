using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTN_LTCSDL.BUS;

namespace BTN_LTCSDL
{
    public partial class FKhachHang : Form
    {
        private BUS_KhachHang busKhachHang;

        public FKhachHang()
        {
            InitializeComponent();
            busKhachHang = new BUS_KhachHang();
        }

        private void CapNhat()
        {
            busKhachHang.HienThiDSKhachHang(dtgvKhachHang);
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;

            CapNhat();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }
    }
}
