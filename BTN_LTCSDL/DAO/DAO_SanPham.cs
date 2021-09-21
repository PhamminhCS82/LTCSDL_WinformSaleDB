using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTCSDL.DAO
{
    
    class DAO_SanPham
    {
        LaptopPCSaleEntities db;
        public DAO_SanPham() 
        {
            db = new LaptopPCSaleDBEntities();
        }
        public dynamic LayDSSanPham()
        {
            var ds = db.Products.Select(s => new
            {
                s.ProductID,
                s.ProductName,
                s.UnitPrice,
                s.QuantityPerUnit,
                s.Supplier.CompanyName,
                s.Category.CategoryName
            }).ToList();
            return ds;
        }
    }
}
