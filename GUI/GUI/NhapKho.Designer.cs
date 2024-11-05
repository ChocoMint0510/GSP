namespace GUI
{
    partial class NhapKho
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IDPM = new System.Windows.Forms.TextBox();
            this.txt_GiaTriDH = new System.Windows.Forms.TextBox();
            this.cb_NguoiNhap = new System.Windows.Forms.ComboBox();
            this.cb_Khuvuc = new System.Windows.Forms.ComboBox();
            this.dt_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(386, 69);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(442, 292);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Phiếu nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Khu vực lưu trữ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Người nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giá trị đơn hàng:";
            // 
            // txt_IDPM
            // 
            this.txt_IDPM.Location = new System.Drawing.Point(143, 81);
            this.txt_IDPM.Name = "txt_IDPM";
            this.txt_IDPM.Size = new System.Drawing.Size(200, 20);
            this.txt_IDPM.TabIndex = 8;
            // 
            // txt_GiaTriDH
            // 
            this.txt_GiaTriDH.Location = new System.Drawing.Point(143, 239);
            this.txt_GiaTriDH.Name = "txt_GiaTriDH";
            this.txt_GiaTriDH.Size = new System.Drawing.Size(200, 20);
            this.txt_GiaTriDH.TabIndex = 9;
            // 
            // cb_NguoiNhap
            // 
            this.cb_NguoiNhap.FormattingEnabled = true;
            this.cb_NguoiNhap.Location = new System.Drawing.Point(143, 198);
            this.cb_NguoiNhap.Name = "cb_NguoiNhap";
            this.cb_NguoiNhap.Size = new System.Drawing.Size(200, 21);
            this.cb_NguoiNhap.TabIndex = 10;
            // 
            // cb_Khuvuc
            // 
            this.cb_Khuvuc.FormattingEnabled = true;
            this.cb_Khuvuc.Location = new System.Drawing.Point(143, 159);
            this.cb_Khuvuc.Name = "cb_Khuvuc";
            this.cb_Khuvuc.Size = new System.Drawing.Size(200, 21);
            this.cb_Khuvuc.TabIndex = 11;
            // 
            // dt_NgayNhap
            // 
            this.dt_NgayNhap.Location = new System.Drawing.Point(143, 122);
            this.dt_NgayNhap.Name = "dt_NgayNhap";
            this.dt_NgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dt_NgayNhap.TabIndex = 12;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(26, 331);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 30);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(153, 331);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(84, 30);
            this.btn_CapNhat.TabIndex = 14;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Chi tiết nhập kho";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng:";
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(143, 274);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(200, 20);
            this.txt_TinhTrang.TabIndex = 17;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 429);
            this.Controls.Add(this.txt_TinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dt_NgayNhap);
            this.Controls.Add(this.cb_Khuvuc);
            this.Controls.Add(this.cb_NguoiNhap);
            this.Controls.Add(this.txt_GiaTriDH);
            this.Controls.Add(this.txt_IDPM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhapKho";
            this.Text = "NhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IDPM;
        private System.Windows.Forms.TextBox txt_GiaTriDH;
        private System.Windows.Forms.ComboBox cb_NguoiNhap;
        private System.Windows.Forms.ComboBox cb_Khuvuc;
        private System.Windows.Forms.DateTimePicker dt_NgayNhap;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TinhTrang;
    }
}