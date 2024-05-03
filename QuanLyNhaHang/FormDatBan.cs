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

        private void FormDatBan_Load(object sender, EventArgs e)
        {
            CBB_mabantrong.SelectedIndex = -1;
            DisplayCBB_bantrongItems();
        }
    }
}
