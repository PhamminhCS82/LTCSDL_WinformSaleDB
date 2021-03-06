using BTN_LTCSDL.BUS;
using BTN_LTCSDL.Report;
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
            dtgvDonHang.Columns[0].Width = (int)(dtgvDonHang.Width * 0.1);
            dtgvDonHang.Columns[1].Width = (int)(dtgvDonHang.Width * 0.2);
            dtgvDonHang.Columns[2].Width = (int)(dtgvDonHang.Width * 0.2);
            dtgvDonHang.Columns[3].Width = (int)(dtgvDonHang.Width * 0.2);
            dtgvDonHang.Columns[4].Width = (int)(dtgvDonHang.Width * 0.25);
        }
        private void FDonHang_Load(object sender, EventArgs e)
        {
            HienThiDSDonHang();
            busDH.layDSKhachHang(cbKhachHang);
            busDH.layDSNhanVien(cbNhanVien);
            //Không cho nhập ở combobox
            cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            dtgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Tạo đơn hàng mới
        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbKhachHang.Text == "" || cbNhanVien.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            else if (dtpNgayDatHang.Value > DateTime.Now)
                MessageBox.Show("Ngày đặt hàng không hợp lệ", "Thông báo");
            else
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
        private void dtgvDonHang_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(dtgvDonHang.CurrentRow.Cells[0].Value.ToString());
            FCTDonHang f = new FCTDonHang();
            f.maDH = ma;
            f.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbKhachHang.Text == "" || cbNhanVien.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            else if (dtpNgayDatHang.Value > DateTime.Now)
                MessageBox.Show("Ngày đặt hàng không hợp lệ", "Thông báo");
            else
            {
                Order d = new Order();
                d.OrderID = int.Parse(txtMaDonHang.Text);
                d.OrderDate = dtpNgayDatHang.Value;
                d.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
                d.CustomerID = int.Parse(cbKhachHang.SelectedValue.ToString());
                if (busDH.SuaDonHang(d))
                {
                    MessageBox.Show("Sửa đơn hàng thành công");
                    busDH.HienThiDSDonHang(dtgvDonHang);
                }
                else
                    MessageBox.Show("Sửa đơn hàng thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDonHang.Text == "")
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa", "Thông báo");
            else
            {
                if(MessageBox.Show("Bạn có muốn xóa đơn hàng này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Order d = new Order();
                    d.OrderID = int.Parse(txtMaDonHang.Text);

                    if (busDH.XoaDonHang(d))
                    {
                        MessageBox.Show("Hủy đơn hàng thành công");
                        busDH.HienThiDSDonHang(dtgvDonHang);
                    }
                    else
                        MessageBox.Show("Hủy đơn hàng thất bại");
                }    
            }    
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportDH report = new ReportDH();
            FReport f = new FReport();
            busDH.HienThiDSDonHang(report);
            f.FReportViewer.ReportSource = report;
            f.Show();
        }
    }
}
