using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuBLL
    {
        private KhuDAL khuDAL;

        public KhuBLL()
        {
            khuDAL = new KhuDAL();
        }

        // Phương thức lấy danh sách Khu theo IDKho với xử lý nghiệp vụ
        public List<KhuDTO> GetKhuByIDKho(string idKho)
        {
            // Kiểm tra giá trị đầu vào
            if (string.IsNullOrEmpty(idKho))
            {
                // Nếu idKho là null hoặc rỗng, trả về danh sách trống
                return new List<KhuDTO>();
            }

            // Gọi phương thức từ KhuDAL để lấy dữ liệu
            List<KhuDTO> khuList = khuDAL.GetKhuByIDKho(idKho);

            // Nếu không có kết quả, trả về danh sách trống
            return khuList ?? new List<KhuDTO>();
        }

    }
}
