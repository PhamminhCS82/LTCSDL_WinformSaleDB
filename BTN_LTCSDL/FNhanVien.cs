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
    public partial class FNhanVien : Form
    {
        private BUS_NhanVien busNhanVien;

        public FNhanVien()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void CapNhat()
        {
            busNhanVien.HienThiDSNhanVien(dtgvNhanVien);
            dtgvNhanVien.Columns[4].Width = (int)(dtgvNhanVien.Width * 0.32);
            dtgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            CapNhat();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dtgvNhanVien.Rows.Count)
            {
                txtMaNhanVien.Text = dtgvNhanVien.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtHo.Text = dtgvNhanVien.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtTen.Text = dtgvNhanVien.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtDiaChi.Text = dtgvNhanVien.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtSoDienThoai.Text = dtgvNhanVien.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtHo.Text == "" || txtTen.Text == ""
                || txtSoDienThoai.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            else
            {
                Employee nhanVien = new Employee();
                nhanVien.Address = txtDiaChi.Text.Trim();
                nhanVien.FirstName = txtTen.Text.Trim();
                nhanVien.LastName = txtHo.Text.Trim();
                nhanVien.Phone = txtSoDienThoai.Text.Trim();
                if (busNhanVien.ThemNhanVien(nhanVien))
                {
                    CapNhat();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông báo");
            }    
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtHo.Text == "" || txtTen.Text == ""
                || txtSoDienThoai.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            else
            {
                Employee nhanVien = new Employee();
                nhanVien.EmployeeID = int.Parse(txtMaNhanVien.Text);
                nhanVien.Address = txtDiaChi.Text.Trim();
                nhanVien.FirstName = txtTen.Text.Trim();
                nhanVien.LastName = txtHo.Text.Trim();
                nhanVien.Phone = txtSoDienThoai.Text.Trim();
                if (busNhanVien.SuaNhanVien(nhanVien))
                {
                    CapNhat();
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Sửa nhân viên thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo");
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Employee nhanVien = new Employee();
                    nhanVien.EmployeeID = int.Parse(txtMaNhanVien.Text);
                    if (busNhanVien.XoaNhanVien(nhanVien))
                    {
                        CapNhat();
                        txtDiaChi.Text = "";
                        txtHo.Text = "";
                        txtMaNhanVien.Text = "";
                        txtSoDienThoai.Text = "";
                        txtTen.Text = "";
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Xóa nhân viên thất bại", "Thông báo");
                }
            }
        }
    }
}
