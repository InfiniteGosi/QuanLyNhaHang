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
        public FormDatBan()
        {
            InitializeComponent();
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
            CBB_mabantrong.SelectedIndex = -1;
            DisplayCBB_bantrongItems();
        }

        private void BTN_them_Click(object sender, EventArgs e)
        {
            if (CBB_mabantrong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã bàn còn trống");
                return;
            }
            if (string.IsNullOrEmpty(TXB_hotenkhach.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách");
                return;
            }
            if (string.IsNullOrEmpty(TXB_sdtkhach.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách");
                return;
            }
            InitializeValues();
            MessageBox.Show(BanBLL.Instance.AddTables(AddParameter()));
            Close();
            FormDanhSachBan f = new FormDanhSachBan();
            f.ShowDialog();
        }
    }
}
