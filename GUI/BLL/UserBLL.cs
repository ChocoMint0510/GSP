using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class UserBLL
    {
        private readonly string _username;
        private readonly string _password;
        private UserDAL userDAL;
        private DataConnect dataConnect;
        // Khởi tạo UserBLL với thông tin đăng nhập
        public UserBLL(string username, string password)
        {
            _username = username;
            _password = password;
            userDAL = new UserDAL(_username, _password);
            userDAL = new UserDAL(username, password);
            dataConnect = new DataConnect(username, password);
        }
        public DataTable GetChucVuList()
        {
            return userDAL.GetChucVuList();
        }

        public bool Login()
        {
            DataConnect dataConnect = new DataConnect(_username, _password);
            return dataConnect.CheckConnection();
        }
        public DataTable GetAllUsers()
        {
            return userDAL.GetAllUsers();
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
        public bool UpdatePassword(string username, string newPassword)
        {
            return userDAL.UpdatePassword(username, newPassword);
        }

        public bool CheckDuplicateUsernameOrLogin(string username)
        {
            return userDAL.CheckDuplicateUsernameOrLogin(username);
        }

        public bool DeleteUser(string maNhanVien, string username)
        {
            return userDAL.DeleteUser(maNhanVien, username);
        }
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            try
            {
                return userDAL.ChangePassword(username, oldPassword, newPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đổi mật khẩu: " + ex.Message);
                return false;
            }
        }
        public bool DoiMatKhau(string username, string oldPassword, string newPassword)
        {
            return userDAL.DoiMatKhau(username, oldPassword, newPassword);
        }


        public Dictionary<string, string> GetIDAndTenNhanVien()
        {
            try
            {
                // Gọi phương thức từ lớp UserDAL
                return userDAL.GetIDAndTenNhanVien();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách ID và Tên Nhân Viên: " + ex.Message);
            }
        }

    }
}
