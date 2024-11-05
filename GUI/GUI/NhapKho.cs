using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhapKho : Form
    {
        private NhapKhoBLL nhapKhoBLL;
        public NhapKho()
        {
            InitializeComponent();
            nhapKhoBLL = new NhapKhoBLL();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng NhapKhoDTO với dữ liệu từ các TextBox
                NhapKhoDTO nhapKho = new NhapKhoDTO
                {
                    NgayNhap = dt_NgayNhap.Value,
                    IDKho = cb_Khuvuc.SelectedItem?.ToString(),
                    IDNhanVien = cb_NguoiNhap.SelectedItem?.ToString(),
                    GhiChu = txt_TinhTrang.Text,
                    GiaTriDonHang = float.Parse(txt_GiaTriDH.Text),
                };

                // Gọi phương thức thêm phiếu nhập từ BLL
                bool success = nhapKhoBLL.ThemPhieuNhap(nhapKho);

                if (success)
                {
                    MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho Giá Trị Đơn Hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
