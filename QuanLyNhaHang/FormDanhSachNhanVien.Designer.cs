namespace QuanLyNhaHang
{
    partial class FormDanhSachNhanVien
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
            this.DGV_nhanvien = new System.Windows.Forms.DataGridView();
            this.BTN_themnv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_nhanvien
            // 
            this.DGV_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_nhanvien.Location = new System.Drawing.Point(77, 73);
            this.DGV_nhanvien.Name = "DGV_nhanvien";
            this.DGV_nhanvien.RowHeadersWidth = 51;
            this.DGV_nhanvien.RowTemplate.Height = 24;
            this.DGV_nhanvien.Size = new System.Drawing.Size(927, 431);
            this.DGV_nhanvien.TabIndex = 0;
            this.DGV_nhanvien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nhanvien_CellDoubleClick);
            // 
            // BTN_themnv
            // 
            this.BTN_themnv.Location = new System.Drawing.Point(815, 12);
            this.BTN_themnv.Name = "BTN_themnv";
            this.BTN_themnv.Size = new System.Drawing.Size(114, 40);
            this.BTN_themnv.TabIndex = 1;
            this.BTN_themnv.Text = "Thêm nhân viên";
            this.BTN_themnv.UseVisualStyleBackColor = true;
            this.BTN_themnv.Click += new System.EventHandler(this.BTN_themnv_Click);
            // 
            // FormDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 613);
            this.Controls.Add(this.BTN_themnv);
            this.Controls.Add(this.DGV_nhanvien);
            this.Name = "FormDanhSachNhanVien";
            this.Text = "FormDanhSachNhanVien";
            this.Load += new System.EventHandler(this.FormDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_nhanvien;
        private System.Windows.Forms.Button BTN_themnv;
    }
}