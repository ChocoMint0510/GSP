using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LuuTruDAL
    {
        private DataConnect dataConnect;

        public LuuTruDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public DataTable HienThiTatCaChiTietNhapKho()
        {
            try
            {
                return dataConnect.ExecuteStoredProcedureWithDataSet("sp_HienThiTatCaChiTietNhapKho").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị tất cả chi tiết nhập kho: " + ex.Message);
            }
        }
    }
}
