using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // DTO/UserDTO.cs
    public class UserDTO
    {
        public string MaNhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVuID { get; set; }
        public string Username { get; set; }

        public UserDTO() { }

        public UserDTO(string maNhanVienID, string tenNhanVien, string chucVuID, string username)
        {
            this.MaNhanVienID = maNhanVienID;
            this.TenNhanVien = tenNhanVien;
            this.ChucVuID = chucVuID;
            this.Username = username;
        }
    }

}
