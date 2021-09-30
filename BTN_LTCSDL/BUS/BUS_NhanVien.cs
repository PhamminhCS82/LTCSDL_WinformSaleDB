using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTN_LTCSDL.DAO;
using System.Windows.Forms;

namespace BTN_LTCSDL.BUS
{
    class BUS_NhanVien
    {
        private DAO_NhanVien daoNhanVien;

        public BUS_NhanVien()
        {
            daoNhanVien = new DAO_NhanVien();
        }

        public void HienThiDSNhanVien(DataGridView dtgv)
        {
            try
            {
                dtgv.DataSource = daoNhanVien.LayDSNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ThemNhanVien(Employee nhanVien)
        {
            try
            {
                daoNhanVien.ThemNhanVien(nhanVien);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SuaNhanVien(Employee nhanVien)
        {
            try
            {
                daoNhanVien.SuaNhanVien(nhanVien);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool XoaNhanVien(Employee nhanVien)
        {
            try
            {
                daoNhanVien.XoaNhanVien(nhanVien);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
