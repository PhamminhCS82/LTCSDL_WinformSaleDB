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
            dtgvKhachHang.Columns[0].Width = (int)(0.15 * dtgvKhachHang.Width);
            dtgvKhachHang.Columns[1].Width = (int)(0.2 * dtgvKhachHang.Width);
            dtgvKhachHang.Columns[2].Width = (int)(0.2 * dtgvKhachHang.Width);
            dtgvKhachHang.Columns[3].Width = (int)(0.2 * dtgvKhachHang.Width);
            dtgvKhachHang.Columns[4].Width = (int)(0.2 * dtgvKhachHang.Width);
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            CapNhat();
            dtgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" || txtDiaChi.Text == "" || 
                txtSoDienThoai.Text == "" || txtTenCongTy.Text == "")
                MessageBox.Show("Vui lòng điền dầy đủ thông tin", "Thông báo");
            else
            {
                Customer khachHang = new Customer();
                khachHang.Address = txtDiaChi.Text.Trim();
                khachHang.CompanyName = txtTenCongTy.Text.Trim();
                khachHang.Phone = txtSoDienThoai.Text.Trim();
                khachHang.ContactName = txtTenKhachHang.Text.Trim();
                if (busKhachHang.ThemKhachHang(khachHang))
                {
                    CapNhat();
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng");
            }    
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sự kiện kiểm tra và chỉ cho nhập số
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dtgvKhachHang.Rows.Count)
            {
                txtMaKhachHang.Text = dtgvKhachHang.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                txtDiaChi.Text = dtgvKhachHang.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtTenKhachHang.Text = dtgvKhachHang.Rows[e.RowIndex].Cells["ContactName"].Value.ToString();
                txtSoDienThoai.Text = dtgvKhachHang.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtTenCongTy.Text = dtgvKhachHang.Rows[e.RowIndex].Cells["Companyname"].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" || txtDiaChi.Text == "" ||
                txtSoDienThoai.Text == "" || txtTenCongTy.Text == "")
                MessageBox.Show("Vui lòng điền dầy đủ thông tin", "Thông báo");
            else
            {
                Customer khachHang = new Customer();
                khachHang.CustomerID = int.Parse(dtgvKhachHang.CurrentRow.Cells["CustomerID"].Value.ToString());
                khachHang.Address = txtDiaChi.Text.Trim();
                khachHang.CompanyName = txtTenCongTy.Text.Trim();
                khachHang.Phone = txtSoDienThoai.Text.Trim();
                khachHang.ContactName = txtTenKhachHang.Text.Trim();
                if (busKhachHang.SuaKhachHang(khachHang))
                {
                    CapNhat();
                    MessageBox.Show("Sửa khách hàng thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi khi sửa khách hàng");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Customer khachHang = new Customer();
                khachHang.CustomerID = int.Parse(dtgvKhachHang.CurrentRow.Cells["CustomerID"].Value.ToString());
                if (busKhachHang.XoaKhachHang(khachHang))
                {
                    CapNhat(); 

                    //Clear các giá trị trên Textbox
                    txtDiaChi.Text = "";
                    txtMaKhachHang.Text = "";
                    txtSoDienThoai.Text = "";
                    txtTenCongTy.Text = "";
                    txtTenKhachHang.Text = "";
                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng", "Thông báo");
            }
        }
    }
}
