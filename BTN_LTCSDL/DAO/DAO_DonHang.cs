using System;
using System.Collections.Generic;
using System.Data;
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
        //Lấy danh sách đơn hàng
        public dynamic LayDSDH()
        {
            var ds = db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                s.Employee.FirstName,
                s.Employee.LastName,
                s.Customer.CompanyName
            }).ToList();
            return ds;
        }
        //Lấy danh sách nhân viên
        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.LastName,
                s.FirstName
            }).ToList();
            return ds;
        }
        //Lấy danh sách khách hàng
        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(s => new
            {
                s.CustomerID,
                s.CompanyName
            }).ToList();
            return ds;
        }
        //Thêm 1 đơn hàng
        public void ThemDonHang(Order d)
        {
            db.Orders.Add(d);
            db.SaveChanges();
        }
        //Kiểm tra đơn hàng có tồn tại hay không
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
        //Sửa đơn hàng
        public void SuaDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            o.OrderDate = d.OrderDate;
            o.CustomerID = d.CustomerID;
            o.EmployeeID = d.EmployeeID;
            db.SaveChanges();
        }
        //Xóa đơn hàng
        public void XoaDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            db.Orders.Remove(o);
            db.SaveChanges();
        }
        //Lấy danh sách các sản phẩm trong đơn hàng
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

        //Thêm 1 sản phẩm vào đơn hàng
        public void ThemCTDH(OrderDetail d)
        {

            db.OrderDetails.Add(d);
            db.SaveChanges();
        }
        public bool KTCTDonHang(OrderDetail d)
        {
            int? check;
            check = db.orderDetail_KTCTDonHang(d.OrderID, d.ProductID).FirstOrDefault();
            if (check != 0)
                return true;

            return false;
        }
        //Xóa chi tiết 1 đơn hàng
        public void XoaCTDH(OrderDetail o)
        {
            db.Entry(o).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
        //Sửa chi tiết 1 đơn hàng
        public bool SuaCTDH(OrderDetail d)
        {
            OrderDetail o = new OrderDetail();
            o = db.OrderDetails.Single(s => s.OrderID == d.OrderID && s.ProductID == d.ProductID);
            if (o != null)
            {
                o.Quantity = d.Quantity;
                o.UnitPrice = d.UnitPrice;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public List<LayDSDonHang_Result> LayDSDHReport()
        {
            //Gọi store procedure lấy DS đơn hàng
            List <LayDSDonHang_Result> ds = db.LayDSDonHang().ToList();
            return ds;
        }
        public List<LayDSCTDonHang_Result> LayDSCTDHReport()
        {
            //Gọi store procedure lấy DS đơn hàng
            List<LayDSCTDonHang_Result> ds = db.LayDSCTDonHang().ToList();
            return ds;
        }
    }
}
