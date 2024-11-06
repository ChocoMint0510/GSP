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

                    cmd.Parameters.AddWithValue("@LoaiKho", kho.LoaiKho);
                    cmd.Parameters.AddWithValue("@GhiChu", kho.GhiChu);

                    try
                    {
                        conn.Open(); 
                        cmd.ExecuteNonQuery(); 
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi thêm kho: " + ex.Message, ex);
                    }
                }
            }
        }
        //Sửa kho
        public void SuaKho(KhoDTO kho)
        {
            using (SqlConnection conn = new SqlConnection(dataConnect.strConn))
            {
                using (SqlCommand cmd = new SqlCommand("SuaKho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IDKho", kho.IDKho);
                    cmd.Parameters.AddWithValue("@LoaiKho", kho.LoaiKho ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@GhiChu", kho.GhiChu ?? (object)DBNull.Value);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi cập nhật kho: " + ex.Message, ex);
                    }
                }
            }
        }

        //Xóa kho
        public void XoaKho(string idKho)
        {
            using (SqlConnection conn = new SqlConnection(dataConnect.strConn))
            {
                using (SqlCommand cmd = new SqlCommand("XoaKho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKho", idKho);

                    try
                    {
                        conn.Open(); 
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi xóa kho: " + ex.Message, ex);
                    }
                }
            }
        }

        //Lấy tên kho theo ID kho
        public string GetLoaiKhoByIDKho(string IDKho)
        {
            string loaiKho = string.Empty;

            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetLoaiKhoByIDKho", dataConnect.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDKho", IDKho);

                dataConnect.openConnection();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    loaiKho = reader["LoaiKho"].ToString();
                }

                reader.Close();
                dataConnect.closeConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gọi thủ tục sp_GetLoaiKhoByIDKho: " + ex.Message);
            }

            return loaiKho;
        }

        //Lấy tất cả loại kho
        public Dictionary<string, string> GetAllLoaiKho()
        {
            Dictionary<string, string> loaiKhoList = new Dictionary<string, string>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllLoaiKho", dataConnect.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                dataConnect.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string idKho = reader["IDKho"].ToString();
                    string loaiKho = reader["LoaiKho"].ToString();
                    loaiKhoList.Add(idKho, loaiKho);
                }

                reader.Close();
                dataConnect.closeConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách LoaiKho: " + ex.Message);
            }

            return loaiKhoList;
        }

    }
}
