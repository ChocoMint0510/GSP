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
    public partial class QuanTriNguoiDung : Form
    {
        public QuanTriNguoiDung()
        {
            InitializeComponent();

            txt_MaNV.ReadOnly = true;
            txt_UserName.ReadOnly = true;
            txt_HoTen.ReadOnly = true;
            txt_ChucVu.ReadOnly = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                ThemNguoiDung themNguoiDungForm = new ThemNguoiDung();
                themNguoiDungForm.ShowDialog();
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
            string connectionString = "Data Source=NARIZMUSIC\\CHOCOPRO;Initial Catalog=QuanLyGSP;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetUserData", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Xử lý dữ liệu mà không cần ghép chuỗi quyền
                var groupedData = dt.AsEnumerable()
                    .Select(row => new
                    {
                        MaNhanVien = row["MaNhanVien"],
                        Username = row["Username"],
                        HoVaTen = row["HoVaTen"],
                        ChucVu = row["ChucVu"]
                    })
                    .ToList();

                // Chuyển đổi dữ liệu thành DataTable để hiển thị trên DataGridView
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
    }
}
