using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoDTO
    {
        public string IDKho { get; set; }
        public string LoaiKho { get; set; }
        public string GhiChu { get; set; }

        public KhoDTO() { }

        public KhoDTO(string iDKho, string loaiKho, string ghiChu)
        {
            this.IDKho = iDKho;
            this.LoaiKho = loaiKho;
            this.GhiChu = ghiChu;
        }
    }
}
