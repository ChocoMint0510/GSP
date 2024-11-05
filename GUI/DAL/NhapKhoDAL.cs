using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhapKhoDAL
    {
        private readonly DataConnect dataConnect = new DataConnect();

        public bool ThemPhieuNhap(NhapKhoDTO nhapKho)
        {
            bool result = false;

            try
            {
                // Mở kết nối bằng lớp DataConnect
                dataConnect.openConnection();

                // Tạo SqlCommand và gán thủ tục cùng các tham số, sử dụng thuộc tính Connection của DataConnect
                using (SqlCommand cmd = new SqlCommand("ThemPhieuNhap", dataConnect.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Truyền tham số cho thủ tục
                    cmd.Parameters.AddWithValue("@NgayNhap", nhapKho.NgayNhap);
                    cmd.Parameters.AddWithValue("@IDKho", nhapKho.IDKho);
                    cmd.Parameters.AddWithValue("@IDNhanVien", nhapKho.IDNhanVien);
                    cmd.Parameters.AddWithValue("@GhiChu", nhapKho.GhiChu ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@GiaTriDonHang", nhapKho.GiaTriDonHang);

                    // Thực thi thủ tục
                    int rowsAffected = cmd.ExecuteNonQuery();
                    result = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ghi log nếu cần thiết)
                Console.WriteLine("Lỗi khi thêm phiếu nhập: " + ex.Message);
                result = false;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                dataConnect.closeConnection();
            }

            return result;
        }
    }
}
