using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuBLL
    {
        private KhuDAL khuDAL;

        public KhuBLL(string username, string password)
        {
            khuDAL = new KhuDAL(username, password);
        }

        //Lấy thông tin khu
        public DataTable GetAllKhu()
        {
            return khuDAL.GetAllKhu();
        }

        //Thêm khu
        public bool ThemKhu(string tenKhu, string ghiChu, string idKho)
        {
            return khuDAL.ThemKhu(tenKhu, ghiChu, idKho) > 0;
        }



    }
}
