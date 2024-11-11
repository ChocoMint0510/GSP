using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LuuTruBLL
    {
        private LuuTruDAL luuTruDAL;

        public LuuTruBLL(string username, string password)
        {
            luuTruDAL = new LuuTruDAL(username, password);
        }

        public DataTable HienThiTatCaChiTietNhapKho()
        {

                return luuTruDAL.HienThiTatCaChiTietNhapKho();
        }
    }
}
