using BLL;
using DAL;
using DevExpress.XtraEditors.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class SapXepThuoc : Form
    {
        private LuuTruBLL luuTruBLL;
        private KhoBLL khoBLL;
        private KhuBLL khuBLL;
        private KeBLL keBLL;
        private DataTable dataTable;
        public SapXepThuoc(string username, string password)
        {
            InitializeComponent();
            luuTruBLL = new LuuTruBLL(username, password);
            khoBLL = new KhoBLL(username, password);
            khuBLL = new KhuBLL(username, password);
            keBLL = new KeBLL(username, password);
            InitializeDataTable();
            Load += SapXepThuoc_Load;

        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("TenThuoc", typeof(string));
            dataTable.Columns.Add("IDThuoc", typeof(string));
            dataTable.Columns.Add("IDChiTietPhieuNhap", typeof(string));
            dataTable.Columns.Add("SLTon", typeof(int));
            dataTable.Columns.Add("NgayNhap", typeof(DateTime));
            dataTable.Columns.Add("Kho", typeof(string));
            dataTable.Columns.Add("Khu", typeof(string));
            dataTable.Columns.Add("Ke", typeof(string));
            dataTable.Columns.Add("O", typeof(string));

            gc_ThuocChuaSapXep.DataSource = dataTable;
        }


        private void AddColumnsToGridView()
        {
            var captions = new[] { "Tên thuốc", "Mã thuốc", "Mã CTPN", "SL nhập", "Ngày nhập", "Kho", "Khu", "Kệ", "Ô" };
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                var column = gv_ThuocChuaSapXep.Columns[dataTable.Columns[i].ColumnName];
                if (column != null)
                {
                    column.Caption = captions[i];
                    column.Visible = true;

                    if (column.FieldName == "IDThuoc" || column.FieldName == "IDChiTietPhieuNhap" || column.FieldName == "SLTon" || column.FieldName == "NgayNhap")
                    {
                        column.OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        column.OptionsColumn.AllowEdit = true; 
                    }
                }
            }

            var colKho = gv_ThuocChuaSapXep.Columns["Kho"];
            if (colKho != null)
            {
                colKho.OptionsColumn.AllowEdit = false;
            }
        }



        private void LoadComboBoxInTenThuocColumn()
        {
            try
            {
                // Lấy dữ liệu từ bảng ChiTietPhieuNhap qua BLL
                DataTable dtChiTietPhieuNhap = luuTruBLL.HienThiTatCaChiTietNhapKho();

                if (dtChiTietPhieuNhap == null || dtChiTietPhieuNhap.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu chi tiết phiếu nhập để hiển thị.");
                    return;
                }

                // Thêm cột UniqueID để làm khóa duy nhất, kết hợp IDThuoc và IDChiTietPhieuNhap
                dtChiTietPhieuNhap.Columns.Add("UniqueID", typeof(string), "IDThuoc + '-' + IDChiTietPhieuNhap");

                // Tạo RepositoryItemLookUpEdit cho cột "Tên thuốc"
                RepositoryItemLookUpEdit lookUpEditTenThuoc = new RepositoryItemLookUpEdit
                {
                    DataSource = dtChiTietPhieuNhap,
                    DisplayMember = "TenThuoc",  // Hiển thị tên thuốc trong ComboBox
                    ValueMember = "UniqueID",    // Sử dụng UniqueID để phân biệt các dòng
                    NullText = "Chọn tên thuốc"
                };

                // Thiết lập các cột hiển thị trong dropdown của LookUpEdit
                lookUpEditTenThuoc.PopulateColumns();
                lookUpEditTenThuoc.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";
                lookUpEditTenThuoc.Columns["IDThuoc"].Caption = "Mã Thuốc";
                lookUpEditTenThuoc.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";
                lookUpEditTenThuoc.Columns["QuyCach"].Caption = "Quy Cách";
                lookUpEditTenThuoc.Columns["SoLuong"].Caption = "Số Lượng";
                lookUpEditTenThuoc.Columns["GiaDonVi"].Caption = "Giá Đơn Vị";
                lookUpEditTenThuoc.Columns["NgayNhap"].Caption = "Ngày Nhập";
                lookUpEditTenThuoc.Columns["TenThuoc"].Caption = "Tên Thuốc";
                lookUpEditTenThuoc.Columns["UniqueID"].Visible = false; // Ẩn UniqueID

                // Xử lý sự kiện EditValueChanged để tự động điền dữ liệu khi chọn một dòng
                lookUpEditTenThuoc.EditValueChanged += (s, e) =>
                {
                    var editor = s as DevExpress.XtraEditors.LookUpEdit;
                    if (editor?.EditValue == null) return;

                    // Lấy thông tin từ dòng được chọn dựa trên UniqueID
                    DataRow selectedRow = (editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView)?.Row;
                    if (selectedRow != null)
                    {
                        // Điền dữ liệu vào các cột tương ứng trong GridView
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("IDThuoc", selectedRow["IDThuoc"]);
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("IDChiTietPhieuNhap", selectedRow["IDChiTietPhieuNhap"]);
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("SLTon", selectedRow["SoLuong"]);
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("NgayNhap", selectedRow["NgayNhap"]);
                    }
                };

                // Gán LookUpEdit vào cột "Tên thuốc"
                var colTenThuoc = gv_ThuocChuaSapXep.Columns["TenThuoc"];
                if (colTenThuoc != null)
                {
                    colTenThuoc.ColumnEdit = lookUpEditTenThuoc;
                }

                gv_ThuocChuaSapXep.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vào ComboBox: " + ex.Message);
            }
        }






        private void SapXepThuoc_Load(object sender, EventArgs e)
        {            
            AddColumnsToGridView();
            LoadComboBoxInTenThuocColumn();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataTable.NewRow();
            dataTable.Rows.Add(newRow);

            gv_ThuocChuaSapXep.FocusedRowHandle = gv_ThuocChuaSapXep.RowCount - 1;
            gv_ThuocChuaSapXep.FocusedColumn = gv_ThuocChuaSapXep.VisibleColumns[0];
            gv_ThuocChuaSapXep.ShowEditor();
        }

    
    }
}
