using BTN_LTCSDL.BUS;
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
    public partial class FDonHang : Form
    {
        BUS_DonHang busDH;
        public FDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        private void HienThiDSDonHang()
        {
            dtgvDonHang.DataSource = null;
            busDH.HienThiDSDonHang(dtgvDonHang);
            dtgvDonHang.Columns[0].Width = (int)(dtgvDonHang.Width * 0.2);
            dtgvDonHang.Columns[1].Width = (int)(dtgvDonHang.Width * 0.25);
            dtgvDonHang.Columns[2].Width = (int)(dtgvDonHang.Width * 0.25);
            dtgvDonHang.Columns[3].Width = (int)(dtgvDonHang.Width * 0.25);
        }
        private void FDonHang_Load(object sender, EventArgs e)
        {
            HienThiDSDonHang();
            busDH.layDSKhachHang(cbKhachHang);
            busDH.layDSNhanVien(cbNhanVien);
            //Không cho nhập ở combobox
            cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Tạo đơn hàng mới
        private void btThem_Click(object sender, EventArgs e)
        {
            Order donHang = new Order();
            donHang.OrderDate = dtpNgayDatHang.Value;
            donHang.EmployeeID = Int32.Parse(cbNhanVien.SelectedValue.ToString());
            donHang.CustomerID = Int32.Parse(cbKhachHang.SelectedValue.ToString());
            if (busDH.TaoDonHang(donHang))
            {
                MessageBox.Show("Tạo đơn hàng thành công");
                busDH.HienThiDSDonHang(dtgvDonHang);
            }
            else
                MessageBox.Show("Tạo đơn hàng thất bại");
        }

        private void dtgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvDonHang.Rows.Count)
            {
                txtMaDonHang.Text = dtgvDonHang.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDatHang.Text = dtgvDonHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbNhanVien.Text = dtgvDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbKhachHang.Text = dtgvDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
