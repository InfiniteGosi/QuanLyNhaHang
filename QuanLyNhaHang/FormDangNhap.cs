using BLL;
using DTO;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void BTN_dangnhap_Click(object sender, EventArgs e)
        {
            string maNhanVien = TXB_manv.Text;
            string matKhau = TXB_mk.Text;
            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng nhập mã người dùng");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            if (NhanVienBLL.Instance.CheckAccountExistence(maNhanVien))
            {
                if (NhanVienBLL.Instance.CheckAccountPasword(maNhanVien, matKhau))
                {
                    NhanVien nhanVien = NhanVienBLL.Instance.GetAccount(maNhanVien);
                    FormNhanVien formNhanVien = new FormNhanVien(nhanVien);
                    formNhanVien.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
                return;
            }
        }


        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BTN_show_Click(object sender, EventArgs e)
        {
            if (TXB_mk.UseSystemPasswordChar == false)
                TXB_mk.UseSystemPasswordChar = true;
            else
                TXB_mk.UseSystemPasswordChar = false;
        }
    }
}
