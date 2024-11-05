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
        private readonly NhapKhoDAL nhapKhoDAL = new NhapKhoDAL();

        public bool ThemPhieuNhap(NhapKhoDTO nhapKho)
        {
            // Kiểm tra dữ liệu đầu vào trước khi thực hiện thêm phiếu nhập
            //if (string.IsNullOrEmpty(nhapKho.IDKho))
            //{
            //    throw new ArgumentException("IDKho không được để trống.");
            //}
            //if (string.IsNullOrEmpty(nhapKho.IDNhanVien))
            //{
            //    throw new ArgumentException("IDNhanVien không được để trống.");
            //}
            if (nhapKho.GiaTriDonHang < 0)
            {
                throw new ArgumentException("Giá trị đơn hàng không được âm.");
            }

            // Gọi phương thức của NhapKhoDAL để thực hiện thêm phiếu nhập
            return nhapKhoDAL.ThemPhieuNhap(nhapKho);
        }
    }
}
