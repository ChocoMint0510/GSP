using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class UserDAL
    {
        private DataConnect dataConnect;

        // Khởi tạo UserDAL với thông tin đăng nhập động
        public UserDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public UserDTO GetUserByUsername(string username)
        {
            string query = "SELECT * FROM NhanVien WHERE Username = @Username";
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            DataTable result = dataConnect.GetData(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new UserDTO(
                    row["IDNhanVien"].ToString(),
                    row["TenNhanVien"].ToString(),
                    row["IDChucVu"].ToString(),
                    row["Username"].ToString()
                );
            }
            return null;
        }

        public int AddUserWithProcedure(UserDTO user, string password)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@TenNhanVien", user.TenNhanVien),
                new SqlParameter("@IDChucVu", user.ChucVuID),
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", password)
            };
            return dataConnect.ExecuteStoredProcedure("sp_AddNhanVien", parameters);
        }

        public bool CheckDuplicateUsernameOrLogin(string username)
        {
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            int result = dataConnect.ExecuteStoredProcedure("sp_CheckDuplicateUsernameOrLogin", parameters);
            return result == -1 || result == -2;
        }

        public bool DeleteUser(string maNhanVien, string username)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@Username", username)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_DeleteNhanVien", parameters);
                return result == 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa nhân viên: " + ex.Message);
                return false;
            }
        }
    }
}
