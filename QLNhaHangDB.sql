﻿create database QuanLyNhaHang
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

CREATE TABLE MonAn
(
  maMonAn int identity,
  tenMonAn NVARCHAR(100) NOT NULL,
  gia INT NOT NULL,
  PRIMARY KEY (maMonAn)
);

CREATE TABLE Ban
(
  maBan VARCHAR(10) NOT NULL,
  hoTenKhach NVARCHAR(100) NOT NULL,
  soDienThoaiKhach VARCHAR(10) NOT NULL,
  ngayDatBan DATE,
  ngayNhanBan DATE,
  daCoKhachDat BIT NOT NULL,
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

CREATE TABLE Ban_MonAn (
    banMonAnID INT NOT NULL,
    maBan VARCHAR(10) NOT NULL,
    maMonAn int NOT NULL,
	PRIMARY KEY(banMonAnID, maBan, maMonAn),
    FOREIGN KEY (maBan) REFERENCES Ban(maBan),
    FOREIGN KEY (maMonAn) REFERENCES MonAn(maMonAn)
);


-- Quyền 0 là lớn nhất của quản lý, quyền 1 là quyền của lễ tân, quyền 2 là quyền của đầu bếp, quyền 3 là nhân viên kho.
insert into NhanVien values('QL01', '123', 0, N'Quản Lý', N'Nguyễn Văn A', 1)
insert into NhanVien values('LT01', '123', 1, N'Lễ tân', N'Trần Thị B', 0)
insert into NhanVien values('DB01', '123', 2, N'Đầu bếp', N'Nguyễn Thành C', 1)
select * from NhanVien 


INSERT INTO MonAn VALUES ( N'Rau câu dừa', 50000);
INSERT INTO MonAn VALUES ( N'Bánh flan', 600000);
INSERT INTO MonAn VALUES ( N'Cơm gà Hải Nam', 55000);
INSERT INTO MonAn VALUES ( N'Bún bò Huế', 450000);
INSERT INTO MonAn VALUES (N'Sườn xào', 550000);
INSERT INTO MonAn VALUES ( N'Cua cà mau', 650000);
INSERT INTO MonAn VALUES ( N'Cua hoàng đế', 400000);
INSERT INTO MonAn VALUES ( N'Cá hồi hấp', 350000);
INSERT INTO MonAn VALUES (N'Bít tết', 600000);
INSERT INTO MonAn VALUES ( N'Bò lá lốt', 700000);
select * from MonAn


insert into Ban values('B01', 'Khang', '111111', '1/1/2024', '2/1/2024', 1)
insert into Ban values('B02', '', '', NULL, NULL, 0)
insert into Ban values('B03', '', '', NULL, NULL, 0)
insert into Ban values('B04', '', '', NULL, NULL, 0)
insert into Ban values('B05', '', '', NULL, NULL, 0)
insert into Ban values('B06', '', '', NULL, NULL, 0)
insert into Ban values('B07', '', '', NULL, NULL, 0)
insert into Ban values('B08', '', '', NULL, NULL, 0)
insert into Ban values('B09', '', '', NULL, NULL, 0)
insert into Ban values('B10', '', '', NULL, NULL, 0)
insert into Ban values('B11', '', '', NULL, NULL, 0)
insert into Ban values('B12', '', '', NULL, NULL, 0)
insert into Ban values('B13', '', '', NULL, NULL, 0)
insert into Ban values('B14', '', '', NULL, NULL, 0)
insert into Ban values('B15', '', '', NULL, NULL, 0)
select * from Ban


insert into Ban_MonAn values(1, 'B01', 1)
insert into Ban_MonAn values(2, 'B01', 2)
insert into Ban_MonAn values(3, 'B01', 3)
select * from Ban_MonAn
go



--xoa nhan vien
create proc deleteStaff
	@maNhanVien VARCHAR(10)
as
	begin 
	delete from NhanVien where maNhanVien=@maNhanVien
end
go


--sua nhan vien
create proc updateStaff
  @maNhanVien varchar(10),
  @phanQuyen INT,
  @chucVu NVARCHAR(20) ,
  @hoTen NVARCHAR(100) ,
  @gioiTinh BIT 
as
begin
	update NhanVien
	set  chucVu=@chucVu
	where maNhanVien=@maNhanVien
	update NhanVien
	set phanQuyen=@phanQuyen
	where maNhanVien=@maNhanVien
	update NhanVien
	set hoTen=@hoTen
	where maNhanVien=@maNhanVien
	update NhanVien
	set gioiTinh=@gioiTinh
	where maNhanVien=@maNhanVien
end
go

--them nhan vien
create proc addStaff
  @maNhanVien VARCHAR(10) ,
  @matKhau VARCHAR(100) ,
  @phanQuyen INT ,
  @chucVu NVARCHAR(20) ,
  @hoTen NVARCHAR(100) ,
  @gioiTinh BIT 
as
begin
	insert into NhanVien values(@maNhanVien, @matKhau, @phanQuyen, @chucVu, @hoTen, @gioiTinh)
end
go

--sửa mật khẩu
create proc resetPassWord
	@maNhanVien varchar(10)
as
begin
	update NhanVien
	set  matKhau='1'
	where maNhanVien=@maNhanVien
end
go

-- đổi mật khẩu
create proc changePassWord
  @maNhanVien varchar(10),
  @matKhau VARCHAR(100) 
as
begin
	update NhanVien
	set  matKhau=@matKhau
	where maNhanVien=@maNhanVien
end
go

create proc SP_DatBan
	@maBan VARCHAR(10),
	@hoTenKhach NVARCHAR(100),
	@soDienThoaiKhach VARCHAR(10),
	@ngayDatBan DATE,
	@ngayNhanBan DATE,
	@daCoKhachDat BIT
as
begin
	update Ban
	set hoTenKhach = @hoTenKhach,
		soDienThoaiKhach = @soDienThoaiKhach,
		ngayDatBan = @ngayDatBan,
		ngayNhanBan = @ngayNhanBan,
		daCoKhachDat = @daCoKhachDat
	where maBan = @maBan
end
go

create procedure SP_HuyBan
	@maBan VARCHAR(10)
as
begin
	update Ban
	set hoTenKhach = '',
		soDienThoaiKhach = '',
		ngayDatBan = NULL,
		ngayNhanBan = NULL,
		daCoKhachDat = 0
	where maBan = @maBan
	delete from Ban_MonAn where maBan = @maBan
end
go


create proc updateMonAn
	@maMonAn int,
	@tenMonAn nvarchar(100),
	@gia int
as
begin
	update MonAn
	set tenMonAn=@tenMonAn
	where maMonAn=@maMonAn

	update MonAn
	set gia=@gia
	where maMonAn=@maMonAn
end
go

create proc deleteMonAn
	@maMonAn int
as
begin
	delete from Ban_MonAn where maMonAn = @maMonAn
	delete MonAn where maMonAn=@maMonAn
end
go


create proc insertMonAn
	@tenMonAn nvarchar(100),
	@gia int
	as
begin
	INSERT INTO MonAn VALUES (@tenMonAn , @gia );
end
go
