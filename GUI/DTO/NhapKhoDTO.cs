using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NhapKhoDTO
    {
        public string IDPhieuNhap { get; set; }
        public DateTime NgayNhap {  get; set; }
        public string IDKho {  get; set; }
        public string IDNhanVien {  get; set; }
        public string GhiChu {  get; set; }
        public float TongTien {  get; set; }
        public string TrangThai { get; set; }

        public NhapKhoDTO() { }

        public NhapKhoDTO(string idPhieuNhap, DateTime ngayNhap, string idKho, string idNhanVien, string ghiChu, float tongTien, string trangThai)
        {
            this.IDPhieuNhap = idPhieuNhap;
            this.NgayNhap = ngayNhap;
            this.IDKho = idKho;
            this.IDNhanVien = idNhanVien;
            this.GhiChu = ghiChu;
            this.TongTien = tongTien;
            this.TrangThai = trangThai;
        }

    }
}
