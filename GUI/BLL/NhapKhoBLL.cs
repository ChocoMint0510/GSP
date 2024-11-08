using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhapKhoBLL
    {
        private  NhapKhoDAL nhapKhoDAL;

        public NhapKhoBLL(string username, string password)
        {
            nhapKhoDAL = new NhapKhoDAL(username, password);
        }

        public string ThemPhieuNhapVaChiTiet(
            DateTime ngayNhap,
            string idKho,
            string idNhaCC,
            string idNhanVien,
            string ghiChu,
            string trangThai,
            List<ChiTietNhapKhoDTO> chiTietPhieuNhap)
        {
            try
            {
                return nhapKhoDAL.ThemPhieuNhapVaChiTiet(
                    ngayNhap,
                    idKho,
                    idNhaCC,
                    idNhanVien,
                    ghiChu,
                    trangThai,
                    chiTietPhieuNhap
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong BLL khi thêm Phiếu Nhập: " + ex.Message);
            }
        }
    }
}
