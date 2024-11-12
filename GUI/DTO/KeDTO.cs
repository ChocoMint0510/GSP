using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KeDTO
    {
        public string IDKe { get; set; }
        public string TenKe { get; set; }
        public string GhiChu {  get; set; }
        public string IDKhu {  get; set; }

        public KeDTO() { }

        public KeDTO(string iDKe, string tenKe, string ghiChu, string iDKhu)
        {
            this.IDKe = iDKe;
            this.TenKe = tenKe;
            this.GhiChu = ghiChu;
            this.IDKhu = iDKhu;
        }
    }
}
