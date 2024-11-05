using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoBLL
    {
        private KhoDAL khoDAL;

        public KhoBLL()
        {
            khoDAL = new KhoDAL();
        }
        //Hiển thị danh sách Kho
        public List<KhoDTO> GetKhoList()
        {
            try
            {
                List<KhoDTO> khoList = khoDAL.GetAllKho();
                return khoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy xuất dữ liệu trong lớp BLL", ex);
            }
        }
        //Thêm kho
        public void ThemKho(KhoDTO kho)
        {
            if (string.IsNullOrWhiteSpace(kho.LoaiKho))
            {
                throw new Exception("Tên kho không được để trống.");
            }

            khoDAL.ThemKho(kho);
        }

        public List<KhoDTO> GetAllKho()
        {
            return khoDAL.GetAllKho();
        }
    }
}
