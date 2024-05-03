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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DTP_dat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_giao = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CBB_mabantrong
            // 
            this.CBB_mabantrong.FormattingEnabled = true;
            this.CBB_mabantrong.Location = new System.Drawing.Point(96, 75);
            this.CBB_mabantrong.Name = "CBB_mabantrong";
            this.CBB_mabantrong.Size = new System.Drawing.Size(198, 24);
            this.CBB_mabantrong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bàn còn trống";
            // 
            // TXB_hotenkhach
            // 
            this.TXB_hotenkhach.Location = new System.Drawing.Point(96, 197);
            this.TXB_hotenkhach.Name = "TXB_hotenkhach";
            this.TXB_hotenkhach.Size = new System.Drawing.Size(373, 22);
            this.TXB_hotenkhach.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại của khách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 22);
            this.textBox1.TabIndex = 4;
            // 
            // DTP_dat
            // 
            this.DTP_dat.Location = new System.Drawing.Point(704, 73);
            this.DTP_dat.Name = "DTP_dat";
            this.DTP_dat.Size = new System.Drawing.Size(292, 22);
            this.DTP_dat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày đặt bàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(699, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày nhận bàn";
            // 
            // DTP_giao
            // 
            this.DTP_giao.Location = new System.Drawing.Point(704, 195);
            this.DTP_giao.Name = "DTP_giao";
            this.DTP_giao.Size = new System.Drawing.Size(292, 22);
            this.DTP_giao.TabIndex = 8;
            // 
            // FormDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 660);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTP_giao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTP_dat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_hotenkhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBB_mabantrong);
            this.Name = "FormDatBan";
            this.Text = "FormDatBan";
            this.Load += new System.EventHandler(this.FormDatBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBB_mabantrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_hotenkhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DTP_dat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_giao;
    }
}