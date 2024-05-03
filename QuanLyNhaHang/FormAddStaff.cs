using DAO;
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
    public partial class FormAddStaff : Form
    {
        FormDanhSachNhanVien FormDanhSachNhanVien; // load du lieu
        DataTable dataTable; //lay danh sach nhan vien
        Dictionary<string, string> listError = new Dictionary<string, string>();
        public FormAddStaff(FormDanhSachNhanVien formDanhSachNhanVien, DataTable dataTable)
        {
            InitializeComponent();
            AddListError();
            FormDanhSachNhanVien = formDanhSachNhanVien;
            this.dataTable = dataTable;
            ShowPosition();
        }
        public FormAddStaff()
        {
            InitializeComponent();
            AddListError();
        }
        public void AddListError()
        { // danh sach loi
            listError.Add("TXB_manv", "Hãy nhập mã nhân viên");
            listError.Add("tbName", "Hãy nhập tên nhân viên");
            listError.Add("tbPass", "hãy nhập mật khẩu");
            listError.Add("rbMale", "Hãy chọn giới tính");
            listError.Add("rbFeMale", "Hãy chọn giới tính");

        }
        private int CheckSex()
        { //chuyen gioi tinh thanh bit
            int getSex = 0;
            if (rbMale.Checked)
            {
                getSex = 1;
            }
            if (rbFeMale.Checked)
            {
                getSex = 0;
            }
            return getSex;
        }
        public enum GetPosition
        {
            //lay phan quyen
            quanLy,
            leTan,
            dauBep,
            nhanvienKho
        }
        public string[] ArrayPositionName = new string[] { "Quản lý", "Lễ tân", "Đầu bếp", "Nhân viên kho" };//lay ten chuc vu
        public void ShowPosition()
        {
            cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.quanLy]);
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.leTan]);
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.dauBep]);
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.nhanvienKho]);//hien combobox chuc vu
        }
        private int GetNumberPosition(string chucVu)
        {
            int number = 0;
            if (chucVu.Equals(ArrayPositionName[0]))
            {
                number = 0;
            }
            else if (chucVu.Equals(ArrayPositionName[1]))
            {
                number = 1;
            }
            else if (chucVu.Equals(ArrayPositionName[2]))
            {
                number = 2;
            }
            else if (chucVu.Equals(ArrayPositionName[3]))
            {
                number = 3;
            }
            return number;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            int checkError = 0;
            foreach (var item in listError)
            {
                if (string.IsNullOrEmpty(TXB_manv.Text))
                {
                    lbErrorMaNhanVien.Text = "Hãy nhập mã nhân viên";
                    lbErrorMaNhanVien.Visible = true;
                    checkError++;
                }
                if (!string.IsNullOrEmpty(TXB_manv.Text))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {

                        if (row["maNhanVien"] != null && !string.IsNullOrEmpty(row["maNhanVien"].ToString()))
                        {
                            if (TXB_manv.Text.Equals(row["maNhanVien"].ToString()))
                            {
                                lbErrorMaNhanVien.Text = "Mã nhân viên đã tồn tại";
                                lbErrorMaNhanVien.Visible = true;
                                checkError++;
                            }
                        }

                    }
                }
                if(string.IsNullOrEmpty(cbPosition.Text))
                {
                    lbPositon.Visible = true;
                    checkError ++;
                }
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    lbErrorName.Visible = true;
                    checkError++;
                }
                if (string.IsNullOrEmpty(tbPass.Text))
                {
                    lbErrorPass.Visible = true;
                    checkError++;
                }
                if (!rbFeMale.Checked && !rbMale.Checked)
                {
                    lbErrorSex.Visible = true;
                    checkError++;
                }


            }
            if (checkError > 0)
            {
                return;
            }
            else
            {
                lbPositon.Visible = false;
                lbErrorMaNhanVien.Visible = false;
                lbErrorName.Visible = false;
                lbErrorPass.Visible = false;
                lbErrorSex.Visible = false;
                lbErrorMaNhanVien.Visible = false;
                string maNhanVien = TXB_manv.Text;
                string chucVu = cbPosition.Text;
                string matKhau = tbPass.Text;
                string hoTen = tbName.Text;
                int getSex = CheckSex();
                int phanQuyen = GetNumberPosition(chucVu);
                AddEmployee(maNhanVien, matKhau, phanQuyen, chucVu, hoTen, getSex);
                MessageBox.Show("Thêm thành công");
                FormDanhSachNhanVien.DisplayDGV_nhanvien(); // load lai du lieu
            }
        }
        public void AddEmployee(string maNhanVien, string matKhau, int phanQuyen, string chucVu, string hoTen, int getSex)
        {
            NhanVienDAO.Instance.AddStaff(maNhanVien, matKhau, phanQuyen, chucVu, hoTen, getSex);
        }

        //ẩn lỗi
        private void TXB_manv_TextChanged(object sender, EventArgs e)
        {
                lbErrorMaNhanVien.Visible = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            lbErrorName.Visible = false;
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            lbErrorPass.Visible = false;
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPositon.Visible = false;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            lbErrorSex.Visible = false;
        }

        private void rbFeMale_CheckedChanged(object sender, EventArgs e)
        {
            lbErrorSex.Visible = false;
        }
    }
}
