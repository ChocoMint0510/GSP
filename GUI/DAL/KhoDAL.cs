using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoDAL
    {
        private DataConnect dataConnect;

        public KhoDAL()
        {
            dataConnect = new DataConnect();
        }

        // Lấy danh sách kho từ database
        public List<KhoDTO> GetAllKho()
        {
            List<KhoDTO> khoList = new List<KhoDTO>();

            try
            {
                SqlDataReader reader = dataConnect.GetData("Kho");

                while (reader.Read())
                {
                    KhoDTO kho = new KhoDTO
                    {
                        IDKho = reader["IDKho"].ToString(),
                        LoaiKho = reader["LoaiKho"].ToString(),
                        GhiChu = reader["GhiChu"].ToString()
                    };
                    khoList.Add(kho);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy dữ liệu từ bảng Kho", ex);
            }
            finally
            {
                dataConnect.closeConnection();
            }

            return khoList;
        }

        //Thêm kho
        public void ThemKho(KhoDTO kho)
        {
            using (SqlConnection conn = new SqlConnection(dataConnect.strConn))
            {
                using (SqlCommand cmd = new SqlCommand("ThemKho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào command
                    cmd.Parameters.AddWithValue("@LoaiKho", kho.LoaiKho); // Sử dụng TenKho cho LoaiKho
                    cmd.Parameters.AddWithValue("@GhiChu", kho.GhiChu);

                    try
                    {
                        conn.Open(); // Mở kết nối
                        cmd.ExecuteNonQuery(); // Thực thi stored procedure
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi thêm kho: " + ex.Message, ex);
                    }
                }
            }
        }
    }
}
