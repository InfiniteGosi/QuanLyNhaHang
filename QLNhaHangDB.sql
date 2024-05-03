create database QuanLyNhaHang
go
use QuanLyNhaHang
go


CREATE TABLE NhanVien
(
  maNhanVien VARCHAR(10) NOT NULL,
  matKhau VARCHAR(100) NOT NULL,
  phanQuyen INT NOT NULL,
  chucVu NVARCHAR(20) NOT NULL,
  hoTen NVARCHAR(100) NOT NULL,
  gioiTinh BIT NOT NULL,
  PRIMARY KEY (maNhanVien)
);

CREATE TABLE ThucDon
(
  maThucDon VARCHAR(10) NOT NULL,
  moTa NVARCHAR(200) NOT NULL,
  PRIMARY KEY (maThucDon)
);

CREATE TABLE MonAn
(
  maMonAn VARCHAR(10) NOT NULL,
  tenMonAn NVARCHAR(100) NOT NULL,
  gia INT NOT NULL,
  PRIMARY KEY (maMonAn)
);

CREATE TABLE Ban
(
  maBan VARCHAR(10) NOT NULL,
  hoTenKhach NVARCHAR(100) NOT NULL,
  soDienThoaiKhach VARCHAR(10) NOT NULL,
  ngayDatBan DATE NOT NULL,
  ngayNhanBan DATE NOT NULL,
  PRIMARY KEY (maBan)
);

CREATE TABLE HoaDon
(
  maHoaDon VARCHAR(10) NOT NULL,
  donGia INT NOT NULL,
  ngayLap DATE NOT NULL,
  maBan VARCHAR(10) NOT NULL,
  maNhanVien VARCHAR(10) NOT NULL,
  PRIMARY KEY (maHoaDon),
  FOREIGN KEY (maBan) REFERENCES Ban(maBan),
);

CREATE TABLE HangHoa
(
  maHangHoa VARCHAR(10) NOT NULL,
  soLuong INT NOT NULL,
  donGia INT NOT NULL,
  PRIMARY KEY (maHangHoa)
);

CREATE TABLE ThucDon_MonAn
(
  maThucDon VARCHAR(10) NOT NULL,
  maMonAn VARCHAR(10) NOT NULL,
  PRIMARY KEY (maThucDon, maMonAn),
  FOREIGN KEY (maThucDon) REFERENCES ThucDon(maThucDon),
  FOREIGN KEY (maMonAn) REFERENCES MonAn(maMonAn)
);

CREATE TABLE ThucDon_Ban
(
  maThucDon VARCHAR(10) NOT NULL,
  maBan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maThucDon, maBan),
  FOREIGN KEY (maThucDon) REFERENCES ThucDon(maThucDon),
  FOREIGN KEY (maBan) REFERENCES Ban(maBan)
);




-- Quyền 0 là lớn nhất của quản lý, quyền 1 là quyền của lễ tân, quyền 2 là quyền của đầu bếp, quyền 3 là nhân viên kho.
insert into NhanVien values('QL01', '123', 0, N'Quản Lý', N'Nguyễn Văn A', 1)
insert into NhanVien values('LT01', '123', 1, N'Lễ tân', N'Trần Thị B', 0)
insert into NhanVien values('DB01', '123', 2, N'Đầu bếp', N'Nguyễn Thành C', 1)
select * from NhanVien 


INSERT INTO MonAn VALUES ('MA001', N'Rau câu dừa', 50000);
INSERT INTO MonAn VALUES ('MA002', N'Bánh flan', 600000);
INSERT INTO MonAn VALUES ('MA003', N'Cơm gà Hải Nam', 55000);
INSERT INTO MonAn VALUES ('MA004', N'Bún bò Huế', 450000);
INSERT INTO MonAn VALUES ('MA005', N'Sườn xào', 550000);
INSERT INTO MonAn VALUES ('MA006', N'Cua cà mau', 650000);
INSERT INTO MonAn VALUES ('MA007', N'Cua hoàng đế', 400000);
INSERT INTO MonAn VALUES ('MA008', N'Cá hồi hấp', 350000);
INSERT INTO MonAn VALUES ('MA009', N'Bít tết', 600000);
INSERT INTO MonAn VALUES ('MA010', N'Bò lá lốt', 700000);
select * from MonAn



insert into ThucDon VALUES ('TD01', N'Khai Vị')
insert into ThucDon VALUES ('TD02', N'Món chính')
insert into ThucDon VALUES ('TD03', N'Tráng miệng')
select * from ThucDon


-- Insert data into ThucDon_MonAn table
INSERT INTO ThucDon_MonAn VALUES ('TD01', 'MA001');
INSERT INTO ThucDon_MonAn VALUES ('TD01', 'MA002');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA003');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA004');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA005');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA006');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA007');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA008');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA009');
INSERT INTO ThucDon_MonAn VALUES ('TD02', 'MA010');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA001');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA002');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA003');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA004');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA005');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA006');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA007');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA008');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA009');
INSERT INTO ThucDon_MonAn VALUES ('TD03', 'MA010');
select * from ThucDon_MonAn


insert into Ban values('B01', 'Khang', '111111', '1/1/2024', '2/1/2024')
select * from Ban
