using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        private DataConnect dataConnect;

        public NhaCungCapDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        // Hàm lấy danh sách tên nhà cung cấp từ stored procedure
        public Dictionary<string, string> GetAllTenNhaCC()
        {
            Dictionary<string, string> nhaCCList = new Dictionary<string, string>();

            try
            {
                string storedProcedure = "sp_GetIDAndTenNhaCC";
                DataTable dt = dataConnect.GetData(storedProcedure); // Gọi stored procedure

                foreach (DataRow row in dt.Rows)
                {
                    string idNhaCC = row["IDNhaCC"].ToString();
                    string tenNhaCC = row["TenNhaCC"].ToString();
                    nhaCCList.Add(idNhaCC, tenNhaCC);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tên nhà cung cấp: " + ex.Message);
            }

            return nhaCCList;
        }
    }
}
