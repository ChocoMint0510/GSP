using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using DAL;
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
        private DataConnect dataConnect;

        public CapNhat(string maNV, string username, string hoTen, string chucVu, string loginUsername, string loginPassword)
        {
            InitializeComponent();
            _maNV = maNV;
            _username = username;
            _hoTen = hoTen;
            _chucVu = chucVu;
            _loginUsername = loginUsername;
            _loginPassword = loginPassword;
            dataConnect = new DataConnect(_loginUsername, _loginPassword);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CapNhat_Load(object sender, EventArgs e)
        {
            txt_updMaNV.Text = _maNV;
            txt_updTenTK.Text = _username;
            txt_updTen.Text = _hoTen;

            try
            {
                // Lấy danh sách chức vụ để hiển thị trong ComboBox
                DataTable dt = dataConnect.GetData("SELECT IDChucVu, TenChucVu FROM ChucVu");
                cb_updChucVu.DataSource = dt;
                cb_updChucVu.DisplayMember = "TenChucVu";
                cb_updChucVu.ValueMember = "IDChucVu";

                // Đặt giá trị ban đầu cho ComboBox
                cb_updChucVu.SelectedIndex = cb_updChucVu.FindStringExact(_chucVu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaNhanVien", _maNV),
                    new SqlParameter("@TenNhanVien", newHoTen),
                    new SqlParameter("@IDChucVu", newChucVuID),
                    new SqlParameter("@Username", newUsername)
                };

                try
                {
                    int updateResult = dataConnect.ExecuteStoredProcedure("sp_UpdateNhanVien", parameters);

                    if (updateResult == 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Đóng form và trả về OK
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi cập nhật thông tin. Kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}