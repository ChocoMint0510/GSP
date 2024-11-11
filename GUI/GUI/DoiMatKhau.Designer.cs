namespace GUI
{
    partial class DoiMatKhau
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
            this.txt_Huy = new System.Windows.Forms.Button();
            this.txt_DMKLuu = new System.Windows.Forms.Button();
            this.txt_CNPass = new System.Windows.Forms.TextBox();
            this.txt_NPass = new System.Windows.Forms.TextBox();
            this.txt_OPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.txt_Huy);
            this.panel1.Controls.Add(this.txt_DMKLuu);
            this.panel1.Controls.Add(this.txt_CNPass);
            this.panel1.Controls.Add(this.txt_NPass);
            this.panel1.Controls.Add(this.txt_OPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 553);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Huy
            // 
            this.txt_Huy.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Huy.Location = new System.Drawing.Point(318, 431);
            this.txt_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Huy.Name = "txt_Huy";
            this.txt_Huy.Size = new System.Drawing.Size(119, 55);
            this.txt_Huy.TabIndex = 20;
            this.txt_Huy.Text = "Huỷ";
            this.txt_Huy.UseVisualStyleBackColor = true;
            this.txt_Huy.Click += new System.EventHandler(this.txt_Huy_Click);
            // 
            // txt_DMKLuu
            // 
            this.txt_DMKLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DMKLuu.Location = new System.Drawing.Point(142, 431);
            this.txt_DMKLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DMKLuu.Name = "txt_DMKLuu";
            this.txt_DMKLuu.Size = new System.Drawing.Size(119, 55);
            this.txt_DMKLuu.TabIndex = 19;
            this.txt_DMKLuu.Text = "Lưu";
            this.txt_DMKLuu.UseVisualStyleBackColor = true;
            this.txt_DMKLuu.Click += new System.EventHandler(this.txt_DMKLuu_Click);
            // 
            // txt_CNPass
            // 
            this.txt_CNPass.Location = new System.Drawing.Point(279, 326);
            this.txt_CNPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CNPass.Name = "txt_CNPass";
            this.txt_CNPass.Size = new System.Drawing.Size(243, 22);
            this.txt_CNPass.TabIndex = 18;
            this.txt_CNPass.UseSystemPasswordChar = true;
            // 
            // txt_NPass
            // 
            this.txt_NPass.Location = new System.Drawing.Point(279, 273);
            this.txt_NPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NPass.Name = "txt_NPass";
            this.txt_NPass.Size = new System.Drawing.Size(243, 22);
            this.txt_NPass.TabIndex = 17;
            this.txt_NPass.UseSystemPasswordChar = true;
            // 
            // txt_OPass
            // 
            this.txt_OPass.Location = new System.Drawing.Point(279, 225);
            this.txt_OPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OPass.Name = "txt_OPass";
            this.txt_OPass.Size = new System.Drawing.Size(243, 22);
            this.txt_OPass.TabIndex = 16;
            this.txt_OPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // txt_Username
            // 
            this.txt_Username.Enabled = false;
            this.txt_Username.Location = new System.Drawing.Point(279, 179);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(243, 22);
            this.txt_Username.TabIndex = 21;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 551);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txt_DMKLuu;
        private System.Windows.Forms.TextBox txt_CNPass;
        private System.Windows.Forms.TextBox txt_NPass;
        private System.Windows.Forms.TextBox txt_OPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_Huy;
        private System.Windows.Forms.TextBox txt_Username;
    }
}