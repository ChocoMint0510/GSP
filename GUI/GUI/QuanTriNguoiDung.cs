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
using BLL;

namespace GUI
{
    public partial class QuanTriNguoiDung : Form
    {
        private UserBLL userBLL;
        private string _username;
        private string _password;

        public QuanTriNguoiDung(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);
            LoadUserData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNguoiDung themNguoiDungForm = new ThemNguoiDung(_username, _password);

            if (themNguoiDungForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // Cập nhật lại danh sách sau khi thêm nhân viên
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                DataTable dt = userBLL.GetAllUsers();

                // Xử lý dữ liệu và chuyển đổi cho DataGridView
                var groupedData = dt.AsEnumerable()
                    .Select(row => new
                    {
                        MaNhanVien = row["MaNhanVien"],
                        Username = row["Username"],
                        HoVaTen = row["HoVaTen"],
                        ChucVu = row["ChucVu"]
                    })
                    .ToList();

                DataTable resultTable = new DataTable();
                resultTable.Columns.Add("MaNhanVien");
                resultTable.Columns.Add("Username");
                resultTable.Columns.Add("HoVaTen");
                resultTable.Columns.Add("ChucVu");

                foreach (var item in groupedData)
                {
                    resultTable.Rows.Add(item.MaNhanVien, item.Username, item.HoVaTen, item.ChucVu);
                }

                dgv_DanhSach.DataSource = resultTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                txt_MaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txt_UserName.Text = row.Cells["Username"].Value.ToString();
                txt_HoTen.Text = row.Cells["HoVaTen"].Value.ToString();
                txt_ChucVu.Text = row.Cells["ChucVu"].Value.ToString();

                txt_MaNV.ReadOnly = true;
                txt_UserName.ReadOnly = true;
                txt_HoTen.ReadOnly = true;
                txt_ChucVu.ReadOnly = true;
            }
        }

        private void btn_XoaND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ danh sách.");
                return;
            }

            string maNhanVien = txt_MaNV.Text;
            string tenNhanVien = txt_HoTen.Text;

            DialogResult result = MessageBox.Show($"Bạn có muốn xoá nhân viên sau không?\nMã nhân viên: {maNhanVien}\nTên nhân viên: {tenNhanVien}",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = userBLL.DeleteUser(maNhanVien, txt_UserName.Text);

                    if (success)
                    {
                        MessageBox.Show("Xóa nhân viên thành công.");
                        LoadUserData(); // Cập nhật lại danh sách nhân viên
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void btn_CapNhatND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Hãy chọn một nhân viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txt_MaNV.Text;
            string tenTK = txt_UserName.Text;
            string hoTen = txt_HoTen.Text;
            string chucVu = txt_ChucVu.Text;

            CapNhat capNhatForm = new CapNhat(maNV, tenTK, hoTen, chucVu, _username, _password);
            capNhatForm.ShowDialog();

            LoadUserData();
        }

        private void btn_CapLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Hãy chọn một user để cấp lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txt_MaNV.Text;
            string tenTK = txt_UserName.Text;

            CapLaiMatKhau capLaiMatKhauForm = new CapLaiMatKhau(maNV, tenTK, _username, _password);
            capLaiMatKhauForm.ShowDialog();
        }
    }
}
