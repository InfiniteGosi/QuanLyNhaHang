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
            this.panel1.Location = new System.Drawing.Point(179, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 339);
            this.panel1.TabIndex = 1;
            // 
            // lbErrorGia
            // 
            this.lbErrorGia.AutoSize = true;
            this.lbErrorGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorGia.ForeColor = System.Drawing.Color.Red;
            this.lbErrorGia.Location = new System.Drawing.Point(129, 215);
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
            this.lbErrorTenMonAn.Location = new System.Drawing.Point(128, 109);
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
            this.tbGia.Size = new System.Drawing.Size(160, 22);
            this.tbGia.TabIndex = 5;
            this.tbGia.TextChanged += new System.EventHandler(this.tbGia_TextChanged);
            // 
            // tbTenMonAn
            // 
            this.tbTenMonAn.Location = new System.Drawing.Point(158, 57);
            this.tbTenMonAn.Name = "tbTenMonAn";
            this.tbTenMonAn.Size = new System.Drawing.Size(160, 22);
            this.tbTenMonAn.TabIndex = 4;
            this.tbTenMonAn.TextChanged += new System.EventHandler(this.tbTenMonAn_TextChanged);
            // 
            // lbtName
            // 
            this.lbtName.AutoSize = true;
            this.lbtName.Location = new System.Drawing.Point(23, 57);
            this.lbtName.Name = "lbtName";
            this.lbtName.Size = new System.Drawing.Size(78, 16);
            this.lbtName.TabIndex = 2;
            this.lbtName.Text = "Tên món ăn";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(23, 177);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(28, 16);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(492, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Xác nhận";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "FormThemMonAn";
            this.Text = "FormThemMonAn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}