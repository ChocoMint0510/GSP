using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyCachDTO
    {
        public string IDQuyCach { get; set; }
        public string TenQuyCach { get; set; }

        public QuyCachDTO() { }
        
        public QuyCachDTO(string iDQuyCach, string tenQuyCach)
        {
            this.IDQuyCach = iDQuyCach;
            this.TenQuyCach = tenQuyCach;
        }
    }
}
