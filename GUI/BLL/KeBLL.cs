using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KeBLL
    {
        private KeDAL keDAL;

        public KeBLL(string username, string password)
        {
            keDAL = new KeDAL(username, password);
        }

        public DataTable HienThiThongTinKeTheoIDKhu(string idKhu)
        {

                return keDAL.HienThiThongTinKeTheoIDKhu(idKhu);

        }
    }
}
