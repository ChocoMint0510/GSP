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

                // Thêm tham số OUTPUT để nhận ID phiếu nhập đã được sinh ra
                SqlParameter outputParam = new SqlParameter("@IDPhieuNhap", SqlDbType.NVarChar, 50)
                {
                    Direction = ParameterDirection.Output
                };
                parameters.Add(outputParam);

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
                    TypeName = "ChiTietPhieuNhapType",
                    Value = chiTietTable
                };
                parameters.Add(chiTietParam);

                // Gọi stored procedure
                string storedProcedure = "sp_ThemPhieuNhapVaChiTiet";
                dataConnect.ExecuteStoredProcedure(storedProcedure, parameters.ToArray());

                // Trả về ID phiếu nhập từ tham số OUTPUT
                return outputParam.Value.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm Phiếu Nhập: " + ex.Message);
            }
        }




        public DataSet LayThongTinPhieuNhapTheoID(string idPhieuNhap)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@IDPhieuNhap", idPhieuNhap) };
                return dataConnect.ExecuteStoredProcedureWithDataSet("sp_LayThongTinPhieuNhapTheoID", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin phiếu nhập theo ID: " + ex.Message);
            }
        }

        // 1. Lấy danh sách phiếu nhập
        //public DataTable HienThiPhieuNhap()
        //{
        //    string query = "SELECT * FROM PhieuNhap";
        //    return dataConnect.GetData(query);
        //}


        public DataTable HienThiPhieuNhap()
        {
            try
            {
                return dataConnect.GetData("sp_HienThiPhieuNhap");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị phiếu nhập: " + ex.Message);
            }
        }



        // 2. Lấy chi tiết phiếu nhập theo IDPhieuNhap
        //public DataTable LayChiTietPhieuNhap(string idPhieuNhap)
        //{
        //    string query = "SELECT * FROM ChiTietPhieuNhap WHERE IDPhieuNhap = @IDPhieuNhap";
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@IDPhieuNhap", idPhieuNhap)
        //    };
        //    return dataConnect.GetData(query, parameters);
        //}

        public DataTable LayChiTietPhieuNhap(string idPhieuNhap)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDPhieuNhap", idPhieuNhap)
                };
                return dataConnect.GetData("sp_LayThongTinCTPhieuNhapTheoID", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy chi tiết phiếu nhập: " + ex.Message);
            }
        }

    }
}
