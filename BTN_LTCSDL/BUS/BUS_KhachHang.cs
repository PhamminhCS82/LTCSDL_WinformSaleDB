using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTN_LTCSDL.DAO;
using System.Windows.Forms;

namespace BTN_LTCSDL.BUS
{
    class BUS_KhachHang
    {
        private DAO_KhachHang daoKhachHang;

        public BUS_KhachHang()
        {
            daoKhachHang = new DAO_KhachHang();
        }

        public void HienThiDSKhachHang(DataGridView dtgv)
        {
            dtgv.DataSource = daoKhachHang.LayDSKhachHang();
        }

        public bool ThemKhachHang(Customer khachHang)
        {
            try
            {
                daoKhachHang.ThemKhachHang(khachHang);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool XoaKhachHang(Customer khachHang)
        {
            try
            {
                daoKhachHang.XoaKhachHang(khachHang);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SuaKhachHang(Customer khachHang)
        {
            try
            {
                daoKhachHang.SuaKhachHang(khachHang);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Customer> HienThiDSKhachHangReport()
        {
            return daoKhachHang.LayDSKhachHangReport();
        }
    }
}
