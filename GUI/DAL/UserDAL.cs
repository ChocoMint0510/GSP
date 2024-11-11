using System;
using System.Collections.Generic;
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

        // Lấy thông tin user bằng username
        public UserDTO GetUserByUsername(string username)
        {
            string query = "SELECT * FROM NhanVien WHERE Username = @Username";
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            DataTable result = dataConnect.GetData(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                byte[] anh = row["Anh"] != DBNull.Value ? (byte[])row["Anh"] : null; // Lấy dữ liệu ảnh nếu có, ngược lại để null

                return new UserDTO(
                    row["IDNhanVien"].ToString(),
                    row["TenNhanVien"].ToString(),
                    row["IDChucVu"].ToString(),
                    Convert.ToDateTime(row["NgaySinh"]),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString(),
                    row["SoDienThoai"].ToString(),
                    row["TrinhDo"].ToString(),
                    anh // Truyền dữ liệu ảnh vào constructor
                );
            }
            return null;
        }
        public DataTable GetAllNhanVienWithChucVu()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllNhanVienWithChucVu");
        }


        public string GenerateNewMaNhanVien()
        {
            string query = "SELECT MAX(IDNhanVien) AS LastID FROM NhanVien";
            DataTable result = dataConnect.GetData(query);

            if (result.Rows.Count > 0 && result.Rows[0]["LastID"] != DBNull.Value)
            {
                string lastID = result.Rows[0]["LastID"].ToString();
                int newIDNum = int.Parse(lastID.Substring(2)) + 1;
                return "NV" + newIDNum.ToString("D4"); // Tạo mã NVxxxx tự động
            }
            else
            {
                return "NV0001"; // Mã đầu tiên nếu chưa có nhân viên nào
            }
        }

        public DataTable GetChucVuList()
        {
            string query = "SELECT IDChucVu, TenChucVu FROM ChucVu";
            return dataConnect.GetData(query);
        }

        // Thêm user bằng stored procedure
        public int AddUserWithProcedure(UserDTO user, string password)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@TenNhanVien", user.TenNhanVien),
                new SqlParameter("@IDChucVu", user.ChucVuID),
                new SqlParameter("@Password", password),
                new SqlParameter("@NgaySinh", user.NgaySinh),
                new SqlParameter("@DiaChi", user.DiaChi),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@SoDienThoai", user.SoDienThoai),
                new SqlParameter("@TrinhDo", user.TrinhDo),
                new SqlParameter("@Anh", SqlDbType.VarBinary) { Value = (object)user.Anh ?? DBNull.Value } // Lưu ảnh đại diện
            };

            return dataConnect.ExecuteStoredProcedure("sp_AddNhanVien", parameters);
        }
        public DataTable GetAllUsers()
        {
            return dataConnect.GetData("sp_GetUserData", null);
        }
        // Kiểm tra trùng tên đăng nhập hoặc login
        public bool CheckDuplicateUsernameOrLogin(string username)
        {
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            int result = dataConnect.ExecuteStoredProcedure("sp_CheckDuplicateUsernameOrLogin", parameters);
            return result == -1 || result == -2;
        }

        // Xóa user bằng stored procedure
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
                Console.WriteLine($"Lỗi khi xóa nhân viên (Mã NV: {maNhanVien}, Username: {username}): {ex.Message}");
                return false;
            }
        }

        // Thay đổi mật khẩu user
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@OldPassword", oldPassword),
                new SqlParameter("@NewPassword", newPassword)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_ChangePassword", parameters);
                return result == 0; // Trả về true nếu đổi mật khẩu thành công, false nếu thất bại
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đổi mật khẩu: " + ex.Message);
                return false;
            }
        }
        public bool UpdatePassword(string username, string newPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@NewPassword", newPassword)
            };

            int result = dataConnect.ExecuteStoredProcedure("sp_UpdatePassword", parameters);
            return result == 0; // Trả về true nếu thành công
        }
        public bool DoiMatKhau(string username, string oldPassword, string newPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@OldPassword", oldPassword),
                new SqlParameter("@NewPassword", newPassword)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_DoiMatKhau", parameters);
                return result == 0; // Trả về true nếu đổi mật khẩu thành công, false nếu thất bại
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đổi mật khẩu: " + ex.Message);
                return false;
            }
        }

        //Hiển thị ID và tên Nhân viên
        public Dictionary<string, string> GetIDAndTenNhanVien()
        {
            Dictionary<string, string> tenNVList = new Dictionary<string, string>();

            try
            {
                DataTable dataTable = dataConnect.GetData("sp_HienThiIDVaTenNhanVien");

                foreach (DataRow row in dataTable.Rows)
                {
                    string idNhanVien= row["IDNhanVien"].ToString();
                    string tenNhanVien = row["TenNhanVien"].ToString();
                    tenNVList.Add(idNhanVien, tenNhanVien);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gọi stored procedure sp_HienThiIDVaTenNhanVien: " + ex.Message);
            }

            return tenNVList;
        }
        //Cập Nhật Nhân Viên
        public bool UpdateNhanVien(UserDTO user)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDNhanVien", user.MaNhanVienID),
                new SqlParameter("@TenNhanVien", user.TenNhanVien),
                new SqlParameter("@IDChucVu", user.ChucVuID),
                new SqlParameter("@NgaySinh", user.NgaySinh),
                new SqlParameter("@DiaChi", user.DiaChi),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@SoDienThoai", user.SoDienThoai),
                new SqlParameter("@TrinhDo", user.TrinhDo),
                new SqlParameter("@Anh", user.Anh)
            };

            int result = dataConnect.ExecuteStoredProcedureWithReturnValue("sp_UpdateNhanVien", parameters);
            return result >= 0; // Trả về true nếu cập nhật thành công
        }



    }
}
