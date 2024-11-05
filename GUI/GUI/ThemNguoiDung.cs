using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThemNguoiDung : Form
    {
        // Khai báo đối tượng UserBLL
        private UserBLL userBLL;

        public ThemNguoiDung()
        {
            InitializeComponent();

            // Khởi tạo đối tượng UserBLL
            userBLL = new UserBLL();
        }

        private void btn_addNguoiDung_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txt_addTen.Text;
            string chucVu = cb_addchucvu.SelectedValue.ToString();
            string quyen = cb_addQuyen.SelectedValue.ToString();
            string username = txt_addTenTK.Text;
            string password = txt_addMatKhau.Text;
            string confirmPassword = txt_XacNhanMatKhau.Text;

            // Kiểm tra mật khẩu và xác nhận mật khẩu có khớp hay không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                txt_addMatKhau.Focus();
                return;
            }

            // Kiểm tra trùng lặp Username hoặc Login
            if (userBLL.CheckDuplicateUsernameOrLogin(username))
            {
                MessageBox.Show("Username hoặc Login đã tồn tại. Vui lòng chọn tên khác.");
                txt_addTenTK.Focus();
                return;
            }

            try
            {
                // Thêm nhân viên mới
                bool success = userBLL.AddUser(tenNhanVien, chucVu, quyen, username, password, confirmPassword);
                if (success)
                {
                    MessageBox.Show("Thêm người dùng thành công.");
                    this.Close(); // Đóng form ThemNguoiDung nếu thêm thành công
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txt_addMatKhau.Focus();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                txt_addTenTK.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;Integrated Security=True"))
            {
                conn.Open();

                // Load dữ liệu vào cb_addchucvu
                SqlDataAdapter daChucVu = new SqlDataAdapter("SELECT IDChucVu, TenChucVu FROM ChucVu", conn);
                DataTable dtChucVu = new DataTable();
                daChucVu.Fill(dtChucVu);
                cb_addchucvu.DataSource = dtChucVu;
                cb_addchucvu.DisplayMember = "TenChucVu";
                cb_addchucvu.ValueMember = "IDChucVu";

                // Load dữ liệu vào cb_addQuyen
                SqlDataAdapter daQuyen = new SqlDataAdapter("SELECT IDQuyen, TenQuyen FROM Quyen", conn);
                DataTable dtQuyen = new DataTable();
                daQuyen.Fill(dtQuyen);
                cb_addQuyen.DataSource = dtQuyen;
                cb_addQuyen.DisplayMember = "TenQuyen";
                cb_addQuyen.ValueMember = "IDQuyen";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
