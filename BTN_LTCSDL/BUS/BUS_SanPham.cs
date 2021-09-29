using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTN_LTCSDL.DAO;
using System.Windows.Forms;

namespace BTN_LTCSDL.BUS
{
    class BUS_SanPham
    {
        private DAO_SanPham daoSanPham;

        public BUS_SanPham()
        {
            daoSanPham = new DAO_SanPham();
        }

        public void HienThiDSSanPham(DataGridView dtgv)
        {
            dtgv.DataSource = daoSanPham.LayDSSanPham();
        }

        public void HienThiDSLoaiSanPham(ComboBox cb)
        {
            cb.DataSource = daoSanPham.LayDSLoaiSanPham();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryID";
        }

        public void HienThiDSNhaCungCap(ComboBox cb)
        {
            cb.DataSource = daoSanPham.LayDSNhaCungCap();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "SupplierID";
        }

        public bool ThemSanPham(Product sanPham)
        {
            try
            {
                daoSanPham.ThemSanPham(sanPham);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaSanPham(Product sanPham)
        {
            try
            {
                daoSanPham.XoaSanPham(sanPham);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaSanPham(Product sanPham)
        {
            try
            {
                daoSanPham.SuaSanPham(sanPham);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Product LaySP(int maSP)
        {
            return daoSanPham.LaySP(maSP);
        }
    }
}
