using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTN_LTCSDL.DAO;
namespace BTN_LTCSDL.BUS
{
    class BUS_QuanLy
    {
        DAO_QuanLy dQuanLy;
        public BUS_QuanLy()
        {
            dQuanLy = new DAO_QuanLy();
        }
        public bool KTDangNhap(User u) 
        {
            return dQuanLy.KTDangNhap(u); 
        }
    }
}
