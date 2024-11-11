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
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        public QuanLyNhanVien(string username, string password)
        {
            InitializeComponent();

            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);
            LoadNhanVienData(); // Bỏ tham số username
            pb_AnhNV.SizeMode = PictureBoxSizeMode.Zoom;
            
            dgv_NhanVien.CellClick += dgv_NhanVien_CellClick;
        }


        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadNhanVienData()
        {
            try
            {
                DataTable dtNhanVien = userBLL.GetAllNhanVienWithChucVu();
                dgv_NhanVien.DataSource = dtNhanVien;

                if (dgv_NhanVien.Columns["NgaySinh"] != null)
                {
                    dgv_NhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd-MM-yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message);
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

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            ThemNguoiDung themNguoiDungForm = new ThemNguoiDung(_username, _password);
            if (themNguoiDungForm.ShowDialog() == DialogResult.OK)
            {
                // Reload dữ liệu sau khi thêm nhân viên thành công
                LoadNhanVienData();
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                UserDTO user = userBLL.GetUserByUsername(_username); // Sử dụng _username thay vì username
                if (user != null)
                {
                    lb_MaNV.Text = user.MaNhanVienID;
                    lb_TenNV.Text = user.TenNhanVien;
                    lb_TenND.Text = user.MaNhanVienID; // Thay thế 'Username' thành 'MaNhanVienID'
                    lb_NgaySinh.Text = user.NgaySinh.ToString("dd/MM/yyyy");
                    lb_TrinhDo.Text = user.TrinhDo;
                    lb_ChucVu.Text = user.ChucVuID; // Bạn có thể gọi thêm để lấy tên chức vụ nếu cần
                    lb_DiaChi.Text = user.DiaChi;
                    lb_Email.Text = user.Email;
                    lb_SDT.Text = user.SoDienThoai;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message);
            }
        }


        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

                // Kiểm tra và cập nhật từng Label chỉ khi có dữ liệu trong cột tương ứng
                if (dgv_NhanVien.Columns.Contains("IDNhanVien") && row.Cells["IDNhanVien"].Value != DBNull.Value)
                    lb_MaNV.Text = row.Cells["IDNhanVien"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("TenNhanVien") && row.Cells["TenNhanVien"].Value != DBNull.Value)
                    lb_TenNV.Text = row.Cells["TenNhanVien"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("IDNhanVien") && row.Cells["IDNhanVien"].Value != DBNull.Value)
                    lb_TenND.Text = row.Cells["IDNhanVien"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("NgaySinh") && row.Cells["NgaySinh"].Value != DBNull.Value)
                    lb_NgaySinh.Text = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");

                if (dgv_NhanVien.Columns.Contains("TrinhDo") && row.Cells["TrinhDo"].Value != DBNull.Value)
                    lb_TrinhDo.Text = row.Cells["TrinhDo"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("IDChucVu") && row.Cells["IDChucVu"].Value != DBNull.Value)
                    lb_ChucVu.Text = row.Cells["IDChucVu"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("DiaChi") && row.Cells["DiaChi"].Value != DBNull.Value)
                    lb_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("Email") && row.Cells["Email"].Value != DBNull.Value)
                    lb_Email.Text = row.Cells["Email"].Value.ToString();

                if (dgv_NhanVien.Columns.Contains("SoDienThoai") && row.Cells["SoDienThoai"].Value != DBNull.Value)
                    lb_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();

                // Chuyển đổi ảnh từ byte[] thành Image và hiển thị lên PictureBox
                if (dgv_NhanVien.Columns.Contains("Anh") && row.Cells["Anh"].Value != DBNull.Value)
                {
                    byte[] anhData = (byte[])row.Cells["Anh"].Value;
                    pb_AnhNV.Image = ConvertByteArrayToImage(anhData);
                }
                else
                {
                    pb_AnhNV.Image = null; // Nếu không có ảnh, hiển thị null
                }

            }
            else
            {
                MessageBox.Show("Không có nhân viên được chọn!");
            }
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Tạo một bản sao của ảnh để đảm bảo không bị khóa
                using (Bitmap bitmap = new Bitmap(image))
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                }
                return ms.ToArray();
            }
        }


        private void btn_SuaTT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lb_MaNV.Text))
            {
                UserDTO selectedUser = new UserDTO
                {
                    MaNhanVienID = lb_MaNV.Text,
                    TenNhanVien = lb_TenNV.Text,
                    ChucVuID = lb_ChucVu.Text,
                    NgaySinh = DateTime.Parse(lb_NgaySinh.Text),
                    DiaChi = lb_DiaChi.Text,
                    Email = lb_Email.Text,
                    SoDienThoai = lb_SDT.Text,
                    TrinhDo = lb_TrinhDo.Text,
                    Anh = ConvertImageToByteArray(pb_AnhNV.Image)
                };

                CapNhatThongTinNV updateForm = new CapNhatThongTinNV(selectedUser, userBLL);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadNhanVienData(); // Reload dữ liệu sau khi cập nhật
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật thông tin.");
            }
        }
        private void ClearEmployeeDetails()
        {
            lb_MaNV.Text = "";
            lb_TenNV.Text = "";
            lb_TenND.Text = "";
            lb_NgaySinh.Text = "";
            lb_TrinhDo.Text = "";
            lb_ChucVu.Text = "";
            lb_DiaChi.Text = "";
            lb_Email.Text = "";
            lb_SDT.Text = "";
            pb_AnhNV.Image = null;
        }
        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có nhân viên nào đang hiển thị hay không
            if (!string.IsNullOrEmpty(lb_MaNV.Text) && !string.IsNullOrEmpty(lb_TenNV.Text))
            {
                string maNhanVien = lb_MaNV.Text;
                string tenNhanVien = lb_TenNV.Text;

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có muốn xóa nhân viên '{maNhanVien} - {tenNhanVien}' này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    // Gọi phương thức xóa từ BLL
                    if (userBLL.DeleteUser(maNhanVien, maNhanVien)) // Sử dụng mã nhân viên làm Username
                    {
                        MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhanVienData(); // Cập nhật lại danh sách nhân viên sau khi xóa
                        ClearEmployeeDetails(); // Xóa các thông tin hiển thị của nhân viên
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}