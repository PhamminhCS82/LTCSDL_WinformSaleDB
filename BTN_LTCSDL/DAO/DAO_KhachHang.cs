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

        public void ThemKhachHang(Customer khachHang)
        {
            db.Customers.Add(khachHang);
            db.SaveChanges();
        }

        public bool CoTonTaiKhachHang(Customer khachHang)
        {
            Customer customer = db.Customers.Find(khachHang.CustomerID);
            if (customer != null)
                return true;
            else
                return false;
        }

        public bool XoaKhachHang(Customer khachHang)
        {
            if (CoTonTaiKhachHang(khachHang))
            {
                Customer customer = db.Customers.Find(khachHang.CustomerID);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool SuaKhachHang(Customer khachHang)
        {
            if (CoTonTaiKhachHang(khachHang))
            {
                Customer customer = db.Customers.Find(khachHang.CustomerID);
                customer.CompanyName = khachHang.CompanyName;
                customer.ContactName = khachHang.ContactName;
                customer.Address = khachHang.Address;
                customer.Phone = khachHang.Phone;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
