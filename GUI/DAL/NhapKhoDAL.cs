using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhapKhoDAL
    {
        private DataConnect dataConnect;

        public NhapKhoDAL(string username, string password)
        {
            // Khởi tạo kết nối với cơ sở dữ liệu
            dataConnect = new DataConnect(username, password);
        }

        //// Phương thức gọi thủ tục sp_ThemPhieuNhap
        //public string ThemPhieuNhap(DateTime ngayNhap, string idKho, string idNhaCC, string idNhanVien, string ghiChu, float tongTien, string trangThai)
        //{
        //    try
        //    {
        //        // Khai báo các tham số để truyền vào stored procedure
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //            new SqlParameter("@NgayNhap", SqlDbType.Date) { Value = ngayNhap },
        //            new SqlParameter("@IDKho", SqlDbType.NVarChar, 50) { Value = idKho },
        //            new SqlParameter("@IDNhaCC", SqlDbType.NVarChar, 50) { Value = idNhaCC },
        //            new SqlParameter("@IDNhanVien", SqlDbType.NVarChar, 50) { Value = idNhanVien },
        //            new SqlParameter("@GhiChu", SqlDbType.NVarChar, 255) { Value = ghiChu },
        //            new SqlParameter("@TongTien", SqlDbType.Float) { Value = tongTien },
        //            new SqlParameter("@TrangThai", SqlDbType.NVarChar, 255) { Value = trangThai }
        //        };

        //        // Gọi stored procedure để thêm phiếu nhập
        //        int result = dataConnect.ExecuteStoredProcedure("sp_ThemPhieuNhap", parameters);

        //        // Kiểm tra kết quả trả về từ stored procedure (thường là số dòng bị ảnh hưởng)
        //        if (result > 0)
        //        {
        //            return "Thêm phiếu nhập thành công.";
        //        }
        //        else
        //        {
        //            return "Có lỗi khi thêm phiếu nhập.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý lỗi nếu có
        //        return "Lỗi: " + ex.Message;
        //    }
        //}

        ////Chitietnhapkho
        //public string ThemChiTietPhieuNhap(string idPhieuNhap, string idThuoc, DateTime ngaySanXuat, DateTime ngayHetHan, string quyCach, int soLuong, float giaDonVi, float ThanhTien)
        //{
        //    try
        //    {


        //        // Khởi tạo các tham số cho stored procedure
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //            new SqlParameter("@IDPhieuNhap", SqlDbType.NVarChar) { Value = idPhieuNhap },
        //            new SqlParameter("@IDThuoc", SqlDbType.NVarChar) { Value = idThuoc },
        //            new SqlParameter("@NgaySanXuat", SqlDbType.Date) { Value = ngaySanXuat },
        //            new SqlParameter("@NgayHetHan", SqlDbType.Date) { Value = ngayHetHan },
        //            new SqlParameter("@QuyCach", SqlDbType.NVarChar) { Value = quyCach },
        //            new SqlParameter("@SoLuong", SqlDbType.Int) { Value = soLuong },
        //            new SqlParameter("@GiaDonVi", SqlDbType.Float) { Value = giaDonVi },
        //            new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = thanhTien }
        //        };

        //        // Gọi stored procedure sp_ThemChiTietPhieuNhap
        //        dataConnect.ExecuteStoredProcedure("sp_ThemChiTietPhieuNhap", parameters);

        //        // Nếu thành công, trả về ID chi tiết phiếu nhập mới
        //        return "Chi tiết phiếu nhập đã được thêm thành công!";
        //    }
        //    catch (Exception ex)
        //    {
        //        // Nếu có lỗi, hiển thị thông báo lỗi
        //        return "Lỗi khi thêm chi tiết phiếu nhập: " + ex.Message;
        //    }
        //}




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
                // Thiết lập các tham số cho stored procedure
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@NgayNhap", ngayNhap),
                    new SqlParameter("@IDKho", idKho),
                    new SqlParameter("@IDNhaCC", idNhaCC),
                    new SqlParameter("@IDNhanVien", idNhanVien),
                    new SqlParameter("@GhiChu", ghiChu),
                    new SqlParameter("@TrangThai", trangThai)
                };

                // Tạo DataTable từ danh sách Chi Tiết Phiếu Nhập
                DataTable chiTietTable = new DataTable();
                chiTietTable.Columns.Add("IDThuoc", typeof(string));
                chiTietTable.Columns.Add("NgaySanXuat", typeof(DateTime));
                chiTietTable.Columns.Add("NgayHetHan", typeof(DateTime));
                chiTietTable.Columns.Add("QuyCach", typeof(string));
                chiTietTable.Columns.Add("SoLuong", typeof(int));
                chiTietTable.Columns.Add("GiaDonVi", typeof(float));

                foreach (var item in chiTietPhieuNhap)
                {
                    chiTietTable.Rows.Add(item.IDThuoc, item.NgaySanXuat, item.NgayHetHan, item.QuyCach, item.SoLuong, item.GiaDonVi);
                }

                // Thêm DataTable dưới dạng tham số kiểu bảng
                SqlParameter chiTietParam = new SqlParameter
                {
                    ParameterName = "@ChiTietPhieuNhap",
                    SqlDbType = SqlDbType.Structured,
                    TypeName = "ChiTietPhieuNhapType", // Tên của User-Defined Table Type trong SQL Server
                    Value = chiTietTable
                };
                parameters.Add(chiTietParam);

                // Gọi stored procedure và nhận kết quả trả về
                string storedProcedure = "sp_ThemPhieuNhapVaChiTiet";
                int result = dataConnect.ExecuteStoredProcedure(storedProcedure, parameters.ToArray());

                if (result != 0)
                {
                    return $"PN{result:D4}";
                }
                else
                {
                    throw new Exception("Không thể thêm Phiếu Nhập.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm Phiếu Nhập: " + ex.Message);
            }
        }
    }
}
