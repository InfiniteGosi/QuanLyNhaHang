namespace QuanLyNhaHang
{
    partial class FormAddStaff
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
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.LB_manv = new System.Windows.Forms.Label();
            this.TXB_manv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lbErrorPass = new System.Windows.Forms.Label();
            this.lbErrorMaNhanVien = new System.Windows.Forms.Label();
            this.lbErrorName = new System.Windows.Forms.Label();
            this.lbErrorSex = new System.Windows.Forms.Label();
            this.lbPositon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbFeMale
            // 
            this.rbFeMale.AutoSize = true;
            this.rbFeMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeMale.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbFeMale.Location = new System.Drawing.Point(353, 346);
            this.rbFeMale.Name = "rbFeMale";
            this.rbFeMale.Size = new System.Drawing.Size(51, 24);
            this.rbFeMale.TabIndex = 23;
            this.rbFeMale.TabStop = true;
            this.rbFeMale.Text = "Nữ";
            this.rbFeMale.UseVisualStyleBackColor = true;
            this.rbFeMale.CheckedChanged += new System.EventHandler(this.rbFeMale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbMale.Location = new System.Drawing.Point(249, 343);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 24);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(136, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giới tính";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(249, 146);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(239, 22);
            this.tbName.TabIndex = 20;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(157, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(133, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chức vụ";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(249, 259);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(239, 24);
            this.cbPosition.TabIndex = 17;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // LB_manv
            // 
            this.LB_manv.AutoSize = true;
            this.LB_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_manv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LB_manv.Location = new System.Drawing.Point(97, 89);
            this.LB_manv.Name = "LB_manv";
            this.LB_manv.Size = new System.Drawing.Size(130, 25);
            this.LB_manv.TabIndex = 16;
            this.LB_manv.Text = "Mã nhân viên";
            // 
            // TXB_manv
            // 
            this.TXB_manv.Location = new System.Drawing.Point(249, 89);
            this.TXB_manv.Name = "TXB_manv";
            this.TXB_manv.Size = new System.Drawing.Size(239, 22);
            this.TXB_manv.TabIndex = 15;
            this.TXB_manv.TextChanged += new System.EventHandler(this.TXB_manv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(49, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mật khẩu mặc định";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(249, 195);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(239, 22);
            this.tbPass.TabIndex = 25;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccept.Location = new System.Drawing.Point(595, 399);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(119, 39);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbErrorPass
            // 
            this.lbErrorPass.AutoSize = true;
            this.lbErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPass.Location = new System.Drawing.Point(520, 195);
            this.lbErrorPass.Name = "lbErrorPass";
            this.lbErrorPass.Size = new System.Drawing.Size(153, 20);
            this.lbErrorPass.TabIndex = 27;
            this.lbErrorPass.Text = "Hãy nhập mật khẩu";
            this.lbErrorPass.Visible = false;
            // 
            // lbErrorMaNhanVien
            // 
            this.lbErrorMaNhanVien.AutoSize = true;
            this.lbErrorMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMaNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMaNhanVien.Location = new System.Drawing.Point(520, 91);
            this.lbErrorMaNhanVien.Name = "lbErrorMaNhanVien";
            this.lbErrorMaNhanVien.Size = new System.Drawing.Size(184, 20);
            this.lbErrorMaNhanVien.TabIndex = 28;
            this.lbErrorMaNhanVien.Text = "Hãy nhập mã nhân viên";
            this.lbErrorMaNhanVien.Visible = false;
            // 
            // lbErrorName
            // 
            this.lbErrorName.AutoSize = true;
            this.lbErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorName.Location = new System.Drawing.Point(520, 146);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(184, 20);
            this.lbErrorName.TabIndex = 29;
            this.lbErrorName.Text = "Hãy nhập tên nhân viên";
            this.lbErrorName.Visible = false;
            // 
            // lbErrorSex
            // 
            this.lbErrorSex.AutoSize = true;
            this.lbErrorSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorSex.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSex.Location = new System.Drawing.Point(433, 346);
            this.lbErrorSex.Name = "lbErrorSex";
            this.lbErrorSex.Size = new System.Drawing.Size(143, 20);
            this.lbErrorSex.TabIndex = 30;
            this.lbErrorSex.Text = "Hãy chọn giới tính";
            this.lbErrorSex.Visible = false;
            // 
            // lbPositon
            // 
            this.lbPositon.AutoSize = true;
            this.lbPositon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPositon.ForeColor = System.Drawing.Color.Red;
            this.lbPositon.Location = new System.Drawing.Point(520, 259);
            this.lbPositon.Name = "lbPositon";
            this.lbPositon.Size = new System.Drawing.Size(143, 20);
            this.lbPositon.TabIndex = 31;
            this.lbPositon.Text = "Hãy chọn chức vụ";
            this.lbPositon.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(214, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 46);
            this.label5.TabIndex = 32;
            this.label5.Text = "THÊM NHÂN VIÊN";
            // 
            // FormAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPositon);
            this.Controls.Add(this.lbErrorSex);
            this.Controls.Add(this.lbErrorName);
            this.Controls.Add(this.lbErrorMaNhanVien);
            this.Controls.Add(this.lbErrorPass);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFeMale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.LB_manv);
            this.Controls.Add(this.TXB_manv);
            this.Name = "FormAddStaff";
            this.Text = "FormAddStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbFeMale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label LB_manv;
        private System.Windows.Forms.TextBox TXB_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lbErrorPass;
        private System.Windows.Forms.Label lbErrorMaNhanVien;
        private System.Windows.Forms.Label lbErrorName;
        private System.Windows.Forms.Label lbErrorSex;
        private System.Windows.Forms.Label lbPositon;
        private System.Windows.Forms.Label label5;
    }
}