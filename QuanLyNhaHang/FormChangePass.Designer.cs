namespace QuanLyNhaHang
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.TXB_manv = new System.Windows.Forms.TextBox();
            this.LB_manv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbErrorPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassConfirm = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_show1 = new System.Windows.Forms.Button();
            this.BTN_show2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_manv
            // 
            this.TXB_manv.Enabled = false;
            this.TXB_manv.Location = new System.Drawing.Point(202, 143);
            this.TXB_manv.Name = "TXB_manv";
            this.TXB_manv.ReadOnly = true;
            this.TXB_manv.Size = new System.Drawing.Size(349, 22);
            this.TXB_manv.TabIndex = 30;
            this.TXB_manv.TextChanged += new System.EventHandler(this.TXB_manv_TextChanged);
            // 
            // LB_manv
            // 
            this.LB_manv.AutoSize = true;
            this.LB_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_manv.Location = new System.Drawing.Point(199, 111);
            this.LB_manv.Name = "LB_manv";
            this.LB_manv.Size = new System.Drawing.Size(117, 22);
            this.LB_manv.TabIndex = 31;
            this.LB_manv.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mật khẩu mới";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(202, 214);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(349, 22);
            this.tbPass.TabIndex = 35;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // lbErrorPass
            // 
            this.lbErrorPass.AutoSize = true;
            this.lbErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPass.Location = new System.Drawing.Point(201, 242);
            this.lbErrorPass.Name = "lbErrorPass";
            this.lbErrorPass.Size = new System.Drawing.Size(185, 20);
            this.lbErrorPass.TabIndex = 36;
            this.lbErrorPass.Text = "Hãy nhập mật khẩu mới";
            this.lbErrorPass.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nhập lại mật khẩu mới";
            // 
            // tbPassConfirm
            // 
            this.tbPassConfirm.Location = new System.Drawing.Point(202, 322);
            this.tbPassConfirm.Name = "tbPassConfirm";
            this.tbPassConfirm.Size = new System.Drawing.Size(349, 22);
            this.tbPassConfirm.TabIndex = 39;
            this.tbPassConfirm.UseSystemPasswordChar = true;
            this.tbPassConfirm.TextChanged += new System.EventHandler(this.tbPassConfirm_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(318, 377);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(168, 43);
            this.btnAccept.TabIndex = 40;
            this.btnAccept.Text = "Xác nhận\r\n";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 46);
            this.label3.TabIndex = 41;
            this.label3.Text = "ĐỔI MẬT KHẨU";
            // 
            // BTN_show1
            // 
            this.BTN_show1.BackColor = System.Drawing.Color.LightGray;
            this.BTN_show1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_show1.FlatAppearance.BorderSize = 0;
            this.BTN_show1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_show1.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.BTN_show1.Image = ((System.Drawing.Image)(resources.GetObject("BTN_show1.Image")));
            this.BTN_show1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_show1.Location = new System.Drawing.Point(557, 214);
            this.BTN_show1.Name = "BTN_show1";
            this.BTN_show1.Size = new System.Drawing.Size(41, 23);
            this.BTN_show1.TabIndex = 42;
            this.BTN_show1.UseVisualStyleBackColor = false;
            this.BTN_show1.Click += new System.EventHandler(this.BTN_show1_Click);
            // 
            // BTN_show2
            // 
            this.BTN_show2.BackColor = System.Drawing.Color.LightGray;
            this.BTN_show2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_show2.FlatAppearance.BorderSize = 0;
            this.BTN_show2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_show2.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.BTN_show2.Image = ((System.Drawing.Image)(resources.GetObject("BTN_show2.Image")));
            this.BTN_show2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_show2.Location = new System.Drawing.Point(557, 321);
            this.BTN_show2.Name = "BTN_show2";
            this.BTN_show2.Size = new System.Drawing.Size(41, 23);
            this.BTN_show2.TabIndex = 43;
            this.BTN_show2.UseVisualStyleBackColor = false;
            this.BTN_show2.Click += new System.EventHandler(this.BTN_show2_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_show2);
            this.Controls.Add(this.BTN_show1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbPassConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbErrorPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_manv);
            this.Controls.Add(this.TXB_manv);
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_manv;
        private System.Windows.Forms.Label LB_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbErrorPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassConfirm;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_show1;
        private System.Windows.Forms.Button BTN_show2;
    }
}