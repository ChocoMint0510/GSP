﻿// DAL/UserDAL.cs
using DTO;
using System.Data.SqlClient;

namespace DAL // Thêm namespace cho lớp DAL
{
    public class UserDAL
    {
        public string connectionString = "Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;Integrated Security=True";

        // Hàm kiểm tra xem nhân viên có tồn tại dựa trên Username
        public UserDTO GetUserByUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new UserDTO(
                        reader["MaNhanVienID"].ToString(),
                        reader["TenNhanVien"].ToString(),
                        reader["ChucVuID"].ToString(),
                        reader["Username"].ToString()
                    );
                }
            }
            return null;
        }

        // Hàm thêm nhân viên mới
        public bool AddUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NhanVien (MaNhanVienID, TenNhanVien, ChucVuID, Username) VALUES (@MaNhanVienID, @TenNhanVien, @ChucVuID, @Username)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVienID", user.MaNhanVienID);
                cmd.Parameters.AddWithValue("@TenNhanVien", user.TenNhanVien);
                cmd.Parameters.AddWithValue("@ChucVuID", user.ChucVuID);
                cmd.Parameters.AddWithValue("@Username", user.Username);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Tạo login trong SQL Server
        public bool CreateSqlLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"CREATE LOGIN {username} WITH PASSWORD = '{password}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Gán quyền truy cập cho user trong SQL Server
        public bool GrantUserAccess(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"CREATE USER {username} FOR LOGIN {username};";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}