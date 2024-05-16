using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace QuanLyNhaHang
{
    public partial class FormDanhSachBan : Form
    {
        private NhanVien nhanVien;
        public FormDanhSachBan(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void BTN_datban_Click(object sender, EventArgs e)
        {
            FormDatBan f = new FormDatBan(this);
            f.ShowDialog();
        }
        public void DisplayDGV_ban()
        {
            DGV_ban.DataSource = BanBLL.Instance.GetOccupiedTables();
        }

        private void FormDanhSachBan_Load(object sender, EventArgs e)
        {
            DisplayDGV_ban();
            if (nhanVien.PhanQuyen == 0)
            {
                BTN_datban.Visible = false;
            }
        }

        private void DGV_ban_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGV_ban.Rows.Count)
            {
                DataGridViewRow selectedRow = DGV_ban.Rows[e.RowIndex];
                string maBan = selectedRow.Cells["MaBan"].Value.ToString();
                FormSuaBan f = new FormSuaBan(this, BanBLL.Instance.GetTableById(maBan));
                f.ShowDialog();
            }
        }
    }
}
