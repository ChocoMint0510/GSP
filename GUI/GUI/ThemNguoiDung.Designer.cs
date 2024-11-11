namespace GUI
{
    partial class ThemNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNguoiDung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addNguoiDung = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_PickPic = new System.Windows.Forms.Button();
            this.pb_Hinh = new System.Windows.Forms.PictureBox();
            this.txt_addTrinhDo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_addSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_addEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_addDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_addchucvu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_addTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_addMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_addTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addNguoiDung);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 737);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_addNguoiDung
            // 
            this.btn_addNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNguoiDung.Location = new System.Drawing.Point(353, 656);
            this.btn_addNguoiDung.Name = "btn_addNguoiDung";
            this.btn_addNguoiDung.Size = new System.Drawing.Size(138, 72);
            this.btn_addNguoiDung.TabIndex = 26;
            this.btn_addNguoiDung.Text = "Thêm Nhân Viên";
            this.btn_addNguoiDung.UseVisualStyleBackColor = true;
            this.btn_addNguoiDung.Click += new System.EventHandler(this.btn_addNguoiDung_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtp_NgaySinh);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.btn_PickPic);
            this.groupControl1.Controls.Add(this.pb_Hinh);
            this.groupControl1.Controls.Add(this.txt_addTrinhDo);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txt_addSDT);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txt_addEmail);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txt_addDiaChi);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cb_addchucvu);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_addTen);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(-2, 51);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(822, 354);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông Tin Cá Nhân";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(164, 123);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(224, 21);
            this.dtp_NgaySinh.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ngày Sinh:";
            // 
            // btn_PickPic
            // 
            this.btn_PickPic.Location = new System.Drawing.Point(587, 268);
            this.btn_PickPic.Name = "btn_PickPic";
            this.btn_PickPic.Size = new System.Drawing.Size(91, 50);
            this.btn_PickPic.TabIndex = 31;
            this.btn_PickPic.Text = "Chọn ảnh";
            this.btn_PickPic.UseVisualStyleBackColor = true;
            this.btn_PickPic.Click += new System.EventHandler(this.btn_PickPic_Click);
            // 
            // pb_Hinh
            // 
            this.pb_Hinh.Image = ((System.Drawing.Image)(resources.GetObject("pb_Hinh.Image")));
            this.pb_Hinh.Location = new System.Drawing.Point(529, 38);
            this.pb_Hinh.Name = "pb_Hinh";
            this.pb_Hinh.Size = new System.Drawing.Size(224, 203);
            this.pb_Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Hinh.TabIndex = 30;
            this.pb_Hinh.TabStop = false;
            // 
            // txt_addTrinhDo
            // 
            this.txt_addTrinhDo.Location = new System.Drawing.Point(164, 307);
            this.txt_addTrinhDo.Name = "txt_addTrinhDo";
            this.txt_addTrinhDo.Size = new System.Drawing.Size(222, 21);
            this.txt_addTrinhDo.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Trình Độ:";
            // 
            // txt_addSDT
            // 
            this.txt_addSDT.Location = new System.Drawing.Point(166, 258);
            this.txt_addSDT.Name = "txt_addSDT";
            this.txt_addSDT.Size = new System.Drawing.Size(222, 21);
            this.txt_addSDT.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Số Điện Thoại:";
            // 
            // txt_addEmail
            // 
            this.txt_addEmail.Location = new System.Drawing.Point(164, 213);
            this.txt_addEmail.Name = "txt_addEmail";
            this.txt_addEmail.Size = new System.Drawing.Size(222, 21);
            this.txt_addEmail.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email:";
            // 
            // txt_addDiaChi
            // 
            this.txt_addDiaChi.Location = new System.Drawing.Point(164, 168);
            this.txt_addDiaChi.Name = "txt_addDiaChi";
            this.txt_addDiaChi.Size = new System.Drawing.Size(222, 21);
            this.txt_addDiaChi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Địa Chỉ:";
            // 
            // cb_addchucvu
            // 
            this.cb_addchucvu.FormattingEnabled = true;
            this.cb_addchucvu.Location = new System.Drawing.Point(164, 80);
            this.cb_addchucvu.Name = "cb_addchucvu";
            this.cb_addchucvu.Size = new System.Drawing.Size(222, 21);
            this.cb_addchucvu.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Chức vụ:";
            // 
            // txt_addTen
            // 
            this.txt_addTen.Location = new System.Drawing.Point(164, 39);
            this.txt_addTen.Name = "txt_addTen";
            this.txt_addTen.Size = new System.Drawing.Size(222, 21);
            this.txt_addTen.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm Nhân Viên";
            // 
            // txt_XacNhanMatKhau
            // 
            this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(389, 155);
            this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(222, 21);
            this.txt_XacNhanMatKhau.TabIndex = 25;
            this.txt_XacNhanMatKhau.Text = "123";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txt_addMatKhau
            // 
            this.txt_addMatKhau.Location = new System.Drawing.Point(389, 115);
            this.txt_addMatKhau.Name = "txt_addMatKhau";
            this.txt_addMatKhau.Size = new System.Drawing.Size(222, 21);
            this.txt_addMatKhau.TabIndex = 23;
            this.txt_addMatKhau.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mật Khẩu:";
            // 
            // txt_addTenTK
            // 
            this.txt_addTenTK.Enabled = false;
            this.txt_addTenTK.Location = new System.Drawing.Point(389, 74);
            this.txt_addTenTK.Name = "txt_addTenTK";
            this.txt_addTenTK.Size = new System.Drawing.Size(222, 21);
            this.txt_addTenTK.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_XacNhanMatKhau);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.txt_addTenTK);
            this.groupControl2.Controls.Add(this.txt_addMatKhau);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Location = new System.Drawing.Point(2, 410);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(822, 241);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Thông Tin Tài Khoản";
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(831, 742);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addNguoiDung;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_XacNhanMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_addMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_addchucvu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_addTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addTenTK;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txt_addDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_PickPic;
        private System.Windows.Forms.PictureBox pb_Hinh;
        private System.Windows.Forms.TextBox txt_addTrinhDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_addSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_addEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label11;
    }
}