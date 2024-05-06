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
    public partial class FormThemMonAn : Form
    {
        FormDanhSachMonAn FormDanhSachMonAn;
        Dictionary<string, string> listError = new Dictionary<string, string>();
        public FormThemMonAn(FormDanhSachMonAn formDanhSachMonAn)
        {
            InitializeComponent();
            FormDanhSachMonAn = formDanhSachMonAn;
            AddListError();
        }
        public FormThemMonAn()
        {
            InitializeComponent();
            AddListError();
        }
        public void AddListError()
        { // danh sach loi
            listError.Add("lbErrorTenMonAn", "Hãy nhập tên món ăn");
            listError.Add("lbErrorGia", "Hãy nhập giá món ăn");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int checkError = 0;
            int gia;
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
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thêm không"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    MonAnDAO.Instance.InsertMonAn( tbTenMonAn.Text, int.Parse(tbGia.Text));
                    MessageBox.Show("Thêm thành công");
                    Close();
                    FormDanhSachMonAn.ShowListMonAn();
                }
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
