using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNhapKhoDTO
    {
        public string IDChiTietPhieuNhap {  get; set; }
        public string IDPhieuNhap { get; set; }
        public string IDThuoc {  get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime NgayHetHan {  get; set; }
        public string QuyCach {  get; set; }
        public int SoLuong {  get; set; }
        public float GiaDonVi {  get; set; }
        public float ThanhTien {  get; set; }

        public ChiTietNhapKhoDTO() { }
        public ChiTietNhapKhoDTO(string iDChiTietPhieuNhap, string iDPhieuNhap, string iDThuoc, DateTime ngaySanXuat, DateTime ngayHetHan, string quyCach, int soLuong, float giaDonVi, float thanhTien)
        {
            this.IDChiTietPhieuNhap = iDChiTietPhieuNhap;
            this.IDPhieuNhap = iDPhieuNhap;
            this.IDThuoc = iDThuoc;
            this.NgaySanXuat = ngaySanXuat;
            this.NgayHetHan = ngayHetHan;
            this.QuyCach = quyCach;
            this.SoLuong = soLuong;
            this.GiaDonVi = giaDonVi;
            this.ThanhTien = thanhTien;
        }
    }
}
