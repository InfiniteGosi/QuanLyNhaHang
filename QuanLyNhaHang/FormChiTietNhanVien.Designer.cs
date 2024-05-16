namespace QuanLyNhaHang
{
    partial class FormChiTietNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.TXB_manv = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LB_manv = new System.Windows.Forms.Label();
            this.BTN_sua = new System.Windows.Forms.Button();
            this.BTN_xoa = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.lbErrorMaNhanVien = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbErrorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_manv
            // 
            this.TXB_manv.Location = new System.Drawing.Point(307, 153);
            this.TXB_manv.Name = "TXB_manv";
            this.TXB_manv.ReadOnly = true;
            this.TXB_manv.Size = new System.Drawing.Size(372, 22);
            this.TXB_manv.TabIndex = 0;
            this.TXB_manv.TextChanged += new System.EventHandler(this.TXB_manv_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LB_manv
            // 
            this.LB_manv.AutoSize = true;
            this.LB_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_manv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LB_manv.Location = new System.Drawing.Point(304, 120);
            this.LB_manv.Name = "LB_manv";
            this.LB_manv.Size = new System.Drawing.Size(130, 25);
            this.LB_manv.TabIndex = 3;
            this.LB_manv.Text = "Mã nhân viên";
            // 
            // BTN_sua
            // 
            this.BTN_sua.BackColor = System.Drawing.Color.Blue;
            this.BTN_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_sua.Location = new System.Drawing.Point(686, 476);
            this.BTN_sua.Name = "BTN_sua";
            this.BTN_sua.Size = new System.Drawing.Size(96, 42);
            this.BTN_sua.TabIndex = 5;
            this.BTN_sua.Text = "Sửa";
            this.BTN_sua.UseVisualStyleBackColor = false;
            this.BTN_sua.Click += new System.EventHandler(this.BTN_sua_Click);
            // 
            // BTN_xoa
            // 
            this.BTN_xoa.BackColor = System.Drawing.Color.Red;
            this.BTN_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_xoa.Location = new System.Drawing.Point(821, 476);
            this.BTN_xoa.Name = "BTN_xoa";
            this.BTN_xoa.Size = new System.Drawing.Size(91, 42);
            this.BTN_xoa.TabIndex = 6;
            this.BTN_xoa.Text = "Xóa";
            this.BTN_xoa.UseVisualStyleBackColor = false;
            this.BTN_xoa.Click += new System.EventHandler(this.BTN_xoa_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(414, 215);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(265, 24);
            this.cbPosition.TabIndex = 7;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(305, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(305, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(414, 291);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(265, 22);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(305, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbMale.Location = new System.Drawing.Point(414, 382);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(74, 29);
            this.rbMale.TabIndex = 12;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFeMale
            // 
            this.rbFeMale.AutoSize = true;
            this.rbFeMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeMale.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbFeMale.Location = new System.Drawing.Point(515, 382);
            this.rbFeMale.Name = "rbFeMale";
            this.rbFeMale.Size = new System.Drawing.Size(58, 29);
            this.rbFeMale.TabIndex = 13;
            this.rbFeMale.TabStop = true;
            this.rbFeMale.Text = "Nữ";
            this.rbFeMale.UseVisualStyleBackColor = true;
            this.rbFeMale.CheckedChanged += new System.EventHandler(this.rbFeMale_CheckedChanged);
            // 
            // lbErrorMaNhanVien
            // 
            this.lbErrorMaNhanVien.AutoSize = true;
            this.lbErrorMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMaNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMaNhanVien.Location = new System.Drawing.Point(303, 178);
            this.lbErrorMaNhanVien.Name = "lbErrorMaNhanVien";
            this.lbErrorMaNhanVien.Size = new System.Drawing.Size(314, 25);
            this.lbErrorMaNhanVien.TabIndex = 14;
            this.lbErrorMaNhanVien.Text = "Không được xóa tài khoản của bạn";
            this.lbErrorMaNhanVien.Visible = false;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Location = new System.Drawing.Point(515, 459);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(125, 77);
            this.btnResetPass.TabIndex = 15;
            this.btnResetPass.Text = "Đặt lại mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Visible = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "CHI TIẾT NHÂN VIÊN";
            // 
            // lbErrorName
            // 
            this.lbErrorName.AutoSize = true;
            this.lbErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorName.Location = new System.Drawing.Point(305, 316);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(218, 25);
            this.lbErrorName.TabIndex = 17;
            this.lbErrorName.Text = "Hãy nhập tên nhân viên";
            this.lbErrorName.Visible = false;
            // 
            // FormChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(956, 557);
            this.Controls.Add(this.lbErrorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.lbErrorMaNhanVien);
            this.Controls.Add(this.rbFeMale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.BTN_xoa);
            this.Controls.Add(this.BTN_sua);
            this.Controls.Add(this.LB_manv);
            this.Controls.Add(this.TXB_manv);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "FormChiTietNhanVien";
            this.Text = "FormChiTietNhanVien";
            this.Load += new System.EventHandler(this.FormChiTietNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_manv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LB_manv;
        private System.Windows.Forms.Button BTN_sua;
        private System.Windows.Forms.Button BTN_xoa;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFeMale;
        private System.Windows.Forms.Label lbErrorMaNhanVien;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbErrorName;
    }
}