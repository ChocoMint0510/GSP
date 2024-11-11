namespace GUI
{
    partial class QuanLyViTri
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_O = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Ke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_KhuVuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1129, 531);
            this.splitContainerControl1.SplitterPosition = 341;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1129, 180);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin vị trí";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_O);
            this.groupBox3.Location = new System.Drawing.Point(592, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(214, 115);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ô";
            // 
            // btn_O
            // 
            this.btn_O.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_O.ForeColor = System.Drawing.Color.White;
            this.btn_O.Location = new System.Drawing.Point(57, 40);
            this.btn_O.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_O.Name = "btn_O";
            this.btn_O.Size = new System.Drawing.Size(100, 35);
            this.btn_O.TabIndex = 1;
            this.btn_O.Text = "Quản lý ô";
            this.btn_O.UseVisualStyleBackColor = false;
            this.btn_O.Click += new System.EventHandler(this.btn_O_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Ke);
            this.groupBox2.Location = new System.Drawing.Point(312, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(214, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kệ";
            // 
            // btn_Ke
            // 
            this.btn_Ke.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Ke.ForeColor = System.Drawing.Color.White;
            this.btn_Ke.Location = new System.Drawing.Point(57, 40);
            this.btn_Ke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ke.Name = "btn_Ke";
            this.btn_Ke.Size = new System.Drawing.Size(100, 35);
            this.btn_Ke.TabIndex = 1;
            this.btn_Ke.Text = "Quản lý kệ";
            this.btn_Ke.UseVisualStyleBackColor = false;
            this.btn_Ke.Click += new System.EventHandler(this.btn_Ke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_KhuVuc);
            this.groupBox1.Location = new System.Drawing.Point(28, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(214, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực";
            // 
            // btn_KhuVuc
            // 
            this.btn_KhuVuc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_KhuVuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhuVuc.Location = new System.Drawing.Point(58, 44);
            this.btn_KhuVuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_KhuVuc.Name = "btn_KhuVuc";
            this.btn_KhuVuc.Size = new System.Drawing.Size(100, 35);
            this.btn_KhuVuc.TabIndex = 0;
            this.btn_KhuVuc.Text = "Quản lý khu vực";
            this.btn_KhuVuc.UseVisualStyleBackColor = false;
            this.btn_KhuVuc.Click += new System.EventHandler(this.btn_KhuVuc_Click);
            // 
            // QuanLyViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 531);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyViTri";
            this.Text = "QuanLyViTri";
            this.Load += new System.EventHandler(this.QuanLyViTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Button btn_Ke;
        private System.Windows.Forms.Button btn_KhuVuc;
    }
}