namespace GUI
{
    partial class Khu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khu));
            this.txt_GhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKhu = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cb_Kho = new System.Windows.Forms.ComboBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_LamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.gc_Khu = new DevExpress.XtraGrid.GridControl();
            this.gv_Khu = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Khu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Khu)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Enabled = false;
            this.txt_GhiChu.Location = new System.Drawing.Point(487, 124);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(161, 22);
            this.txt_GhiChu.TabIndex = 7;
            // 
            // txt_TenKhu
            // 
            this.txt_TenKhu.Enabled = false;
            this.txt_TenKhu.Location = new System.Drawing.Point(165, 124);
            this.txt_TenKhu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhu.Name = "txt_TenKhu";
            this.txt_TenKhu.Size = new System.Drawing.Size(219, 22);
            this.txt_TenKhu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kí hiệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_GhiChu);
            this.groupControl1.Controls.Add(this.txt_TenKhu);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cb_Kho);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(831, 210);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // cb_Kho
            // 
            this.cb_Kho.Enabled = false;
            this.cb_Kho.FormattingEnabled = true;
            this.cb_Kho.Location = new System.Drawing.Point(165, 67);
            this.cb_Kho.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Kho.Name = "cb_Kho";
            this.cb_Kho.Size = new System.Drawing.Size(483, 24);
            this.cb_Kho.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 27);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gc_Khu);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(831, 554);
            this.splitContainerControl1.SplitterPosition = 332;
            this.splitContainerControl1.TabIndex = 30;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(29, 24);
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(29, 24);
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(29, 24);
            this.btn_Xoa.Text = "Xóa";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Them
            // 
            this.btn_Them.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(29, 24);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.toolStripSeparator1,
            this.btn_Xoa,
            this.toolStripSeparator3,
            this.btn_LamMoi,
            this.toolStripSeparator4,
            this.btn_Luu,
            this.toolStripSeparator5,
            this.btn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(831, 27);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Luu
            // 
            this.btn_Luu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(29, 24);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // gc_Khu
            // 
            this.gc_Khu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Khu.Location = new System.Drawing.Point(0, 0);
            this.gc_Khu.MainView = this.gv_Khu;
            this.gc_Khu.Name = "gc_Khu";
            this.gc_Khu.Size = new System.Drawing.Size(831, 332);
            this.gc_Khu.TabIndex = 0;
            this.gc_Khu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Khu});
            // 
            // gv_Khu
            // 
            this.gv_Khu.GridControl = this.gc_Khu;
            this.gv_Khu.Name = "gv_Khu";
            // 
            // Khu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 581);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Khu";
            this.Text = "Khu";
            this.Load += new System.EventHandler(this.Khu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Khu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Khu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_GhiChu;
        private DevExpress.XtraEditors.TextEdit txt_TenKhu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cb_Kho;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ToolStripButton btn_Thoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_LamMoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private DevExpress.XtraGrid.GridControl gc_Khu;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Khu;
    }
}