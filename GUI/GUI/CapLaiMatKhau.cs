using BLL;
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
        private UserBLL userBLL;

        public CapLaiMatKhau(string maNV, string username, string loginUsername, string loginPassword)
        {
            InitializeComponent();
            _maNV = maNV;
            _username = username;
            _loginUsername = loginUsername;
            _loginPassword = loginPassword;
            userBLL = new UserBLL(_loginUsername, _loginPassword);
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
                try
                {
                    bool success = userBLL.UpdatePassword(_username, newPassword);

                    if (success)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi cập nhật mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 