namespace QuanLyNhaHang
{
    partial class FormDatBan
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
            this.CBB_mabantrong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_hotenkhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_sdtkhach = new System.Windows.Forms.TextBox();
            this.DTP_dat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_nhan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_them = new System.Windows.Forms.Button();
            this.LB_ehotenkhach = new System.Windows.Forms.Label();
            this.LB_esdtkhach = new System.Windows.Forms.Label();
            this.DGV_monandadat = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBB_datmonan = new System.Windows.Forms.ComboBox();
            this.BTN_themmonan = new System.Windows.Forms.Button();
            this.LB_emaban = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monandadat)).BeginInit();
            this.SuspendLayout();
            // 
            // CBB_mabantrong
            // 
            this.CBB_mabantrong.FormattingEnabled = true;
            this.CBB_mabantrong.Location = new System.Drawing.Point(90, 125);
            this.CBB_mabantrong.Name = "CBB_mabantrong";
            this.CBB_mabantrong.Size = new System.Drawing.Size(198, 24);
            this.CBB_mabantrong.TabIndex = 0;
            this.CBB_mabantrong.SelectedIndexChanged += new System.EventHandler(this.CBB_mabantrong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bàn còn trống";
            // 
            // TXB_hotenkhach
            // 
            this.TXB_hotenkhach.Location = new System.Drawing.Point(90, 209);
            this.TXB_hotenkhach.Name = "TXB_hotenkhach";
            this.TXB_hotenkhach.Size = new System.Drawing.Size(373, 22);
            this.TXB_hotenkhach.TabIndex = 2;
            this.TXB_hotenkhach.TextChanged += new System.EventHandler(this.TXB_hotenkhach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại của khách";
            // 
            // TXB_sdtkhach
            // 
            this.TXB_sdtkhach.Location = new System.Drawing.Point(90, 309);
            this.TXB_sdtkhach.Name = "TXB_sdtkhach";
            this.TXB_sdtkhach.Size = new System.Drawing.Size(373, 22);
            this.TXB_sdtkhach.TabIndex = 4;
            this.TXB_sdtkhach.TextChanged += new System.EventHandler(this.TXB_sdtkhach_TextChanged);
            // 
            // DTP_dat
            // 
            this.DTP_dat.Location = new System.Drawing.Point(90, 434);
            this.DTP_dat.Name = "DTP_dat";
            this.DTP_dat.Size = new System.Drawing.Size(292, 22);
            this.DTP_dat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày đặt bàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày nhận bàn";
            // 
            // DTP_nhan
            // 
            this.DTP_nhan.Location = new System.Drawing.Point(90, 535);
            this.DTP_nhan.Name = "DTP_nhan";
            this.DTP_nhan.Size = new System.Drawing.Size(292, 22);
            this.DTP_nhan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 54);
            this.label6.TabIndex = 10;
            this.label6.Text = "ĐẶT BÀN";
            // 
            // BTN_them
            // 
            this.BTN_them.Location = new System.Drawing.Point(903, 598);
            this.BTN_them.Name = "BTN_them";
            this.BTN_them.Size = new System.Drawing.Size(145, 42);
            this.BTN_them.TabIndex = 11;
            this.BTN_them.Text = "Lưu";
            this.BTN_them.UseVisualStyleBackColor = true;
            this.BTN_them.Click += new System.EventHandler(this.BTN_them_Click);
            // 
            // LB_ehotenkhach
            // 
            this.LB_ehotenkhach.AutoSize = true;
            this.LB_ehotenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ehotenkhach.ForeColor = System.Drawing.Color.Red;
            this.LB_ehotenkhach.Location = new System.Drawing.Point(90, 234);
            this.LB_ehotenkhach.Name = "LB_ehotenkhach";
            this.LB_ehotenkhach.Size = new System.Drawing.Size(210, 20);
            this.LB_ehotenkhach.TabIndex = 13;
            this.LB_ehotenkhach.Text = "Vui lòng nhập họ tên khách";
            this.LB_ehotenkhach.Visible = false;
            // 
            // LB_esdtkhach
            // 
            this.LB_esdtkhach.AutoSize = true;
            this.LB_esdtkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_esdtkhach.ForeColor = System.Drawing.Color.Red;
            this.LB_esdtkhach.Location = new System.Drawing.Point(91, 334);
            this.LB_esdtkhach.Name = "LB_esdtkhach";
            this.LB_esdtkhach.Size = new System.Drawing.Size(259, 20);
            this.LB_esdtkhach.TabIndex = 14;
            this.LB_esdtkhach.Text = "Vui lòng nhập số điện thoại khách";
            this.LB_esdtkhach.Visible = false;
            // 
            // DGV_monandadat
            // 
            this.DGV_monandadat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_monandadat.Location = new System.Drawing.Point(556, 218);
            this.DGV_monandadat.Name = "DGV_monandadat";
            this.DGV_monandadat.ReadOnly = true;
            this.DGV_monandadat.RowHeadersWidth = 51;
            this.DGV_monandadat.RowTemplate.Height = 24;
            this.DGV_monandadat.Size = new System.Drawing.Size(458, 327);
            this.DGV_monandadat.TabIndex = 15;
            this.DGV_monandadat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_monandadat_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Danh sách món ăn đã đặt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chọn món ăn";
            // 
            // CBB_datmonan
            // 
            this.CBB_datmonan.FormattingEnabled = true;
            this.CBB_datmonan.Location = new System.Drawing.Point(718, 112);
            this.CBB_datmonan.Name = "CBB_datmonan";
            this.CBB_datmonan.Size = new System.Drawing.Size(296, 24);
            this.CBB_datmonan.TabIndex = 18;
            // 
            // BTN_themmonan
            // 
            this.BTN_themmonan.Location = new System.Drawing.Point(901, 152);
            this.BTN_themmonan.Name = "BTN_themmonan";
            this.BTN_themmonan.Size = new System.Drawing.Size(113, 32);
            this.BTN_themmonan.TabIndex = 19;
            this.BTN_themmonan.Text = "Thêm món ăn";
            this.BTN_themmonan.UseVisualStyleBackColor = true;
            this.BTN_themmonan.Click += new System.EventHandler(this.BTN_themmonan_Click);
            // 
            // LB_emaban
            // 
            this.LB_emaban.AutoSize = true;
            this.LB_emaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_emaban.ForeColor = System.Drawing.Color.Red;
            this.LB_emaban.Location = new System.Drawing.Point(91, 152);
            this.LB_emaban.Name = "LB_emaban";
            this.LB_emaban.Size = new System.Drawing.Size(245, 20);
            this.LB_emaban.TabIndex = 20;
            this.LB_emaban.Text = "Vui lòng chọn mã bàn còn trống";
            this.LB_emaban.Visible = false;
            // 
            // FormDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 664);
            this.Controls.Add(this.LB_emaban);
            this.Controls.Add(this.BTN_themmonan);
            this.Controls.Add(this.CBB_datmonan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV_monandadat);
            this.Controls.Add(this.LB_esdtkhach);
            this.Controls.Add(this.LB_ehotenkhach);
            this.Controls.Add(this.BTN_them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTP_nhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTP_dat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXB_sdtkhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_hotenkhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBB_mabantrong);
            this.Name = "FormDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatBan";
            this.Load += new System.EventHandler(this.FormDatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monandadat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBB_mabantrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_hotenkhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_sdtkhach;
        private System.Windows.Forms.DateTimePicker DTP_dat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_nhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_them;
        private System.Windows.Forms.Label LB_ehotenkhach;
        private System.Windows.Forms.Label LB_esdtkhach;
        private System.Windows.Forms.DataGridView DGV_monandadat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBB_datmonan;
        private System.Windows.Forms.Button BTN_themmonan;
        private System.Windows.Forms.Label LB_emaban;
    }
}