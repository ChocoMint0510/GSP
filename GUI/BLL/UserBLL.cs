using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class UserBLL
    {
        public UserDAL userDAL = new UserDAL();

        public bool Login(string username, string password)
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "NARIZMUSIC\\CHOCOPRO";
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
        public bool AddUser(string tenNhanVien, string chucVuID, string username, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                throw new ArgumentException("Mật khẩu và xác nhận mật khẩu không khớp.");
            }

            UserDTO newUser = new UserDTO
            {
                MaNhanVienID = "", // Giá trị này sẽ được sinh tự động trong stored procedure
                TenNhanVien = tenNhanVien,
                ChucVuID = chucVuID,
                Username = username
            };

            int result = userDAL.AddUserWithProcedure(newUser, password);

            if (result == -1)
            {
                throw new InvalidOperationException("Tên login đã tồn tại. Vui lòng chọn tên khác.");
            }

            return true;
        }



        // Phương thức kiểm tra trùng lặp Username hoặc Login
        public bool CheckDuplicateUsernameOrLogin(string username)
        {
            string connectionString = "Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_CheckDuplicateUsernameOrLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);

                SqlParameter returnParameter = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int result = (int)returnParameter.Value;

                    // Kiểm tra kết quả trả về từ stored procedure
                    return result == -1 || result == -2;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi khi kiểm tra trùng lặp: " + ex.Message);
                    return true; // Trả về true để an toàn trong trường hợp có lỗi SQL
                }
            }
        }

    }
}

