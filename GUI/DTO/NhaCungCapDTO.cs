using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public string IDNhaCC { get; set; }
        public string TenNhaCC { get; set; }
        public string SDT {  get; set; }
        public string DiaChi {  get; set; }
        public string Email {  get; set; }

        public NhaCungCapDTO() { }

        public NhaCungCapDTO(string iDNhaCC, string tenNhaCC, string sDT, string diaChi, string email)
        {
            this.IDNhaCC = iDNhaCC;
            this.TenNhaCC = tenNhaCC;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Email = email;
        }
    }
}
