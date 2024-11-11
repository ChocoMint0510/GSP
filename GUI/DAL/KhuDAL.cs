using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuDAL
    {
        private DataConnect dataConnect;

        public KhuDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        //Lấy thông tin khu
        public DataTable GetAllKhu()
        {
            try
            {
                
                return dataConnect.GetData("sp_HienThiKhu");
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching all Khu data: " + ex.Message);
            }
        }

        //Thêm khu
        public int ThemKhu(string tenKhu, string ghiChu, string idKho)
        {
            SqlParameter[] parameters = {
        new SqlParameter("@TenKhu", tenKhu),
        new SqlParameter("@GhiChu", ghiChu),
        new SqlParameter("@IDKho", idKho)
    };

            // Gọi stored procedure để thêm khu và trả về số dòng bị ảnh hưởng
            return dataConnect.ExecuteStoredProcedure("sp_ThemKhu", parameters);
        }




    }
}
