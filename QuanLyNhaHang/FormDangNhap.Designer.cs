namespace QuanLyNhaHang
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_manv = new System.Windows.Forms.TextBox();
            this.TXB_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_dangnhap = new System.Windows.Forms.Button();
            this.BTN_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhà hàng Hokkaido Sachi";
            // 
            // TXB_manv
            // 
            this.TXB_manv.Location = new System.Drawing.Point(220, 171);
            this.TXB_manv.Name = "TXB_manv";
            this.TXB_manv.Size = new System.Drawing.Size(383, 22);
            this.TXB_manv.TabIndex = 1;
            // 
            // TXB_mk
            // 
            this.TXB_mk.Location = new System.Drawing.Point(220, 275);
            this.TXB_mk.Name = "TXB_mk";
            this.TXB_mk.Size = new System.Drawing.Size(383, 22);
            this.TXB_mk.TabIndex = 2;
            this.TXB_mk.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(215, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(215, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // BTN_dangnhap
            // 
            this.BTN_dangnhap.BackColor = System.Drawing.Color.LimeGreen;
            this.BTN_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_dangnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_dangnhap.Location = new System.Drawing.Point(339, 358);
            this.BTN_dangnhap.Name = "BTN_dangnhap";
            this.BTN_dangnhap.Size = new System.Drawing.Size(154, 67);
            this.BTN_dangnhap.TabIndex = 5;
            this.BTN_dangnhap.Text = "Đăng Nhập";
            this.BTN_dangnhap.UseVisualStyleBackColor = false;
            this.BTN_dangnhap.Click += new System.EventHandler(this.BTN_dangnhap_Click);
            // 
            // BTN_show
            // 
            this.BTN_show.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BTN_show.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_show.FlatAppearance.BorderSize = 0;
            this.BTN_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_show.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.BTN_show.Image = ((System.Drawing.Image)(resources.GetObject("BTN_show.Image")));
            this.BTN_show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_show.Location = new System.Drawing.Point(609, 274);
            this.BTN_show.Name = "BTN_show";
            this.BTN_show.Size = new System.Drawing.Size(41, 23);
            this.BTN_show.TabIndex = 34;
            this.BTN_show.UseVisualStyleBackColor = false;
            this.BTN_show.Click += new System.EventHandler(this.BTN_show_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_show);
            this.Controls.Add(this.BTN_dangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_mk);
            this.Controls.Add(this.TXB_manv);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_manv;
        private System.Windows.Forms.TextBox TXB_mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_dangnhap;
        private System.Windows.Forms.Button BTN_show;
    }
}