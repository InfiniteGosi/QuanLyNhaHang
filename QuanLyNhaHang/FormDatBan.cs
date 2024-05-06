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
    public partial class FormDatBan : Form
    {
        FormDanhSachBan parent;
        private List<MonAn> listMonAn = new List<MonAn>();
        public FormDatBan(FormDanhSachBan parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public void DisplayCBB_bantrongItems()
        {
            List<Ban> list = BanBLL.Instance.GetEmptyTables();
            List<string> list_maBan = new List<string>();
            foreach (Ban b in list)
            {
                list_maBan.Add(b.MaBan);
            }
            CBB_mabantrong.DataSource = list_maBan;
        }
        private object[] values;
        private void InitializeValues()
        {
            values = new object[]
            {
                CBB_mabantrong.SelectedItem,
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
        private void FormDatBan_Load(object sender, EventArgs e)
        {
            DisplayCBB_bantrongItems();
            CBB_mabantrong.SelectedIndex = -1;
            CBB_datmonan.DataSource = MonAnBLL.Instance.GetListMonAn();
        }
        

        private void BTN_them_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (CBB_mabantrong.SelectedIndex == -1)
            {
                LB_emaban.Visible = true;
                error++;
            }
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
            if (error > 0)
            {
                return;
            }
            InitializeValues();
            MessageBox.Show(BanBLL.Instance.AddTables(AddParameter()));
            MonAnBLL.Instance.AddMonAnOfBan(CBB_mabantrong.SelectedItem.ToString(), listMonAn);
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

    }
}
