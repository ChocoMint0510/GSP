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

        //Sửa kho
        public bool SuaKho(KhoDTO kho)
        {
            if (string.IsNullOrWhiteSpace(kho.IDKho))
            {
                throw new ArgumentException("IDKho không được để trống.");
            }

            if (kho.LoaiKho != null && kho.LoaiKho.Length > 255)
            {
                throw new ArgumentException("Tên Kho không được vượt quá 255 ký tự.");
            }

            if (kho.GhiChu != null && kho.GhiChu.Length > 255)
            {
                throw new ArgumentException("Ghi chú không được vượt quá 255 ký tự.");
            }

            try
            {
                khoDAL.SuaKho(kho);
                return true; 
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật kho trong lớp KhoBLL " + ex.Message, ex);
            }
        }
        //Xóa kho
        public bool XoaKho(string idKho)
        {
            if (string.IsNullOrWhiteSpace(idKho))
            {
                throw new ArgumentException("IDKho không được để trống.");
            }

            try
            {
                khoDAL.XoaKho(idKho);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa kho trong lớp BLL: " + ex.Message, ex);
            }
        }

        //Lấy tên kho teo ID kho
        public string GetLoaiKho(string IDKho)
        {
            try
            {
                return khoDAL.GetLoaiKhoByIDKho(IDKho);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong lớp BLL khi gọi DAL: " + ex.Message);
            }
        }
        //Lấy tất cả loại kho
        public Dictionary<string, string> GetAllLoaiKho()
        {
            return khoDAL.GetAllLoaiKho();
        }
    }
}
