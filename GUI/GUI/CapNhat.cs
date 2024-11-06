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
using static DevExpress.Data.Helpers.FindSearchRichParser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class CapNhat : DevExpress.XtraEditors.XtraForm
    {
        private string _maNV;
        private string _username;
        private string _hoTen;
        private string _chucVu;

        private string _loginUsername;
        private string _loginPassword;

        public CapNhat(string maNV, string username, string hoTen, string chucVu, string loginUsername, string loginPassword)
        {
            InitializeComponent();
            _maNV = maNV;
            _username = username;
            _hoTen = hoTen;
            _chucVu = chucVu;
            _loginUsername = loginUsername;
            _loginPassword = loginPassword;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CapNhat_Load(object sender, EventArgs e)
        {
            txt_updMaNV.Text = _maNV;
            txt_updTenTK.Text = _username;
            txt_updTen.Text = _hoTen;

            string connectionString =
                $"Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;User ID={_loginUsername};Password={_loginPassword}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDChucVu, TenChucVu FROM ChucVu", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb_updChucVu.DataSource = dt;
                cb_updChucVu.DisplayMember = "TenChucVu";
                cb_updChucVu.ValueMember = "IDChucVu";

                // Đặt giá trị ban đầu cho ComboBox
                cb_updChucVu.SelectedIndex = cb_updChucVu.FindStringExact(_chucVu);
            }
        }

        private void btn_updLuu_Click(object sender, EventArgs e)
        {
            string newHoTen = txt_updTen.Text;
            string newUsername = txt_updTenTK.Text;
            string newChucVuID = cb_updChucVu.SelectedValue.ToString();
            string newChucVuText = cb_updChucVu.Text;

            DialogResult result = MessageBox.Show(
                $"Bạn có muốn lưu người dùng '{newUsername}' với mã '{_maNV}', tên '{newHoTen}', và chức vụ '{newChucVuText}' không?",
                "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionString =
                    $"Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;User ID={_loginUsername};Password={_loginPassword}";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateNhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNhanVien", _maNV);
                    cmd.Parameters.AddWithValue("@TenNhanVien", newHoTen);
                    cmd.Parameters.AddWithValue("@IDChucVu", newChucVuID);
                    cmd.Parameters.AddWithValue("@Username", newUsername);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Đóng form và trả về OK
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}