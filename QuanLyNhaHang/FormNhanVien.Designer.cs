﻿namespace QuanLyNhaHang
{
    partial class FormNhanVien
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
            this.btnChangePass = new System.Windows.Forms.Button();
            this.BTN_ban = new System.Windows.Forms.Button();
            this.BTN_monan = new System.Windows.Forms.Button();
            this.BTN_nhanvien = new System.Windows.Forms.Button();
            this.BTN_dangxuat = new System.Windows.Forms.Button();
            this.LB_xinchao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.BTN_ban);
            this.panel1.Controls.Add(this.BTN_monan);
            this.panel1.Controls.Add(this.BTN_nhanvien);
            this.panel1.Controls.Add(this.BTN_dangxuat);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 608);
            this.panel1.TabIndex = 0;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Honeydew;
            this.btnChangePass.Location = new System.Drawing.Point(0, 460);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(175, 78);
            this.btnChangePass.TabIndex = 1;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // BTN_ban
            // 
            this.BTN_ban.BackColor = System.Drawing.Color.Honeydew;
            this.BTN_ban.Location = new System.Drawing.Point(0, 98);
            this.BTN_ban.Name = "BTN_ban";
            this.BTN_ban.Size = new System.Drawing.Size(178, 92);
            this.BTN_ban.TabIndex = 3;
            this.BTN_ban.Text = "Danh sách bàn";
            this.BTN_ban.UseVisualStyleBackColor = false;
            this.BTN_ban.Click += new System.EventHandler(this.BTN_ban_Click);
            // 
            // BTN_monan
            // 
            this.BTN_monan.BackColor = System.Drawing.Color.Honeydew;
            this.BTN_monan.Location = new System.Drawing.Point(0, 196);
            this.BTN_monan.Name = "BTN_monan";
            this.BTN_monan.Size = new System.Drawing.Size(178, 92);
            this.BTN_monan.TabIndex = 2;
            this.BTN_monan.Text = "Danh sách món ăn";
            this.BTN_monan.UseVisualStyleBackColor = false;
            this.BTN_monan.Click += new System.EventHandler(this.BTN_thucdon_Click);
            // 
            // BTN_nhanvien
            // 
            this.BTN_nhanvien.BackColor = System.Drawing.Color.Honeydew;
            this.BTN_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.BTN_nhanvien.Name = "BTN_nhanvien";
            this.BTN_nhanvien.Size = new System.Drawing.Size(178, 92);
            this.BTN_nhanvien.TabIndex = 1;
            this.BTN_nhanvien.Text = "Danh sách nhân viên";
            this.BTN_nhanvien.UseVisualStyleBackColor = false;
            this.BTN_nhanvien.Click += new System.EventHandler(this.BTN_nhanvien_Click);
            // 
            // BTN_dangxuat
            // 
            this.BTN_dangxuat.Location = new System.Drawing.Point(3, 544);
            this.BTN_dangxuat.Name = "BTN_dangxuat";
            this.BTN_dangxuat.Size = new System.Drawing.Size(172, 61);
            this.BTN_dangxuat.TabIndex = 1;
            this.BTN_dangxuat.Text = "Đăng Xuất";
            this.BTN_dangxuat.UseVisualStyleBackColor = true;
            this.BTN_dangxuat.Click += new System.EventHandler(this.BTN_dangxuat_Click);
            // 
            // LB_xinchao
            // 
            this.LB_xinchao.AutoSize = true;
            this.LB_xinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_xinchao.Location = new System.Drawing.Point(186, 2);
            this.LB_xinchao.Name = "LB_xinchao";
            this.LB_xinchao.Size = new System.Drawing.Size(64, 25);
            this.LB_xinchao.TabIndex = 0;
            this.LB_xinchao.Text = "label1";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.LB_xinchao);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_xinchao;
        private System.Windows.Forms.Button BTN_dangxuat;
        private System.Windows.Forms.Button BTN_ban;
        private System.Windows.Forms.Button BTN_monan;
        private System.Windows.Forms.Button BTN_nhanvien;
        private System.Windows.Forms.Button btnChangePass;
    }
}