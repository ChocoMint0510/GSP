using System;
using System.Collections.Generic;
using System.Data;
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

        // 1. Lấy danh sách phiếu nhập
        public DataTable HienThiPhieuNhap()
        {
            return nhapKhoDAL.HienThiPhieuNhap();
        }


        // 2. Lấy chi tiết phiếu nhập theo IDPhieuNhap
        public DataTable LayChiTietPhieuNhap(string idPhieuNhap)
        {
           
                return nhapKhoDAL.LayChiTietPhieuNhap(idPhieuNhap);
            
        }



        public DataSet LayThongTinPhieuNhapTheoID(string idPhieuNhap)
        {
          
                return nhapKhoDAL.LayThongTinPhieuNhapTheoID(idPhieuNhap);
            
        }
    }
}
