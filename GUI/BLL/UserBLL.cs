using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        public UserDAL userDAL = new UserDAL();

        // Đăng nhập bằng SQL Server login
        public bool Login(string username, string password)
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "LAPTOP-NITRO5";
            connStringBuilder.InitialCatalog = "QuanLyGSP";
            connStringBuilder.UserID = username;
            connStringBuilder.Password = password;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStringBuilder.ConnectionString))
                {
                    conn.Open();
                    return true; // Login thành công
                }
            }
            catch (SqlException)
            {
                return false; // Login thất bại
            }
        }
    }
}

