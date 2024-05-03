namespace QuanLyNhaHang
{
    partial class FormDanhSachBan
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
            this.DGV_ban = new System.Windows.Forms.DataGridView();
            this.BTN_datban = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ban)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ban
            // 
            this.DGV_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ban.Location = new System.Drawing.Point(85, 88);
            this.DGV_ban.Name = "DGV_ban";
            this.DGV_ban.RowHeadersWidth = 51;
            this.DGV_ban.RowTemplate.Height = 24;
            this.DGV_ban.Size = new System.Drawing.Size(898, 406);
            this.DGV_ban.TabIndex = 0;
            // 
            // BTN_datban
            // 
            this.BTN_datban.Location = new System.Drawing.Point(878, 22);
            this.BTN_datban.Name = "BTN_datban";
            this.BTN_datban.Size = new System.Drawing.Size(87, 42);
            this.BTN_datban.TabIndex = 1;
            this.BTN_datban.Text = "Đặt bàn";
            this.BTN_datban.UseVisualStyleBackColor = true;
            // 
            // FormDanhSachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 613);
            this.Controls.Add(this.BTN_datban);
            this.Controls.Add(this.DGV_ban);
            this.Name = "FormDanhSachBan";
            this.Text = "FormDanhSachBan";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ban;
        private System.Windows.Forms.Button BTN_datban;
    }
}