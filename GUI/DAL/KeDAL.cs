using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KeDAL
    {
        private DataConnect dataConnect;

        public KeDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public DataTable HienThiThongTinKeTheoIDKhu(string idKhu)
        {
            try
            {
                // Tạo danh sách tham số cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDKhu", SqlDbType.NVarChar) { Value = idKhu }
                };

                // Gọi stored procedure và lấy kết quả
                return dataConnect.ExecuteStoredProcedureWithDataSet("sp_HienThiThongTinKeTheoIDKhu", parameters).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị thông tin kệ theo IDKhu: " + ex.Message);
            }
        }
    }
}
