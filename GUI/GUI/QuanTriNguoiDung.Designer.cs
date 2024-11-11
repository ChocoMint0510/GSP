namespace GUI
{
    partial class QuanTriNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ChucVu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CapLaiMatKhau = new System.Windows.Forms.Button();
            this.btn_CapNhatND = new System.Windows.Forms.Button();
            this.btn_XoaND = new System.Windows.Forms.Button();
            this.btn_ThemND = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgv_DanhSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 711);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_ChucVu);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txt_UserName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_HoTen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_MaNV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 265);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.Location = new System.Drawing.Point(273, 161);
            this.txt_ChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(183, 22);
            this.txt_ChucVu.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CapLaiMatKhau);
            this.groupBox1.Controls.Add(this.btn_CapNhatND);
            this.groupBox1.Controls.Add(this.btn_XoaND);
            this.groupBox1.Controls.Add(this.btn_ThemND);
            this.groupBox1.Location = new System.Drawing.Point(628, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(360, 257);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_CapLaiMatKhau
            // 
            this.btn_CapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapLaiMatKhau.Location = new System.Drawing.Point(212, 149);
            this.btn_CapLaiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapLaiMatKhau.Name = "btn_CapLaiMatKhau";
            this.btn_CapLaiMatKhau.Size = new System.Drawing.Size(102, 65);
            this.btn_CapLaiMatKhau.TabIndex = 5;
            this.btn_CapLaiMatKhau.Text = "Cấp Lại Mật Khẩu";
            this.btn_CapLaiMatKhau.UseVisualStyleBackColor = true;
            this.btn_CapLaiMatKhau.Click += new System.EventHandler(this.btn_CapLaiMatKhau_Click);
            // 
            // btn_CapNhatND
            // 
            this.btn_CapNhatND.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatND.Location = new System.Drawing.Point(44, 149);
            this.btn_CapNhatND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhatND.Name = "btn_CapNhatND";
            this.btn_CapNhatND.Size = new System.Drawing.Size(102, 65);
            this.btn_CapNhatND.TabIndex = 2;
            this.btn_CapNhatND.Text = "Cập nhật thông tin";
            this.btn_CapNhatND.UseVisualStyleBackColor = true;
            this.btn_CapNhatND.Click += new System.EventHandler(this.btn_CapNhatND_Click);
            // 
            // btn_XoaND
            // 
            this.btn_XoaND.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaND.Location = new System.Drawing.Point(212, 44);
            this.btn_XoaND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaND.Name = "btn_XoaND";
            this.btn_XoaND.Size = new System.Drawing.Size(102, 63);
            this.btn_XoaND.TabIndex = 1;
            this.btn_XoaND.Text = "Xoá Người Dùng";
            this.btn_XoaND.UseVisualStyleBackColor = true;
            this.btn_XoaND.Click += new System.EventHandler(this.btn_XoaND_Click);
            // 
            // btn_ThemND
            // 
            this.btn_ThemND.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemND.Location = new System.Drawing.Point(44, 43);
            this.btn_ThemND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemND.Name = "btn_ThemND";
            this.btn_ThemND.Size = new System.Drawing.Size(102, 63);
            this.btn_ThemND.TabIndex = 0;
            this.btn_ThemND.Text = "Thêm người dùng";
            this.btn_ThemND.UseVisualStyleBackColor = true;
            this.btn_ThemND.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Enabled = false;
            this.txt_UserName.Location = new System.Drawing.Point(273, 66);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(183, 22);
            this.txt_UserName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chức vụ";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(273, 110);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(183, 22);
            this.txt_HoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(273, 25);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(183, 22);
            this.txt_MaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AllowUserToAddRows = false;
            this.dgv_DanhSach.AllowUserToDeleteRows = false;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DanhSach.Location = new System.Drawing.Point(11, 319);
            this.dgv_DanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            this.dgv_DanhSach.RowHeadersWidth = 51;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(993, 382);
            this.dgv_DanhSach.TabIndex = 3;
            this.dgv_DanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Trị Người Dùng";
            // 
            // QuanTriNguoiDung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 713);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanTriNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanTriNguoiDung";
            this.Load += new System.EventHandler(this.QuanTriNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CapNhatND;
        private System.Windows.Forms.Button btn_XoaND;
        private System.Windows.Forms.Button btn_ThemND;
        private System.Windows.Forms.Button btn_CapLaiMatKhau;
        private System.Windows.Forms.TextBox txt_ChucVu;
    }
}