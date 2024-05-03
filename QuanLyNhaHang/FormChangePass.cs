using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FormChangePass : Form
    {
        private string maNhanvien = "";
        public FormChangePass(string maNhanvien)
        {
            InitializeComponent();
            this.maNhanvien = maNhanvien;
            TXB_manv.Text=maNhanvien;
        }
        public FormChangePass()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int checkError = 0;
            if (!tbPass.Text.Equals(tbPassConfirm.Text))
            {
                lbErrorPass.Text = "Hai mật khẩu không trùng khớp";
                lbErrorPass.Visible = true;
                checkError++;
            }
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                lbErrorPass.Text = "Hãy nhập mật khẩu mới";
                lbErrorPass.Visible = true;
                checkError ++;
            }
            if (checkError> 0){
                return;
            }
            else
            {
                lbErrorPass.Visible = false;
                if (MessageBox.Show(string.Format("Bạn có chắc Muốn đổi mật khẩu không"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    NhanVienDAO.Instance.ChangePassWord(TXB_manv.Text,tbPass.Text);
                    MessageBox.Show("Đặt lại mật khẩu thành công");
                }
            }
        }

        private void TXB_manv_TextChanged(object sender, EventArgs e)
        {
            lbErrorPass.Visible = false;
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            lbErrorPass.Visible = false;
        }

        private void tbPassConfirm_TextChanged(object sender, EventArgs e)
        {
            lbErrorPass.Visible = false;
        }
    }
}
