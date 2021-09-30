using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTCSDL.DAO
{

    class DAO_QuanLy
    {
        private LaptopPCSaleDBEntities db;
        public DAO_QuanLy()
        {
            db = new LaptopPCSaleDBEntities();
        }
        public bool KTDangNhap(User u)
        {
            int? check;
            check = db.user_KTDangNhap(u.Username, u.Password).FirstOrDefault();
            if (check != 0)
                return true;

            return false;
        }
    }
}
