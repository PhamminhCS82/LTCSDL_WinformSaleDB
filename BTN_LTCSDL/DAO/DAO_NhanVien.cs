using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTCSDL.DAO
{
    class DAO_NhanVien
    {
        private LaptopPCSaleDBEntities db;

        public DAO_NhanVien()
        {
            db = new LaptopPCSaleDBEntities();
        }

        public dynamic LayDSNhanVien()
        {
            var query = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.FirstName,
                s.LastName,
                s.Phone,
                s.Address
            }).ToList();
            return query;
        }

        public void ThemNhanVien(Employee nhanVien)
        {
            db.Employees.Add(nhanVien);
            db.SaveChanges();
        }

        private bool CoTonTai(Employee nhanVien)
        {
            Employee employee = db.Employees.Find(nhanVien.EmployeeID);
            if (employee == null)
                return false;
            else
                return true;
        }

        public bool SuaNhanVien(Employee nhanVien)
        {
            if (CoTonTai(nhanVien))
            {
                Employee employee = db.Employees.Find(nhanVien.EmployeeID);
                employee.Address = nhanVien.Address;
                employee.FirstName = nhanVien.FirstName;
                employee.LastName = nhanVien.LastName;
                employee.Phone = nhanVien.Phone;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool XoaNhanVien(Employee nhanVien)
        {
            if (CoTonTai(nhanVien))
            {
                Employee employee = db.Employees.Find(nhanVien.EmployeeID);
                db.Employees.Remove(employee);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public List<Employee> LayDSNhanVienRp()
        {
            List<Employee> ds = db.Employees.Select(s => s).ToList();
            return ds;
        }
    }
}
