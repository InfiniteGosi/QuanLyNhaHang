using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FormChiTietNhanVien : Form
    {
        private NhanVien nhanVien;
        FormDanhSachNhanVien FormDanhSachNhanVien;
        string maNhanVienUser = ""; //check tai khoan quan li
        public FormChiTietNhanVien(NhanVien nhanVien , FormDanhSachNhanVien formDanhSachNhanVien, string maNhanVienUser)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
            ShowPosition();
            FormDanhSachNhanVien = formDanhSachNhanVien;
            this.maNhanVienUser = maNhanVienUser;
        }
        private void DisplayEmployeeInfo()
        {
            TXB_manv.Text = nhanVien.MaNhanVien;
            tbName.Text = nhanVien.HoTen;
            GetPositionInfor();
            GetSex();
        }
        private void FormChiTietNhanVien_Load(object sender, EventArgs e)
        {
            DisplayEmployeeInfo();
        }
        public enum GetPosition
        {
            //lay phan quyen
            quanLy,
            leTan,
            dauBep,
            nhanvienKho
        }
        public string[] ArrayPositionName = new string[] {"Quản lý","Lễ tân","Đầu bếp","Nhân viên kho" };//lay ten chuc vu
        public void ShowPosition()
        {
            cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.quanLy]);
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.leTan]);
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.dauBep]);
            cbPosition.Items.Add(ArrayPositionName[(int)GetPosition.nhanvienKho]);//hien combobox chuc vu
        }
        public void GetPositionInfor()
        {
            //lay ten bo phan cua nhan vien de chin sua
            if (nhanVien.PhanQuyen == 0)
            {
                cbPosition.SelectedItem = ArrayPositionName[(int)GetPosition.quanLy];
            }
            else if (nhanVien.PhanQuyen == 1)
            {
                cbPosition.SelectedItem = ArrayPositionName[(int)GetPosition.leTan];
            }
            else if (nhanVien.PhanQuyen == 2)
            {
                cbPosition.SelectedItem = ArrayPositionName[(int)GetPosition.dauBep];
            }
            else if (nhanVien.PhanQuyen == 3)
            {
                cbPosition.SelectedItem = ArrayPositionName[(int)GetPosition.nhanvienKho];
            }
        }
        public void GetSex()//lay gioi tinh
        {
            if (nhanVien.GioiTinh)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFeMale.Checked = true;
            }
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
        private int GetNumberPosition( string chucVu)
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
        private void BTN_sua_Click(object sender, EventArgs e)
        {
            lbErrorMaNhanVien.Visible = false;
            string maNhanVien = TXB_manv.Text;
            string chucVu=cbPosition.Text;
            string hoTen = tbName.Text;
            int getSex=CheckSex();
            int phanQuyen= GetNumberPosition(chucVu);
            if (MessageBox.Show(string.Format("Bạn có chắc Muốn Sửa Mã nhân viên {0} không", TXB_manv.Text), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                NhanVienDAO.Instance.UpdateStaff(maNhanVien, phanQuyen, chucVu, hoTen, getSex);
            MessageBox.Show("Sửa thành công");
            FormDanhSachNhanVien.DisplayDGV_nhanvien();
            }
        }
        //lbErrorMaNhanVien.Visible = false; ẩn thông báo lỗi
        private void BTN_xoa_Click(object sender, EventArgs e)
        {
            if (TXB_manv.Text.Equals(maNhanVienUser))
            {
                lbErrorMaNhanVien.Visible = true;
                return;
            }
            else
            {
                lbErrorMaNhanVien.Visible = false;
                if (MessageBox.Show(string.Format("Bạn có chắc Muốn Xóa Mã nhân viên {0} không",TXB_manv.Text), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    NhanVienDAO.Instance.DeleteStaff(TXB_manv.Text);
                MessageBox.Show("Xóa thành công");
                FormDanhSachNhanVien.DisplayDGV_nhanvien();
                }
            }
        }

        private void TXB_manv_TextChanged(object sender, EventArgs e)
        {
            lbErrorMaNhanVien.Visible = false;
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbErrorMaNhanVien.Visible = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            lbErrorMaNhanVien.Visible = false;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            lbErrorMaNhanVien.Visible = false;
        }

        private void rbFeMale_CheckedChanged(object sender, EventArgs e)
        {
            lbErrorMaNhanVien.Visible = false;
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có chắc Muốn Xóa Mã nhân viên {0} không", TXB_manv.Text), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                NhanVienDAO.Instance.ResetPassWord(TXB_manv.Text);
                MessageBox.Show("Đặt lại mật khẩu thành công");
                FormDanhSachNhanVien.DisplayDGV_nhanvien();
            }
        }
    }
}
