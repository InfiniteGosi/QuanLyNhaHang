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
    public partial class FormSuaBan : Form
    {
        private FormDanhSachBan parent;
        private Ban ban;
        private BindingList<MonAn> listMonAn = new BindingList<MonAn>();
        public FormSuaBan(FormDanhSachBan parent, Ban ban)
        {
            InitializeComponent();
            this.parent = parent;
            this.ban = ban;
        }
        private object[] values;
        private void InitializeValues()
        {
            values = new object[]
            {
                TXB_maban.Text,
                TXB_hotenkhach.Text,
                TXB_sdtkhach.Text,
                DTP_dat.Value,
                DTP_nhan.Value,
                1
            };
        }
        private Dictionary<string, object> AddParameter()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                { "@maBan", values[0] },
                { "@hoTenKhach", values[1] },
                { "@soDienThoaiKhach", values[2] },
                { "@ngayDatBan", values[3] },
                { "@ngayNhanBan", values[4] },
                { "@daCoKhachDat", values[5] },
            };
            return dict;
        }
        
        private void BTN_them_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (string.IsNullOrEmpty(TXB_hotenkhach.Text))
            {
                LB_ehotenkhach.Visible = true;
                error++;
            }
            if (string.IsNullOrEmpty(TXB_sdtkhach.Text))
            {
                LB_esdtkhach.Visible = true;
                error++;
            }
            //if (listMonAn.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng thêm món ăn");
            //    error++;
            //}
            if (error > 0)
            {
                return;
            }
            InitializeValues();
            MessageBox.Show(BanBLL.Instance.AddTables(AddParameter()));
            MonAnBLL.Instance.DeleteMonAnOfBan(TXB_maban.Text);
            MonAnBLL.Instance.AddMonAnOfBan(TXB_maban.Text, listMonAn.ToList());
            parent.DisplayDGV_ban();
            Close();
        }

        private void TXB_hotenkhach_TextChanged(object sender, EventArgs e)
        {
            LB_ehotenkhach.Visible = false;
        }

        private void TXB_sdtkhach_TextChanged(object sender, EventArgs e)
        {
            LB_esdtkhach.Visible = false;
        }
        private void CBB_mabantrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_emaban.Visible = false;
        }
        private void BTN_themmonan_Click(object sender, EventArgs e)
        {
            listMonAn.Add(CBB_datmonan.SelectedItem as MonAn);
            DGV_monandadat.DataSource = null;
            DGV_monandadat.DataSource = listMonAn;
        }

        private void FormSuaBan_Load(object sender, EventArgs e)
        {
            CBB_datmonan.DataSource = MonAnBLL.Instance.GetListMonAn();
            TXB_maban.Text = ban.MaBan;
            TXB_hotenkhach.Text = ban.HoTenKhach;
            TXB_sdtkhach.Text = ban.SoDienThoaiKhach;
            DTP_dat.Value = (DateTime)ban.NgayDatBan;
            DTP_nhan.Value = (DateTime)ban.NgayNhanBan;
            if (MonAnBLL.Instance.GetListMonAnByBanID(ban.MaBan) != null)
            {
                listMonAn = new BindingList<MonAn>(MonAnBLL.Instance.GetListMonAnByBanID(ban.MaBan));
            }
            DGV_monandadat.DataSource = listMonAn;
        }

        private void DGV_monandadat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGV_monandadat.Rows.Count)
            {
                MonAn monAnToRemove = listMonAn[e.RowIndex];
                listMonAn.Remove(monAnToRemove);
            }
        }

        private void BTN_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy bàn này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(BanBLL.Instance.CancelTable(TXB_maban.Text));
                parent.DisplayDGV_ban();
                Close();
            }
        }
    }
}
