using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Khu : Form
    {
        private KhuBLL khuBLL;
        private KhoBLL khoBLL;
        public Khu()
        {
            InitializeComponent();
            khuBLL = new KhuBLL();
            khoBLL = new KhoBLL();
        }

        private void ShowKhuByIDKho(string idKho)
        {
            try
    {
        List<KhuDTO> khuList = khuBLL.GetKhuByIDKho(idKho);
        dgv_Khu.DataSource = khuList;

        // Đặt tiêu đề cho các cột
        dgv_Khu.Columns["IDKhu"].HeaderText = "ID Khu";
        dgv_Khu.Columns["TenKhu"].HeaderText = "Tên Khu";
        dgv_Khu.Columns["GhiChu"].HeaderText = "Ghi Chú";

        // Xóa cột IDKho khỏi DataGridView
        if (dgv_Khu.Columns.Contains("IDKho"))
        {
            dgv_Khu.Columns.Remove("IDKho");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi khi hiển thị dữ liệu khu: " + ex.Message);
    }
        }

        private void dgv_Khu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Khu.Rows[e.RowIndex];

                txt_IDkhu.Text = row.Cells["IDKhu"].Value.ToString();
                txt_TenKhu.Text = row.Cells["TenKhu"].Value.ToString();
                txt_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void CanhDeuDgv()
        {
            if (dgv_Khu.Columns.Count > 0)
            {
                int columnWidth = dgv_Khu.Width / dgv_Khu.Columns.Count;
                foreach (DataGridViewColumn column in dgv_Khu.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        private void LoadLoaiKhoToComboBox()
        {
            try
            {
                Dictionary<string, string> loaiKhoList = khoBLL.GetAllLoaiKho();
                cb_Kho.DataSource = new BindingSource(loaiKhoList, null);
                cb_Kho.DisplayMember = "Value";  // Hiển thị LoaiKho
                cb_Kho.ValueMember = "Key";      // Lưu IDKho làm giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải LoaiKho: " + ex.Message);
            }
        }

        private void Khu_Load(object sender, EventArgs e)
        {
            CanhDeuDgv();
            LoadLoaiKhoToComboBox();
        }

        private void cb_Kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Kho.SelectedIndex >= 0)
            {
                // Lấy IDKho từ ValueMember của ComboBox
                string selectedIDKho = ((KeyValuePair<string, string>)cb_Kho.SelectedItem).Key;
                ShowKhuByIDKho(selectedIDKho); // Hiển thị danh sách Khu theo IDKho
            }
        }
    }
}
