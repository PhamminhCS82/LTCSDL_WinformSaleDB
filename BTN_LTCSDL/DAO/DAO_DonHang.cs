using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTCSDL.DAO
{
    class DAO_DonHang
    {
        private LaptopPCSaleDBEntities db;
        public DAO_DonHang()
        {
            db = new LaptopPCSaleDBEntities();
        }
        public dynamic layDSDH()
        {
            var ds = db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                s.Employee.FirstName,
                s.Customer.CompanyName
            }).ToList();
            return ds;
        }

        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.LastName
            }).ToList();
            return ds;
        }
        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(s => new
            {
                s.CustomerID,
                s.CompanyName
            }).ToList();
            return ds;
        }
        public void ThemDonHang(Order d)
        {
            db.Orders.Add(d);
            db.SaveChanges();
        }
        public bool KiemTraDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            if (o != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SuaDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            o.OrderDate = d.OrderDate;
            o.CustomerID = d.CustomerID;
            o.EmployeeID = d.EmployeeID;
            db.SaveChanges();
        }
        public void XoaDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            db.Orders.Remove(o);
            db.SaveChanges();
        }
        public dynamic DSCTDH(int maDH)
        {
            var ds = db.OrderDetails.Where(s => s.OrderID == maDH)
                .Select(s => new
                {
                    s.OrderID,
                    s.Product.ProductName,
                    s.UnitPrice,
                    s.Quantity
                }).ToList();
            return ds;
        }
        //public bool KiemTraSPDonHang(OrderDetail d)
        //{
        //    int? sl;
        //    sl = db.sp_KiemTraSPDonHang(d.OrderID, d.ProductID).FirstOrDefault();
        //    if (sl != 0)
        //        return false;
        //    return true;
        //}
        public void ThemCTDH(OrderDetail d)
        {

            db.OrderDetails.Add(d);
            db.SaveChanges();
        }
        //public void XoaCTDH(Product p)
        //{
        //    OrderDetail o = db.OrderDetails.Find(.OrderID);
        //    db.Order_Details.Remove()
        //}
    }
}
