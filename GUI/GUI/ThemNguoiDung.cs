using BLL;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class ThemNguoiDung : Form
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        public ThemNguoiDung(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);
        }

        private void btn_addNguoiDung_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txt_addTen.Text;
            string chucVu = cb_addchucvu.SelectedValue.ToString();
            DateTime ngaySinh = dtp_NgaySinh.Value;
            string diaChi = txt_addDiaChi.Text;
            string email = txt_addEmail.Text;
            string soDienThoai = txt_addSDT.Text;
            string trinhDo = txt_addTrinhDo.Text;
            string password = txt_addMatKhau.Text;
            string confirmPassword = txt_XacNhanMatKhau.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                txt_addMatKhau.Focus();
                return;
            }

            byte[] anh = ConvertImageToByteArray(pb_Hinh.Image); // Chuyển đổi ảnh từ PictureBox

            try
            {
                bool success = userBLL.AddUser(tenNhanVien, chucVu, password, ngaySinh, diaChi, email, soDienThoai, trinhDo, anh);
                if (success)
                {
                    MessageBox.Show("Thêm người dùng thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Thêm mã xử lý nếu cần hoặc để trống nếu không có chức năng nào
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Thêm mã xử lý nếu cần hoặc để trống nếu không có chức năng nào
        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtChucVu = userBLL.GetChucVuList();
                cb_addchucvu.DataSource = dtChucVu;
                cb_addchucvu.DisplayMember = "TenChucVu";
                cb_addchucvu.ValueMember = "IDChucVu";

                // Lấy mã nhân viên mới tự động
                string newMaNhanVien = userBLL.GenerateNewMaNhanVien();
                txt_addTenTK.Text = newMaNhanVien; // Hiển thị mã này như là username
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu chức vụ hoặc mã nhân viên: " + ex.Message);
            }
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }


        private void btn_PickPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn hình ảnh đại diện";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh đã chọn trong PictureBox
                    pb_Hinh.Image = Image.FromFile(openFileDialog.FileName);
                    pb_Hinh.Tag = openFileDialog.FileName; // Lưu đường dẫn ảnh vào Tag của PictureBox
                }
            }
        }
    }
}
