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
            this.TXB_matkhau = new System.Windows.Forms.TextBox();
            this.LB_manv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_sua = new System.Windows.Forms.Button();
            this.BTN_xoa = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TXB_manv
            // 
            this.TXB_manv.Location = new System.Drawing.Point(62, 62);
            this.TXB_manv.Name = "TXB_manv";
            this.TXB_manv.Size = new System.Drawing.Size(253, 22);
            this.TXB_manv.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TXB_matkhau
            // 
            this.TXB_matkhau.Location = new System.Drawing.Point(62, 148);
            this.TXB_matkhau.Name = "TXB_matkhau";
            this.TXB_matkhau.Size = new System.Drawing.Size(253, 22);
            this.TXB_matkhau.TabIndex = 2;
            // 
            // LB_manv
            // 
            this.LB_manv.AutoSize = true;
            this.LB_manv.Location = new System.Drawing.Point(59, 29);
            this.LB_manv.Name = "LB_manv";
            this.LB_manv.Size = new System.Drawing.Size(86, 16);
            this.LB_manv.TabIndex = 3;
            this.LB_manv.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu";
            // 
            // BTN_sua
            // 
            this.BTN_sua.Location = new System.Drawing.Point(666, 483);
            this.BTN_sua.Name = "BTN_sua";
            this.BTN_sua.Size = new System.Drawing.Size(114, 53);
            this.BTN_sua.TabIndex = 5;
            this.BTN_sua.Text = "Sửa";
            this.BTN_sua.UseVisualStyleBackColor = true;
            // 
            // BTN_xoa
            // 
            this.BTN_xoa.Location = new System.Drawing.Point(814, 483);
            this.BTN_xoa.Name = "BTN_xoa";
            this.BTN_xoa.Size = new System.Drawing.Size(114, 53);
            this.BTN_xoa.TabIndex = 6;
            this.BTN_xoa.Text = "Xóa";
            this.BTN_xoa.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(146, 206);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(169, 24);
            this.cbPosition.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(146, 269);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 22);
            this.tbName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(146, 340);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 12;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFeMale
            // 
            this.rbFeMale.AutoSize = true;
            this.rbFeMale.Location = new System.Drawing.Point(270, 340);
            this.rbFeMale.Name = "rbFeMale";
            this.rbFeMale.Size = new System.Drawing.Size(45, 20);
            this.rbFeMale.TabIndex = 13;
            this.rbFeMale.TabStop = true;
            this.rbFeMale.Text = "Nữ";
            this.rbFeMale.UseVisualStyleBackColor = true;
            // 
            // FormChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 557);
            this.Controls.Add(this.rbFeMale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.BTN_xoa);
            this.Controls.Add(this.BTN_sua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_manv);
            this.Controls.Add(this.TXB_matkhau);
            this.Controls.Add(this.TXB_manv);
            this.Name = "FormChiTietNhanVien";
            this.Text = "FormChiTietNhanVien";
            this.Load += new System.EventHandler(this.FormChiTietNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_manv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TXB_matkhau;
        private System.Windows.Forms.Label LB_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_sua;
        private System.Windows.Forms.Button BTN_xoa;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFeMale;
    }
}