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
    public partial class FormDanhSachBan : Form
    {
        public FormDanhSachBan()
        {
            InitializeComponent();
        }

        private void BTN_datban_Click(object sender, EventArgs e)
        {
            FormDatBan f = new FormDatBan();
            f.ShowDialog();
        }
    }
}
