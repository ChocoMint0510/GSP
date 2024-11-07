using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoDAL
    {
        private DataConnect dataConnect;

        public KhoDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        //Hiển thị ds Kho
        public List<KhoDTO> GetAllKho()
        {
            List<KhoDTO> khoList = new List<KhoDTO>();

            try
            {
                DataTable dt = dataConnect.GetData("sp_GetAllKho");

                foreach (DataRow row in dt.Rows)
                {
                    KhoDTO kho = new KhoDTO
                    {
                        IDKho = row["IDKho"].ToString(),
                        LoaiKho = row["LoaiKho"].ToString(),
                        GhiChu = row["GhiChu"].ToString()
                    };
                    khoList.Add(kho);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu từ stored procedure sp_GetAllKho: " + ex.Message);
            }

            return khoList;
        }

        // Thêm kho
        public void ThemKho(KhoDTO kho)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@LoaiKho", kho.LoaiKho),
                new SqlParameter("@GhiChu", kho.GhiChu)
            };

            try
            {
                dataConnect.ExecuteStoredProcedure("ThemKho", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm kho: " + ex.Message);
            }
        }

        // Sửa kho
        public void SuaKho(KhoDTO kho)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDKho", kho.IDKho),
                new SqlParameter("@LoaiKho", kho.LoaiKho ?? (object)DBNull.Value),
                new SqlParameter("@GhiChu", kho.GhiChu ?? (object)DBNull.Value)
            };

            try
            {
                dataConnect.ExecuteStoredProcedure("SuaKho", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa kho: " + ex.Message);
            }
        }

        // Xóa kho
        public void XoaKho(string idKho)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDKho", idKho)
            };

            try
            {
                dataConnect.ExecuteStoredProcedure("XoaKho", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa kho: " + ex.Message);
            }
        }

        //Lấy idKho và LoaiKho
        public Dictionary<string, string> GetAllLoaiKho()
        {
            Dictionary<string, string> loaiKhoList = new Dictionary<string, string>();

            try
            {
                DataTable dataTable = dataConnect.GetData("sp_GetLoaiKhoAndIDKho");

                foreach (DataRow row in dataTable.Rows)
                {
                    string idKho = row["IDKho"].ToString();
                    string loaiKho = row["LoaiKho"].ToString();
                    loaiKhoList.Add(idKho, loaiKho);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gọi stored procedure sp_GetLoaiKhoAndIDKho: " + ex.Message);
            }

            return loaiKhoList;
        }
    }
}
