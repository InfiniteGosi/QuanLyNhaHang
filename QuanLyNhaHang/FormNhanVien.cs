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

        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            if (nhanVien.PhanQuyen == 0)
            {
                FormDanhSachNhanVien f = new FormDanhSachNhanVien(nhanVien, nhanVien.MaNhanVien); ;
                f.ShowDialog();
            }
            else if (nhanVien.PhanQuyen == 1)
            {
                MessageBox.Show("Bạn không được quyền vào phần này!");
                return;
            }
            else if (nhanVien.PhanQuyen == 2)
            {
                MessageBox.Show("Bạn không được quyền vào phần này!");
                return;
            }
        }

        private void BTN_thucdon_Click(object sender, EventArgs e)
        {
            if (nhanVien.PhanQuyen == 0)
            {
                FormDanhSachMonAn f = new FormDanhSachMonAn();
                f.ShowDialog();
            }
            else if (nhanVien.PhanQuyen == 1)
            {
                MessageBox.Show("Bạn không được quyền vào phần này!");
                return;
            }
            else if (nhanVien.PhanQuyen == 2)
            {
                FormDanhSachMonAn f = new FormDanhSachMonAn();
                f.ShowDialog();
            }
        }

        private void BTN_ban_Click(object sender, EventArgs e)
        {
            if (nhanVien.PhanQuyen == 0)
            {
                FormDanhSachBan f = new FormDanhSachBan();
                f.ShowDialog();
            }
            else if (nhanVien.PhanQuyen == 1)
            {
                FormDanhSachBan f = new FormDanhSachBan();
                f.ShowDialog();
            }
            else if (nhanVien.PhanQuyen == 2)
            {
                MessageBox.Show("Bạn không được quyền vào phần này!");
                return;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePass formChangePass = new FormChangePass(nhanVien.MaNhanVien);
            formChangePass.ShowDialog();
        }
    }
}
