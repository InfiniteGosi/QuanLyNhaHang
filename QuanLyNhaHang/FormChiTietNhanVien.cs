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
    public partial class FormChiTietNhanVien : Form
    {
        private NhanVien nhanVien;
        public FormChiTietNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }
        private void DisplayEmployeeInfo()
        {
            TXB_manv.Text = nhanVien.MaNhanVien;
            //Code thêm ở đây
        }
        private void FormChiTietNhanVien_Load(object sender, EventArgs e)
        {
            DisplayEmployeeInfo();
        }
    }
}
