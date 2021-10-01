using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTCSDL.DAO
{
    class DAO_SanPham
    {
        private LaptopPCSaleDBEntities db;

        public DAO_SanPham()
        {
            db = new LaptopPCSaleDBEntities();
        }

        public dynamic LayDSSanPham()
        {
            var query = db.Products.Select(p => new
            {
                p.ProductID,
                p.ProductName,
                p.UnitPrice,
                p.UnitsInStock,
                p.Category.CategoryName,
                p.Supplier.CompanyName,
                p.UnitsOnOrder
            }).ToList();
            return query;
        }

        public dynamic LayDSLoaiSanPham()
        {
            var query = db.Categories.Select(p => new
            {
                p.CategoryID,
                p.CategoryName
            }).ToList();
            return query;
        }

        public dynamic LayDSNhaCungCap()
        {
            var query = db.Suppliers.Select(p => new
            {
                p.SupplierID,
                p.CompanyName
            }).ToList();
            return query;
        }

        public void ThemSanPham(Product sanPham)
        {
            db.Products.Add(sanPham);
            db.SaveChanges();
        }

        public bool XoaSanPham(Product sanPham)
        {
            try
            {
                Product product = db.Products.Where(p => p.ProductID == sanPham.ProductID).First();
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool SuaSanPham(Product sanPham)
        {
            try
            {
                Product product = db.Products.Where(p => p.ProductID == sanPham.ProductID).First();
                product.ProductName = sanPham.ProductName;
                product.UnitPrice = sanPham.UnitPrice;
                product.UnitsInStock = sanPham.UnitsInStock;
                product.CategoryID = sanPham.CategoryID;
                product.SupplierID = sanPham.SupplierID;
                product.UnitsOnOrder = sanPham.UnitsOnOrder;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Product LaySP(int maSP) 
        {
            Product product = db.Products.
                Where(p => p.ProductID == maSP).First();
            return product;
        }

        public List<Product> LayDSSanPhamReport()
        {
            var danhSach = db.Products.Select(s => s).ToList();
            return danhSach;
        }
    }
}
