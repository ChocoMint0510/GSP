using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuocBLL
    {
        private ThuocDAL thuocDAL;

        // Khởi tạo đối tượng ThuocDAL
        public ThuocBLL(string username, string password)
        {
            thuocDAL = new ThuocDAL(username, password);
        }

        // Lấy danh sách IDThuoc và TenThuoc
        public DataTable GetThuocInfo()
        {
            try
            {
                // Gọi phương thức từ ThuocDAL để lấy dữ liệu
                return thuocDAL.GetThuocIDVaTen();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách thuốc: " + ex.Message);
                return null;
            }
        }
    }
}
