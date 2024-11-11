namespace GUI
{
    partial class CapNhat
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cb_updChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_updTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_updTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_updMaNV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cập Nhật Thông Tin";
            // 
            // cb_updChucVu
            // 
            this.cb_updChucVu.FormattingEnabled = true;
            this.cb_updChucVu.Location = new System.Drawing.Point(219, 247);
            this.cb_updChucVu.Name = "cb_updChucVu";
            this.cb_updChucVu.Size = new System.Drawing.Size(222, 24);
            this.cb_updChucVu.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chức vụ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_updTen
            // 
            this.txt_updTen.Location = new System.Drawing.Point(219, 196);
            this.txt_updTen.Name = "txt_updTen";
            this.txt_updTen.Size = new System.Drawing.Size(222, 23);
            this.txt_updTen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ và tên:";
            // 
            // txt_updTenTK
            // 
            this.txt_updTenTK.Enabled = false;
            this.txt_updTenTK.Location = new System.Drawing.Point(219, 146);
            this.txt_updTenTK.Name = "txt_updTenTK";
            this.txt_updTenTK.Size = new System.Drawing.Size(222, 23);
            this.txt_updTenTK.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // btn_updLuu
            // 
            this.btn_updLuu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updLuu.Appearance.Options.UseFont = true;
            this.btn_updLuu.Location = new System.Drawing.Point(155, 320);
            this.btn_updLuu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_updLuu.Name = "btn_updLuu";
            this.btn_updLuu.Size = new System.Drawing.Size(170, 69);
            this.btn_updLuu.TabIndex = 16;
            this.btn_updLuu.Text = "Lưu Thay Đổi";
            this.btn_updLuu.Click += new System.EventHandler(this.btn_updLuu_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(69, 95);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 23);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Mã Nhân Viên";
            // 
            // txt_updMaNV
            // 
            this.txt_updMaNV.Enabled = false;
            this.txt_updMaNV.Location = new System.Drawing.Point(219, 95);
            this.txt_updMaNV.Name = "txt_updMaNV";
            this.txt_updMaNV.Size = new System.Drawing.Size(222, 23);
            this.txt_updMaNV.TabIndex = 18;
            // 
            // CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 412);
            this.Controls.Add(this.txt_updMaNV);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_updLuu);
            this.Controls.Add(this.cb_updChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_updTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_updTenTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CapNhat";
            this.Text = "CapNhat";
            this.Load += new System.EventHandler(this.CapNhat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cb_updChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_updTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_updTenTK;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_updLuu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_updMaNV;
    }
}