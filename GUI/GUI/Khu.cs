using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Khu : Form
    {
        private KhuBLL khuBLL;
        private KhoBLL khoBLL;
        private bool isComboBoxLoaded = false;
        public delegate void KhuAddedHandler(string tenKhu);
        public event KhuAddedHandler OnKhuAdded;
        public Khu(string username, string password)
        {
            InitializeComponent();
            khuBLL = new KhuBLL(username, password);
            khoBLL = new KhoBLL(username, password);
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAllKhuData()
        {
            try
            {
                DataTable khuData = khuBLL.GetAllKhu();

                if (khuData != null && khuData.Rows.Count > 0)
                {
                    gc_Khu.DataSource = khuData;
                    gv_Khu.PopulateColumns();

                    // Đặt tên cho các cột
                    gv_Khu.Columns["IDKhu"].Caption = "Mã Khu";
                    gv_Khu.Columns["TenKhu"].Caption = "Tên Khu";
                    gv_Khu.Columns["GhiChu"].Caption = "Ghi Chú";
                }
                else
                {
                    gc_Khu.DataSource = CreateEmptyKhuTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khu: " + ex.Message);
            }
        }

        private void LoadKhoToComboBox()
        {
            try
            {
                Dictionary<string, string> loaiKhoList = khoBLL.GetAllLoaiKho();
                cb_Kho.Items.Clear();

                foreach (var item in loaiKhoList)
                {
                    cb_Kho.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_Kho.DisplayMember = "Value";
                cb_Kho.ValueMember = "Key";

                if (cb_Kho.Items.Count > 0)
                {
                    cb_Kho.SelectedIndex = 0; 
                    isComboBoxLoaded = true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kho: " + ex.Message);
            }
        }



        // Tạo một DataTable trống có cùng cấu trúc với bảng Khu
        private DataTable CreateEmptyKhuTable()
        {
            DataTable emptyTable = new DataTable();
            emptyTable.Columns.Add("ID Khu", typeof(string));
            emptyTable.Columns.Add("Tên khu", typeof(string));
            emptyTable.Columns.Add("Ghi chú", typeof(string));
            return emptyTable;
        }


        private void Gv_Khu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gv_Khu.GetFocusedDataRow();
            if (row != null)
            {
                txt_TenKhu.Text = row["TenKhu"].ToString();
                txt_GhiChu.Text = row["GhiChu"].ToString();
            }
        }


        private void Khu_Load(object sender, EventArgs e)
        {
            LoadAllKhuData();
            LoadKhoToComboBox();
            gv_Khu.FocusedRowChanged += Gv_Khu_FocusedRowChanged;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
           

            string tenKhu = txt_TenKhu.Text;
            string ghiChu = txt_GhiChu.Text;
            string idKho = (cb_Kho.SelectedItem as KeyValuePair<string, string>?)?.Key;

            if (string.IsNullOrWhiteSpace(tenKhu) || string.IsNullOrEmpty(idKho))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho khu.");
                return;
            }

            khuBLL.ThemKhu(tenKhu, ghiChu, idKho);
            MessageBox.Show("Thêm khu mới thành công.");
            btn_Them.Enabled = true;
            btn_Luu.Enabled = false;
            txt_TenKhu.Enabled = false;
            txt_GhiChu.Enabled = false;

            LoadAllKhuData();
            OnKhuAdded?.Invoke(tenKhu);
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
            txt_TenKhu.Enabled = true;
            txt_GhiChu.Enabled = true;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadAllKhuData();
        }
    }
}
