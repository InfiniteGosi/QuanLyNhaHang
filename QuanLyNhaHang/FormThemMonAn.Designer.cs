namespace QuanLyNhaHang
{
    partial class FormThemMonAn
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
            this.lbErrorGia = new System.Windows.Forms.Label();
            this.lbErrorTenMonAn = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbTenMonAn = new System.Windows.Forms.TextBox();
            this.lbtName = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbErrorGia);
            this.panel1.Controls.Add(this.lbErrorTenMonAn);
            this.panel1.Controls.Add(this.tbGia);
            this.panel1.Controls.Add(this.tbTenMonAn);
            this.panel1.Controls.Add(this.lbtName);
            this.panel1.Controls.Add(this.lbGia);
            this.panel1.Location = new System.Drawing.Point(179, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 273);
            this.panel1.TabIndex = 1;
            // 
            // lbErrorGia
            // 
            this.lbErrorGia.AutoSize = true;
            this.lbErrorGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorGia.ForeColor = System.Drawing.Color.Red;
            this.lbErrorGia.Location = new System.Drawing.Point(154, 196);
            this.lbErrorGia.Name = "lbErrorGia";
            this.lbErrorGia.Size = new System.Drawing.Size(197, 25);
            this.lbErrorGia.TabIndex = 15;
            this.lbErrorGia.Text = "Hãy nhập giá món ăn";
            this.lbErrorGia.Visible = false;
            // 
            // lbErrorTenMonAn
            // 
            this.lbErrorTenMonAn.AutoSize = true;
            this.lbErrorTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorTenMonAn.ForeColor = System.Drawing.Color.Red;
            this.lbErrorTenMonAn.Location = new System.Drawing.Point(153, 58);
            this.lbErrorTenMonAn.Name = "lbErrorTenMonAn";
            this.lbErrorTenMonAn.Size = new System.Drawing.Size(198, 25);
            this.lbErrorTenMonAn.TabIndex = 16;
            this.lbErrorTenMonAn.Text = "Hãy nhập tên món ăn";
            this.lbErrorTenMonAn.Visible = false;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(158, 171);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(266, 22);
            this.tbGia.TabIndex = 5;
            this.tbGia.TextChanged += new System.EventHandler(this.tbGia_TextChanged);
            // 
            // tbTenMonAn
            // 
            this.tbTenMonAn.Location = new System.Drawing.Point(158, 33);
            this.tbTenMonAn.Name = "tbTenMonAn";
            this.tbTenMonAn.Size = new System.Drawing.Size(266, 22);
            this.tbTenMonAn.TabIndex = 4;
            this.tbTenMonAn.TextChanged += new System.EventHandler(this.tbTenMonAn_TextChanged);
            // 
            // lbtName
            // 
            this.lbtName.AutoSize = true;
            this.lbtName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbtName.Location = new System.Drawing.Point(23, 33);
            this.lbtName.Name = "lbtName";
            this.lbtName.Size = new System.Drawing.Size(117, 25);
            this.lbtName.TabIndex = 2;
            this.lbtName.Text = "Tên món ăn";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbGia.Location = new System.Drawing.Point(98, 167);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(42, 25);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(353, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Xác nhận";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "THÊM MÓN ĂN";
            // 
            // FormThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "FormThemMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemMonAn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbErrorGia;
        private System.Windows.Forms.Label lbErrorTenMonAn;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbTenMonAn;
        private System.Windows.Forms.Label lbtName;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
    }
}