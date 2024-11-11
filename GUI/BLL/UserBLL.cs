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
            dataConnect = new DataConnect(username, password);
        }

        public DataTable GetChucVuList()
        {
            return userDAL.GetChucVuList();
        }

        public bool Login()
        {
            return dataConnect.CheckConnection();
        }
        public UserDTO GetUserByUsername(string username)
        {
            return userDAL.GetUserByUsername(username); // Giả sử userDAL có phương thức này
        }


        public DataTable GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }
        public DataTable GetAllNhanVienWithChucVu()
        {
            return userDAL.GetAllNhanVienWithChucVu();
        }

        public bool AddUser(string tenNhanVien, string chucVuID, string password, DateTime ngaySinh, string diaChi, string email, string soDienThoai, string trinhDo, byte[] anh)
        {
            UserDTO newUser = new UserDTO
            {
                TenNhanVien = tenNhanVien,
                ChucVuID = chucVuID,
                NgaySinh = ngaySinh,
                DiaChi = diaChi,
                Email = email,
                SoDienThoai = soDienThoai,
                TrinhDo = trinhDo,
                Anh = anh // Gán dữ liệu ảnh
            };

            int result = userDAL.AddUserWithProcedure(newUser, password);
            return result == 0;
        }


        // Phương thức mới để tạo mã nhân viên tự động
        public string GenerateNewMaNhanVien()
        {
            return userDAL.GenerateNewMaNhanVien();
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
        public bool UpdateNhanVien(UserDTO user)
        {
            return userDAL.UpdateNhanVien(user);
        }


    }
}
