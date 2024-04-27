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
    public partial class FormNhanVien : Form
    {
        private NhanVien nhanVien;
        private bool isClosed = true;

        public FormNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LB_xinchao.Text = $"Xin chào {nhanVien.MaNhanVien} - {nhanVien.HoTen}";
        }

        private void BTN_dangxuat_Click(object sender, EventArgs e)
        {
            isClosed = false;
            Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosed)
                Application.Exit();
        }
    }
}
