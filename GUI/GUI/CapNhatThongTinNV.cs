using BLL;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CapNhatThongTinNV : DevExpress.XtraEditors.XtraForm
    {
        private UserDTO user;
        private UserBLL userBLL;
        public CapNhatThongTinNV(UserDTO user, UserBLL userBLL)
        {
            InitializeComponent();
            this.user = user;
            this.userBLL = userBLL;
            LoadUserData();
        }
        private void LoadUserData()
        {
            // Tải danh sách chức vụ vào ComboBox
            DataTable chucVuTable = userBLL.GetChucVuList();
            cb_upchucvu.DataSource = chucVuTable;
            cb_upchucvu.DisplayMember = "TenChucVu";
            cb_upchucvu.ValueMember = "IDChucVu";

            // Thiết lập giá trị mặc định cho ComboBox theo chức vụ hiện tại của nhân viên
            cb_upchucvu.SelectedValue = user.ChucVuID;

            // Hiển thị các thông tin khác
            txt_UpdateTen.Text = user.TenNhanVien;
            dtp_UpNgaySinh.Value = user.NgaySinh;
            txt_upDiaChi.Text = user.DiaChi;
            txt_upEmail.Text = user.Email;
            txt_upSDT.Text = user.SoDienThoai;
            txt_upTrinhDo.Text = user.TrinhDo;

            if (user.Anh != null)
            {
                pb_Anh.Image = ConvertByteArrayToImage(user.Anh);
            }
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null) return null;
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private void btn_UpTTNV_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin từ các điều khiển vào đối tượng user
            user.TenNhanVien = txt_UpdateTen.Text;
            user.ChucVuID = cb_upchucvu.SelectedValue.ToString();
            user.NgaySinh = dtp_UpNgaySinh.Value;
            user.DiaChi = txt_upDiaChi.Text;
            user.Email = txt_upEmail.Text;
            user.SoDienThoai = txt_upSDT.Text;
            user.TrinhDo = txt_upTrinhDo.Text;

            // Cập nhật ảnh nếu người dùng đã chọn ảnh mới
            if (pb_Anh.Image != null)
            {
                user.Anh = ConvertImageToByteArray(pb_Anh.Image);
            }

            // Gọi phương thức cập nhật trong BLL
            if (userBLL.UpdateNhanVien(user))
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên.");
            }
        }


        private void btn_upPickPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb_Anh.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}