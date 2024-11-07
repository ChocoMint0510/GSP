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

        public KhoBLL(string username, string password)
        {
            khoDAL = new KhoDAL(username, password);
        }

        // Lấy tất cả kho
        public List<KhoDTO> GetAllKho()
        {
            try
            {
                return khoDAL.GetAllKho();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách kho: " + ex.Message);
            }
        }

        // Thêm kho
        public void ThemKho(KhoDTO kho)
        {
            try
            {
                ValidateKho(kho);
                khoDAL.ThemKho(kho);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm kho: " + ex.Message);
            }
        }

        // Sửa kho
        public void SuaKho(KhoDTO kho)
        {
            try
            {
                ValidateKho(kho);

                khoDAL.SuaKho(kho);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa kho: " + ex.Message);
            }
        }

        // Xóa kho
        public void XoaKho(string idKho)
        {
            try
            {
                if (string.IsNullOrEmpty(idKho))
                {
                    throw new Exception("Chưa chọn IDKho.");
                }

                khoDAL.XoaKho(idKho);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa kho: " + ex.Message);
            }
        }

        // Kiểm tra dữ liệu kho trước khi thực hiện thêm hoặc sửa
        private void ValidateKho(KhoDTO kho)
        {
            if (string.IsNullOrEmpty(kho.LoaiKho))
            {
                throw new Exception("Loại kho không được để trống.");
            }
        }
        //Hiển thị Loại kho
        public Dictionary<string, string> GetAllLoaiKho()
        {
            try
            {
                return khoDAL.GetAllLoaiKho();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách Loại Kho: " + ex.Message);
            }
        }
    }
}
