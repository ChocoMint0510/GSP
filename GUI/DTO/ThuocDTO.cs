using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuocDTO
    {
        public string IDThuoc {  get; set; }
        public string TenThuoc { get; set; }
        public string IDDVT { get; set; }
        public float DonGia {  get; set; }

        public ThuocDTO() { }

        public ThuocDTO(string iDThuoc, string tenThuoc, string iDDVT, float donGia)
        {
            this.IDThuoc = iDThuoc;
            this.TenThuoc = tenThuoc;
            this.IDDVT = iDDVT;
            this.DonGia = donGia;
        }
    }
}
