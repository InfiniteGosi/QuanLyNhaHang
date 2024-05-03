create database QuanLyNhaHang
go
use QuanLyNhaHang
go


CREATE TABLE NhanVien
(
  maNhanVien VARCHAR(10) NOT NULL,
  matKhau VARCHAR(100) NOT NULL,
  phanQuyen INT NOT NULL,
  chucVu NVARCHAR(100) NOT NULL,
  hoTen NVARCHAR(100) NOT NULL,
  gioiTinh BIT NOT NULL,
  PRIMARY KEY (MaNhanVien)
);

CREATE TABLE ThucDon
(
  maThucDon VARCHAR(10) NOT NULL,
  ngayDat DATE NOT NULL,
  PRIMARY KEY (MaThucDon)
);

CREATE TABLE MonAn
(
  maMonAn VARCHAR(10) NOT NULL,
  tenMonAn NVARCHAR(100) NOT NULL,
  PRIMARY KEY (MaMonAn)
);

CREATE TABLE Ban
(
  maBan VARCHAR(10) NOT NULL,
  thongTinKhach NVARCHAR(100) NOT NULL,
  ngayDat DATE NOT NULL,
  gia INT NOT NULL,
  maThucDon VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaBan),
  FOREIGN KEY (MaThucDon) REFERENCES ThucDon(MaThucDon)
);

CREATE TABLE HoaDon
(
  maHoaDon VARCHAR(10) NOT NULL,
  donGia INT NOT NULL,
  PRIMARY KEY (MaHoaDon)
);

CREATE TABLE HangHoa
(
  maHangHoa VARCHAR(10) NOT NULL,
  soLuong INT NOT NULL,
  donGia INT NOT NULL,
  PRIMARY KEY (MaHangHoa)
);

CREATE TABLE ThucDon_MonAn
(
  maThucDon VARCHAR(10) NOT NULL,
  maMonAn VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaThucDon, MaMonAn),
  FOREIGN KEY (MaThucDon) REFERENCES ThucDon(MaThucDon),
  FOREIGN KEY (MaMonAn) REFERENCES MonAn(MaMonAn)
);

CREATE TABLE NhanVien_Ban
(
  maNhanVien VARCHAR(10) NOT NULL,
  maBan VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaNhanVien, MaBan),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
  FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
);

CREATE TABLE NhanVien_HoaDon
(
  maNhanVien VARCHAR(10) NOT NULL,
  maHoaDon VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaNhanVien, MaHoaDon),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
  FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
);

CREATE TABLE NhanVien_HangHoa
(
  maNhanVien VARCHAR(10) NOT NULL,
  maHangHoa VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaNhanVien, MaHangHoa),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
  FOREIGN KEY (MaHangHoa) REFERENCES HangHoa(MaHangHoa)
);


-- Quyền 0 là lớn nhất của quản lý, quyền 1 là quyền của lễ tân, quyền 2 là quyền của đầu bếp.
insert into NhanVien values('QL01', '123', 0, N'Quản Lý', N'Nguyễn Văn A', 1)
insert into NhanVien values('LT01', '123', 1, N'Lễ tân', N'Trần Thị B', 0)
insert into NhanVien values('DB01', '123', 2, N'Đầu bếp', N'Nguyễn Thành C', 1)
select * from NhanVien 
