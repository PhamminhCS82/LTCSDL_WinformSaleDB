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
using BTN_LTCSDL.Report;

namespace BTN_LTCSDL
{
    public partial class FCTDonHang : Form
    {
        public int maDH = 0;
        BUS_DonHang bDH;
        BUS_SanPham busSanPham;
        bool flag = false;
        private Product p;
        private int slConLai = 0;
        public FCTDonHang()
        {
            InitializeComponent();
            bDH = new BUS_DonHang();
        }
        private void layDSChiTietDH(int ma)
        {
            gVCTDH.DataSource = null;
            bDH.HienThiDSCTDonHang(gVCTDH, ma);
            gVCTDH.Columns[0].Width = (int)(gVCTDH.Width * 0.20);
            gVCTDH.Columns[1].Width = (int)(gVCTDH.Width * 0.25);
            gVCTDH.Columns[2].Width = (int)(gVCTDH.Width * 0.25);
            gVCTDH.Columns[3].Width = (int)(gVCTDH.Width * 0.25);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(numericUpDownSLSP.Value > 0) 
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderID = maDH;
                orderDetail.ProductID = Int32.Parse(cbSanPham.SelectedValue.ToString());
                orderDetail.Quantity = (short)numericUpDownSLSP.Value;
                orderDetail.UnitPrice = decimal.Parse(txtDonGia.Text);
                if (bDH.ThemCTDH(orderDetail))
                    MessageBox.Show("Thêm Thành công");
                else
                    MessageBox.Show("Thêm thất bại mời kiểm tra lại");
                layDSChiTietDH(maDH);
                txtSoLuongConLai.Text = p.UnitsInStock.ToString();
            }
            else
            {
                MessageBox.Show("Hết hàng");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.OrderID = maDH;
            orderDetail.ProductID = Int32.Parse(cbSanPham.SelectedValue.ToString());
            if (bDH.XoaCTDonHang(orderDetail))
            {
                MessageBox.Show("Xóa thành công");
                layDSChiTietDH(maDH);
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.OrderID = maDH;
            orderDetail.ProductID = Int32.Parse(cbSanPham.SelectedValue.ToString());
            orderDetail.Quantity = (short)numericUpDownSLSP.Value;
            orderDetail.UnitPrice = decimal.Parse(txtDonGia.Text);
            if (bDH.SuaCTDonHang(orderDetail) && orderDetail.Quantity > 0)
            {
                MessageBox.Show("Sửa thành công");
                layDSChiTietDH(maDH);
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FCTDonHang_Load(object sender, EventArgs e)
        {
            busSanPham = new BUS_SanPham();
            layDSChiTietDH(maDH);
            busSanPham.HienThiDSSanPham(cbSanPham);
            txtMaDH.Text = maDH.ToString();
            flag = true;
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                cbSanPham.Text = gVCTDH.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                numericUpDownSLSP.Value = Int32.Parse(gVCTDH.Rows[e.RowIndex].
                    Cells["Quantity"].Value.ToString());
            }
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                p = busSanPham.LaySP(Convert.ToInt32(cbSanPham.SelectedValue));
                txtDonGia.Text = (p.UnitPrice * numericUpDownSLSP.Value).ToString();
                txtSoLuongConLai.Text = p.UnitsInStock.ToString();
                slConLai = (int)p.UnitsInStock;
            }
        }

        private void numericUpDownSLSP_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSLSP.Value >= slConLai)
                numericUpDownSLSP.Value = slConLai;
            if (flag)
            {
                p = busSanPham.LaySP(Convert.ToInt32(cbSanPham.SelectedValue));
                txtDonGia.Text = (p.UnitPrice * numericUpDownSLSP.Value).ToString();
                txtSoLuongConLai.Text = p.UnitsInStock.ToString();
                
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportCTDH report = new ReportCTDH();
            FReport f = new FReport();
            bDH.HienThiDSCTDonHang(report);
            f.FReportViewer.ReportSource = report;
            f.Show();
        }
    }
}
