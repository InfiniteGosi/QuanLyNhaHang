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
    public partial class FormThongTinBan : Form
    {
        FormDanhSachBan parent;
        public FormThongTinBan(FormDanhSachBan parent)
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
            if (error > 0)
            {
                return;
            }
            InitializeValues();
            MessageBox.Show(BanBLL.Instance.AddTables(AddParameter()));
            parent.DisplayDGV_ban();
            Close();
        }

        private void TXB_hotenkhach_TextChanged(object sender, EventArgs e)
        {
            LB_ehotenkhach.Visible = true;
        }

        private void TXB_sdtkhach_TextChanged(object sender, EventArgs e)
        {
            LB_esdtkhach.Visible = true;
        }
    }
}
