using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuocDAL
    {
        private DataConnect dataConnect;

        // Khởi tạo lớp DataConnect với username và password
        public ThuocDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }
        public DataTable GetThuocIDVaTen()
        {
            try
            {
                // Gọi thủ tục lưu trữ "sp_HienThiIDVaTenThuoc"
                return dataConnect.GetData("sp_GetThuocInfo", null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gọi thủ tục lưu trữ: " + ex.Message);
                return null;
            }
        }
    }
}
