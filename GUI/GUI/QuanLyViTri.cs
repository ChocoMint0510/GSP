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
    public partial class QuanLyViTri : Form
    {
        private string username;
        private string password;
        public QuanLyViTri(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void btn_KhuVuc_Click(object sender, EventArgs e)
        {
            Khu formKhuVuc = new Khu(username,password);
            formKhuVuc.OnKhuAdded += AddGroupBoxForKhu;

            // Hiển thị form khu vực
            formKhuVuc.ShowDialog();
        }

        private void btn_Ke_Click(object sender, EventArgs e)
        {
            Ke formKe = new Ke();

            // Hiển thị form khu vực
            formKe.ShowDialog();
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            O formO = new O();

            // Hiển thị form khu vực
            formO.ShowDialog();
        }

        public void AddGroupBoxForKhu(string tenKhu)
        {
            // Tạo GroupBox mới với kích thước 350x250
            GroupBox newGroupBox = new GroupBox
            {
                Text = tenKhu,
                Width = 350,
                Height = 250
            };

            // Thêm GroupBox mới vào Panel1 của SplitContainerControl
            splitContainerControl1.Panel1.Controls.Add(newGroupBox);

            // Sắp xếp lại các GroupBox để đảm bảo tối đa 3 GroupBox mỗi hàng
            ArrangeGroupBoxes();
        }

        public void ArrangeGroupBoxes()
        {
            int groupBoxWidth = 350;
            int groupBoxHeight = 250;
            int spaceBetween = 20;
            int maxColumns = 3; // Số lượng GroupBox tối đa trên một dòng

            // Khởi tạo vị trí bắt đầu
            int xPosition = 10;
            int yPosition = 10;
            int column = 0;

            foreach (Control control in splitContainerControl1.Panel1.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    // Đặt vị trí mới cho GroupBox
                    groupBox.Location = new Point(xPosition, yPosition);

                    // Cập nhật vị trí cho GroupBox tiếp theo
                    column++;
                    if (column >= maxColumns)
                    {
                        column = 0;
                        xPosition = 10;
                        yPosition += groupBoxHeight + spaceBetween;
                    }
                    else
                    {
                        xPosition += groupBoxWidth + spaceBetween;
                    }
                }
            }
        }

        public void LoadAllKhuIntoGroupBoxes()
        {
            // Xóa các GroupBox cũ trong Panel1 để tránh chồng lấn khi tải lại
            splitContainerControl1.Panel1.Controls.Clear();

            // Lấy dữ liệu tất cả các khu từ cơ sở dữ liệu
            DataTable khuData = new KhuBLL(username, password).GetAllKhu();

            int groupBoxWidth = 350;
            int groupBoxHeight = 250;
            int spaceBetween = 20;
            int maxColumns = 3; // Số lượng GroupBox tối đa trên một dòng

            int xPosition = 10; // Vị trí X bắt đầu
            int yPosition = 10; // Vị trí Y bắt đầu
            int column = 0;

            foreach (DataRow row in khuData.Rows)
            {
                // Lấy tên khu từ dữ liệu
                string tenKhu = row["TenKhu"].ToString();

                // Tạo GroupBox mới cho mỗi khu
                GroupBox newGroupBox = new GroupBox
                {
                    Text = tenKhu,
                    Width = groupBoxWidth,
                    Height = groupBoxHeight,
                    Location = new Point(xPosition, yPosition)
                };

                // Thêm GroupBox vào Panel1 của SplitContainerControl
                splitContainerControl1.Panel1.Controls.Add(newGroupBox);

                // Cập nhật vị trí cho GroupBox tiếp theo
                column++;
                if (column >= maxColumns)
                {
                    // Chuyển sang dòng mới khi đạt tối đa GroupBox trên một hàng
                    column = 0;
                    xPosition = 10; // Reset lại vị trí X
                    yPosition += groupBoxHeight + spaceBetween; // Tăng vị trí Y để sang dòng mới
                }
                else
                {
                    // Tăng vị trí X cho GroupBox tiếp theo trong cùng một hàng
                    xPosition += groupBoxWidth + spaceBetween;
                }
            }
        }




        private void QuanLyViTri_Load(object sender, EventArgs e)
        {
            LoadAllKhuIntoGroupBoxes();
        }
    }
}
