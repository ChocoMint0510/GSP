using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nhaCungCapDAL;

        public NhaCungCapBLL(string username, string password)
        {
            nhaCungCapDAL = new NhaCungCapDAL(username, password);
        }

        public Dictionary<string, string> GetAllTenNhaCC()
        {
            try
            {
                return nhaCungCapDAL.GetAllTenNhaCC();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tên nhà cung cấp từ DAL: " + ex.Message);
            }
        }


    }
}
