// DAL/UserDAL.cs
using DTO;
using System.Data;
using System;
using System.Data.SqlClient;

namespace DAL // Thêm namespace cho lớp DAL
{
    public class UserDAL
    {
        public string connectionString = "Data Source=LAPTOP-NITRO5;Initial Catalog=QuanLyGSP;Integrated Security=True";


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
        // Thêm phương thức này vào UserDAL.cs
        public int AddUserWithProcedure(UserDTO user, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AddNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenNhanVien", user.TenNhanVien);
                cmd.Parameters.AddWithValue("@IDChucVu", user.ChucVuID);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlParameter returnParameter = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return (int)returnParameter.Value;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi khi thêm người dùng: " + ex.Message);
                    return -2; // Một mã lỗi khác cho các lỗi SQL khác
                }
            }
        }




    }
}
