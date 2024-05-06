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
    public partial class FormChiTietMonAn : Form
    {
        string maMonAn = "";
        string tenMonAn ="" ;
        string giaMonAn = "";
        Dictionary<string, string> listError = new Dictionary<string, string>();
        FormDanhSachMonAn monAn;
        public FormChiTietMonAn(FormDanhSachMonAn monAn,string maMonAn,string tenMonAn,string giaMonAn)
        {
            InitializeComponent();
            this.monAn = monAn;
            this.tenMonAn = tenMonAn;
            this.maMonAn = maMonAn;
            this.giaMonAn = giaMonAn;
            ShowChitietMonAn();
            AddListError();
        }
        public FormChiTietMonAn()
        {
            InitializeComponent();
            ShowChitietMonAn();
            AddListError();
        }
        private void ShowChitietMonAn()
        {
            tbMaMonAn.Text = maMonAn;
            tbTenMonAn.Text = tenMonAn;
            tbGia.Text= giaMonAn;
        }
        public void AddListError()
        { // danh sach loi
            listError.Add("lbErrorTenMonAn", "Hãy nhập tên món ăn");
            listError.Add("lbErrorGia", "Hãy nhập giá món ăn");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int checkError = 0;
            int gia;
            if (string.IsNullOrEmpty(tbMaMonAn.Text))
            {
                return;
            }
            foreach (var error in listError)
            {
                if (string.IsNullOrEmpty(tbTenMonAn.Text))
                {
                    lbErrorTenMonAn.Text = "Hãy nhập tên món ăn";
                    lbErrorTenMonAn.Visible = true;
                    checkError++;
                }
                if (string.IsNullOrEmpty(tbGia.Text))
                {
                    lbErrorGia.Text = "Hãy nhập giá món ăn";
                    lbErrorGia.Visible = true;
                    checkError++;
                }
                if (!int.TryParse(tbGia.Text, out gia) && !string.IsNullOrEmpty(tbGia.Text))
                {
                    lbErrorGia.Text = "Giá phải là một số nguyên hợp lệ";
                    lbErrorGia.Visible = true;
                    checkError++;
                }   
            }
            if (checkError > 0)
            {
                return;
            }
            else
            {
                lbErrorTenMonAn.Visible = false;
                lbErrorGia.Visible = false;
                if (MessageBox.Show(string.Format("Bạn có chắc Muốn Sửa Mã món ăn {0} không", tbMaMonAn.Text), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    MonAnDAO.Instance.UpdateMonAn( int.Parse( tbMaMonAn.Text.ToString()), tbTenMonAn.Text,  int.Parse(tbGia.Text));
                    MessageBox.Show("Sửa thành công");
                    Close();
                    monAn.ShowListMonAn();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaMonAn.Text))
            {
                return;
            }
            if (MessageBox.Show(string.Format("Bạn có chắc Muốn Xóa Mã món ăn {0} không", tbMaMonAn.Text), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MonAnDAO.Instance.DeleteMonAn(int.Parse(tbMaMonAn.Text.ToString()));
                MessageBox.Show("Xóa thành công");
                Close();
                monAn.ShowListMonAn();
            }
        }

        private void tbTenMonAn_TextChanged(object sender, EventArgs e)
        {
            lbErrorTenMonAn.Visible = false;
        }

        private void tbGia_TextChanged(object sender, EventArgs e)
        {
            lbErrorGia.Visible = false;
        }
    }
}
