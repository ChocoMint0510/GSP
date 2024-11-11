using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public string MaNhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVuID { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string TrinhDo { get; set; }
        public byte[] Anh { get; set; }

        public UserDTO() { }

        public UserDTO(string maNhanVienID, string tenNhanVien, string chucVuID, DateTime ngaySinh,
            string diaChi, string email, string soDienThoai, string trinhDo, byte[] anh)
        {
            MaNhanVienID = maNhanVienID;
            TenNhanVien = tenNhanVien;
            ChucVuID = chucVuID;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Email = email;
            SoDienThoai = soDienThoai;
            TrinhDo = trinhDo;
            Anh = anh;
        }
    }



}

