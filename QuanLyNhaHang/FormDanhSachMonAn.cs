using BLL;
using DAO;
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
    public partial class FormDanhSachMonAn : Form
    {
        private NhanVien nhanVien;
        public FormDanhSachMonAn(NhanVien nhanVien)
        {
            InitializeComponent();
            ShowListMonAn();
            this.nhanVien = nhanVien;
        }
        public void ShowListMonAn()
        {
            DataTable dt = MonAnDAO.Instance.GetListMonAnTiengViet();
            DGV_monan.DataSource = dt;
        }

        private void DGV_monan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGV_monan.Rows.Count)
            {
                DataGridViewRow selectedRow = DGV_monan.Rows[e.RowIndex];
                string maMonAn = selectedRow.Cells["Mã món ăn"].Value.ToString();
                string tenMonAn = selectedRow.Cells["Tên món ăn"].Value.ToString();
                string giaMonAn = selectedRow.Cells["Giá"].Value.ToString();
                FormChiTietMonAn f=new FormChiTietMonAn(this, maMonAn, tenMonAn,giaMonAn);
                f.ShowDialog();
            }
        }

        private void BTN_themmonan_Click(object sender, EventArgs e)
        {
            FormThemMonAn formThemMonAn=new FormThemMonAn(this);
            formThemMonAn.ShowDialog();
        }

        private void FormDanhSachMonAn_Load(object sender, EventArgs e)
        {
            if (nhanVien.PhanQuyen == 0)
            {
                BTN_themmonan.Visible = false;
            }
        }
    }
}
