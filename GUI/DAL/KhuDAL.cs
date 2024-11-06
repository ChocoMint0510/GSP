using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhuDAL
    {
        //private DataConnect dataConnect;

        //public KhuDAL()
        //{
        //    dataConnect = new DataConnect();
        //}

        //public List<KhuDTO> HienThiKhu()
        //{
        //    List<KhuDTO> khuList = new List<KhuDTO>();

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_HienThiKhu", dataConnect.conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        dataConnect.openConnection();

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            KhuDTO khu = new KhuDTO
        //            {
        //                IDKhu = reader["IDKhu"].ToString(),
        //                TenKhu = reader["TenKhu"].ToString(),
        //                GhiChu = reader["GhiChu"].ToString(),
        //            };
        //            khuList.Add(khu);
        //        }

        //        reader.Close();
        //        dataConnect.closeConnection();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi khi gọi thủ tục sp_HienThiKhu: " + ex.Message);
        //    }

        //    return khuList;
        //}

        private DataConnect dataConnect;

        public KhuDAL()
        {
            dataConnect = new DataConnect();
        }

        // Phương thức lấy danh sách Khu theo IDKho
        public List<KhuDTO> GetKhuByIDKho(string idKho)
        {
            List<KhuDTO> khuList = new List<KhuDTO>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_HienThiKhuTheoIDKho", dataConnect.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu vào cho thủ tục
                cmd.Parameters.AddWithValue("@IDKho", idKho);

                // Mở kết nối
                dataConnect.openConnection();

                // Thực thi lệnh và đọc dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();

                // Kiểm tra nếu có dữ liệu trả về
                while (reader.Read())
                {
                    KhuDTO khu = new KhuDTO
                    {
                        IDKhu = reader["IDKhu"].ToString(),
                        TenKhu = reader["TenKhu"].ToString(),
                        GhiChu = reader["GhiChu"].ToString(),
                    };
                    khuList.Add(khu);
                }

                // Đóng SqlDataReader
                reader.Close();
            }
            finally
            {
                // Đảm bảo đóng kết nối trong mọi trường hợp
                dataConnect.closeConnection();
            }

            // Trả về danh sách khu (có thể trống nếu không có kết quả)
            return khuList;
        }



    }
}
