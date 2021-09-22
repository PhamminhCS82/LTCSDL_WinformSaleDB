using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTCSDL.DAO
{
    class DAO_KhachHang
    {
        private LaptopPCSaleDBEntities db;

        public DAO_KhachHang()
        {
            db = new LaptopPCSaleDBEntities();
        }

        public dynamic LayDSKhachHang()
        {
            var query = db.Customers.Select(p => new
            {
                p.CustomerID,
                p.ContactName,
                p.CompanyName,
                p.Phone,
                p.Address,
            }).ToList();
            return query;
        }
    }
}
