using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuuTruDTO
    {
        public string IDLuuTru { get; set; }
        public string IDThuoc { get; set; }
        public string IDChiTietPhieuNhap { get; set; }
        public int SLton {  get; set; }
        public DateTime NgayNhap { get; set; }
        public string IDKho {  get; set; }
        public string IDKhu { get; set; }
        public string IDKe {  get; set; }
        public string IDO {  get; set; }

        public LuuTruDTO() { }

        public LuuTruDTO(string iDLuuTru, string iDThuoc, string iDChiTietPhieuNhap, int sLton, DateTime ngayNhap,string iDKho, string iDKhu, string iDKe, string iDO)
        {
            this.IDLuuTru = iDLuuTru;
            this.IDThuoc = iDThuoc;
            this.IDChiTietPhieuNhap = iDChiTietPhieuNhap;
            this.SLton = sLton;
            this.NgayNhap = ngayNhap;
            this.IDKho = iDKho;
            this.IDKhu = iDKhu;
            this.IDKe = iDKe;
            this.IDO = iDO;
        }
    }
}
