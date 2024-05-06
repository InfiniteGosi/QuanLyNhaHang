namespace QuanLyNhaHang
{
    partial class FormDanhSachMonAn
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
            this.BTN_themmonan = new System.Windows.Forms.Button();
            this.DGV_monan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monan)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_themmonan
            // 
            this.BTN_themmonan.Location = new System.Drawing.Point(805, 60);
            this.BTN_themmonan.Name = "BTN_themmonan";
            this.BTN_themmonan.Size = new System.Drawing.Size(114, 40);
            this.BTN_themmonan.TabIndex = 3;
            this.BTN_themmonan.Text = "Thêm Món ăn";
            this.BTN_themmonan.UseVisualStyleBackColor = true;
            this.BTN_themmonan.Click += new System.EventHandler(this.BTN_themmonan_Click);
            // 
            // DGV_monan
            // 
            this.DGV_monan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_monan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_monan.Location = new System.Drawing.Point(67, 121);
            this.DGV_monan.Name = "DGV_monan";
            this.DGV_monan.RowHeadersWidth = 51;
            this.DGV_monan.RowTemplate.Height = 24;
            this.DGV_monan.Size = new System.Drawing.Size(927, 431);
            this.DGV_monan.TabIndex = 2;
            this.DGV_monan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_monan_CellDoubleClick);
            // 
            // FormDanhSachMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 613);
            this.Controls.Add(this.BTN_themmonan);
            this.Controls.Add(this.DGV_monan);
            this.Name = "FormDanhSachMonAn";
            this.Text = "FormDanhSachThucDon";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_themmonan;
        private System.Windows.Forms.DataGridView DGV_monan;
    }
}