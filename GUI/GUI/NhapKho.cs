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
    public partial class NhapKho : Form
    {
        private NhaCungCapBLL nhaCungCapBLL;
        private KhoBLL khoBLL;
        public NhapKho(string username, string password)
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL(username, password);
            khoBLL = new KhoBLL(username, password);
        }

        private void LoadNhaCungCapToComboBox()
        {
            try
            {
                Dictionary<string, string> nhaCCList = nhaCungCapBLL.GetAllTenNhaCC();

                cb_NhaCC.Items.Clear();

                foreach (var item in nhaCCList)
                {
                    cb_NhaCC.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_NhaCC.DisplayMember = "Value";
                cb_NhaCC.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải tên nhà cung cấp: " + ex.Message);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kho: " + ex.Message);
            }
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            LoadNhaCungCapToComboBox();
            LoadKhoToComboBox();
        }
    }
}
