using BLL;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
            string username = txt_addTenTK.Text;
            string password = txt_addMatKhau.Text;
            string confirmPassword = txt_XacNhanMatKhau.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                txt_addMatKhau.Focus();
                return;
            }

            if (userBLL.CheckDuplicateUsernameOrLogin(username))
            {
                MessageBox.Show("Username hoặc Login đã tồn tại. Vui lòng chọn tên khác.");
                txt_addTenTK.Focus();
                return;
            }

            try
            {
                bool success = userBLL.AddUser(tenNhanVien, chucVu, username, password, confirmPassword);
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

                // Cài đặt nguồn dữ liệu cho ComboBox
                cb_addchucvu.DataSource = dtChucVu;
                cb_addchucvu.DisplayMember = "TenChucVu";
                cb_addchucvu.ValueMember = "IDChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
