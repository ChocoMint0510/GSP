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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addNguoiDung = new System.Windows.Forms.Button();
            this.txt_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_addMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_addchucvu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_addTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_addTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addNguoiDung);
            this.panel1.Controls.Add(this.txt_XacNhanMatKhau);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_addMatKhau);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_addchucvu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_addTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_addTenTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_addNguoiDung
            // 
            this.btn_addNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNguoiDung.Location = new System.Drawing.Point(151, 354);
            this.btn_addNguoiDung.Name = "btn_addNguoiDung";
            this.btn_addNguoiDung.Size = new System.Drawing.Size(138, 72);
            this.btn_addNguoiDung.TabIndex = 15;
            this.btn_addNguoiDung.Text = "Thêm Người Dùng";
            this.btn_addNguoiDung.UseVisualStyleBackColor = true;
            this.btn_addNguoiDung.Click += new System.EventHandler(this.btn_addNguoiDung_Click);
            // 
            // txt_XacNhanMatKhau
            // 
            this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(185, 273);
            this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(222, 22);
            this.txt_XacNhanMatKhau.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txt_addMatKhau
            // 
            this.txt_addMatKhau.Location = new System.Drawing.Point(185, 232);
            this.txt_addMatKhau.Name = "txt_addMatKhau";
            this.txt_addMatKhau.Size = new System.Drawing.Size(222, 22);
            this.txt_addMatKhau.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mật Khẩu:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cb_addchucvu
            // 
            this.cb_addchucvu.FormattingEnabled = true;
            this.cb_addchucvu.Location = new System.Drawing.Point(185, 152);
            this.cb_addchucvu.Name = "cb_addchucvu";
            this.cb_addchucvu.Size = new System.Drawing.Size(222, 24);
            this.cb_addchucvu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chức vụ:";
            // 
            // txt_addTen
            // 
            this.txt_addTen.Location = new System.Drawing.Point(185, 111);
            this.txt_addTen.Name = "txt_addTen";
            this.txt_addTen.Size = new System.Drawing.Size(222, 22);
            this.txt_addTen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên:";
            // 
            // txt_addTenTK
            // 
            this.txt_addTenTK.Location = new System.Drawing.Point(185, 192);
            this.txt_addTenTK.Name = "txt_addTenTK";
            this.txt_addTenTK.Size = new System.Drawing.Size(222, 22);
            this.txt_addTenTK.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm Người Dùng";
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(456, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_addTenTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_addTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_addchucvu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addNguoiDung;
        private System.Windows.Forms.TextBox txt_XacNhanMatKhau;
        private System.Windows.Forms.Label label7;
    }
}