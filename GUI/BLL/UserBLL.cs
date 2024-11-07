using System;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL userDAL;

        // Khởi tạo UserBLL với thông tin đăng nhập
        public UserBLL(string username, string password)
        {
            userDAL = new UserDAL(username, password);
        }

        public bool Login(string username, string password)
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "LAPTOP-NITRO5", // Đảm bảo tên máy chủ chính xác
                InitialCatalog = "QuanLyGSP",
                UserID = username,
                Password = password
            };

            try
            {
                using (SqlConnection conn = new SqlConnection(connStringBuilder.ConnectionString))
                {
                    conn.Open();
                    return true; // Đăng nhập thành công
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi khi đăng nhập: " + ex.Message);
                return false; // Đăng nhập thất bại
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
                MaNhanVienID = "", // ID sẽ tự động sinh
                TenNhanVien = tenNhanVien,
                ChucVuID = chucVuID,
                Username = username
            };

            int result = userDAL.AddUserWithProcedure(newUser, password);

            if (result == -1)
            {
                throw new InvalidOperationException("Tên login đã tồn tại. Vui lòng chọn tên khác.");
            }

            return result == 0;
        }

        public bool CheckDuplicateUsernameOrLogin(string username)
        {
            return userDAL.CheckDuplicateUsernameOrLogin(username);
        }

        public bool DeleteUser(string maNhanVien, string username)
        {
            return userDAL.DeleteUser(maNhanVien, username);
        }
    }
}
