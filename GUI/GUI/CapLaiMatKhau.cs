using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CapLaiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private string _maNV;
        private string _username;
        private string _loginUsername;
        private string _loginPassword;

        public CapLaiMatKhau(string maNV, string username, string loginUsername, string loginPassword)
        {
            InitializeComponent();
            _maNV = maNV;
            _username = username;
            _loginUsername = loginUsername;
            _loginPassword = loginPassword;
        }

        private void CapLaiMatKhau_Load(object sender, EventArgs e)
        {
            txt_updMKMaNV.Text = _maNV;
            txt_updMKTenTK.Text = _username;
        }

        private void btn_updMKCapNhat_Click(object sender, EventArgs e)
        {
            string newPassword = txt_updMK.Text;
            string confirmPassword = txt_updXMK.Text;

            // Kiểm tra tính khớp của mật khẩu
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_updMK.Focus();
                return;
            }

            // Xác nhận lưu thay đổi
            DialogResult result = MessageBox.Show($"Bạn có muốn lưu thay đổi mật khẩu cho user '{_username}' không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionString = $"Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;User ID={_loginUsername};Password={_loginPassword}";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdatePassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", _username);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 