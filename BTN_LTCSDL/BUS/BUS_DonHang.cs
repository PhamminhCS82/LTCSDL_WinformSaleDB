using BTN_LTCSDL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_LTCSDL.BUS
{
    
    class BUS_DonHang
    {
        DAO_DonHang dDH;
        public BUS_DonHang()
        {
            dDH = new DAO_DonHang();
        }
        public void HienThiDSDonHang(DataGridView dg)
        {
            dg.DataSource = dDH.LayDSDH();
        }
        public void HienThiDSCTDonHang(DataGridView dg, int maDH)
        {
            dg.DataSource = dDH.DSCTDH(maDH);
        }
        public void layDSNhanVien(ComboBox cbx)
        {
            cbx.DataSource = dDH.LayDSNV();
            cbx.DisplayMember = "FirstName";
            cbx.ValueMember = "EmployeeID";
        }
        public void layDSKhachHang(ComboBox cbx)
        {
            cbx.DataSource = dDH.LayDSKH();
            cbx.DisplayMember = "CompanyName";
            cbx.ValueMember = "CustomerID";
        }

        public bool TaoDonHang(Order d)
        {
            try
            {
                dDH.ThemDonHang(d);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool TaoCTDonHang(OrderDetail d)
        {
            try
            {
                dDH.ThemCTDH(d);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaDonHang(Order d)
        {
            if (dDH.KiemTraDH(d))
            {
                try
                {
                    dDH.SuaDH(d);
                    MessageBox.Show("Sửa thành công");
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool XoaDonHang(Order d)
        {
            if (dDH.KiemTraDH(d))
            {
                try
                {
                    dDH.XoaDH(d);
                    MessageBox.Show("Xóa thành công");
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool ThemCTDH(OrderDetail d)
        {
            try
            {
                dDH.ThemCTDH(d);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
