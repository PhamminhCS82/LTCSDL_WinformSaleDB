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
    public partial class FSanPham : Form
    {
        private BUS_SanPham busSanPham;

        public FSanPham()
        {
            InitializeComponent();
            busSanPham = new BUS_SanPham();
        }

        private void CapNhat()
        {
            busSanPham.HienThiDSSanPham(dtgvSanPham);
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            //Không cho nhập ở Mã sản phẩm
            txtMaSanPham.Enabled = false;

            CapNhat();
            dtgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvSanPham.MultiSelect = false;

            busSanPham.HienThiDSLoaiSanPham(cbLoaiSanPham);
            busSanPham.HienThiDSNhaCungCap(cbNhaCungCap);

            //Không cho nhập ở Combobox
            cbLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dtgvSanPham.Rows.Count)
            {
                txtMaSanPham.Text = dtgvSanPham.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtTenSanPham.Text = dtgvSanPham.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtDonGia.Text = dtgvSanPham.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                numSoLuong.Value = decimal.Parse(dtgvSanPham.Rows[e.RowIndex].Cells["UnitsInStock"].Value.ToString());
                cbLoaiSanPham.Text = dtgvSanPham.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                cbNhaCungCap.Text = dtgvSanPham.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text == "" || txtDonGia.Text == ""
                || cbLoaiSanPham.Text == "" || cbNhaCungCap.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            else if (numSoLuong.Value == 0)
                MessageBox.Show("Số lượng sản phẩm phải lơn hơn 0", "Thông báo");
            else
            {
                Product sanPham = new Product();
                sanPham.ProductName = txtTenSanPham.Text.Trim();
                sanPham.UnitPrice = decimal.Parse(txtDonGia.Text);
                sanPham.UnitsInStock = short.Parse(numSoLuong.Value.ToString());
                sanPham.SupplierID = short.Parse(cbNhaCungCap.SelectedValue.ToString());
                sanPham.CategoryID = int.Parse(cbLoaiSanPham.SelectedValue.ToString());
                if (busSanPham.ThemSanPham(sanPham))
                {
                    CapNhat();
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm", "Thông báo");
            }    
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text == "" || txtDonGia.Text == ""
                || cbLoaiSanPham.Text == "" || cbNhaCungCap.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            else if (numSoLuong.Value == 0)
                MessageBox.Show("Số lượng sản phẩm phải lơn hơn 0", "Thông báo");
            else
            {
                Product sanPham = new Product();
                sanPham.ProductID = int.Parse(dtgvSanPham.CurrentRow.Cells["ProductID"].Value.ToString());
                sanPham.ProductName = txtTenSanPham.Text.Trim();
                sanPham.UnitPrice = decimal.Parse(txtDonGia.Text);
                sanPham.UnitsInStock = short.Parse(numSoLuong.Value.ToString());
                sanPham.SupplierID = short.Parse(cbNhaCungCap.SelectedValue.ToString());
                sanPham.CategoryID = int.Parse(cbLoaiSanPham.SelectedValue.ToString());
                if (busSanPham.SuaSanPham(sanPham))
                {
                    CapNhat();
                    MessageBox.Show("Sửa sản phẩm thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi khi sửa sản phẩm", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo");
            else
            {
                if(MessageBox.Show("Bạn có muốn xóa sản phẩm đã chọn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Product sanPham = new Product();
                    sanPham.ProductID = int.Parse(dtgvSanPham.CurrentRow.Cells["ProductID"].Value.ToString());
                    if (busSanPham.XoaSanPham(sanPham))
                    {
                        CapNhat();
                        MessageBox.Show("Xóa sản phẩm thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sản phẩm", "Thông báo");
                }
            }    
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
