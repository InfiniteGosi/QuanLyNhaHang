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
    public partial class FormDanhSachNhanVien : Form
    {
        private NhanVien nhanVien;
        public FormDanhSachNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }
        private void DisplayDGV_nhanvien()
        {
            DGV_nhanvien.DataSource = NhanVienBLL.Instance.GetAllEmployee();

        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            DisplayDGV_nhanvien();
        }

        private void DGV_nhanvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGV_nhanvien.Rows.Count)
            {
                DataGridViewRow selectedRow = DGV_nhanvien.Rows[e.RowIndex];
                string maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                FormChiTietNhanVien f = new FormChiTietNhanVien(NhanVienBLL.Instance.GetAccount(maNhanVien));
                f.ShowDialog();
            }
        }
    }
}
