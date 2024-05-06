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
    maMonAn VARCHAR(10) NOT NULL,
	PRIMARY KEY(banMonAnID, maBan, maMonAn),
    FOREIGN KEY (maBan) REFERENCES Ban(maBan),
    FOREIGN KEY (maMonAn) REFERENCES MonAn(maMonAn)
);


-- Quyền 0 là lớn nhất của quản lý, quyền 1 là quyền của lễ tân, quyền 2 là quyền của đầu bếp, quyền 3 là nhân viên kho.
insert into NhanVien values('QL01', '123', 0, N'Quản Lý', N'Nguyễn Văn A', 1)
insert into NhanVien values('LT01', '123', 1, N'Lễ tân', N'Trần Thị B', 0)
insert into NhanVien values('DB01', '123', 2, N'Đầu bếp', N'Nguyễn Thành C', 1)
select * from NhanVien 


INSERT INTO MonAn VALUES ('M001', N'Rau câu dừa', 50000);
INSERT INTO MonAn VALUES ('M002', N'Bánh flan', 600000);
INSERT INTO MonAn VALUES ('M003', N'Cơm gà Hải Nam', 55000);
INSERT INTO MonAn VALUES ('M004', N'Bún bò Huế', 450000);
INSERT INTO MonAn VALUES ('M005', N'Sườn xào', 550000);
INSERT INTO MonAn VALUES ('M006', N'Cua cà mau', 650000);
INSERT INTO MonAn VALUES ('M007', N'Cua hoàng đế', 400000);
INSERT INTO MonAn VALUES ('M008', N'Cá hồi hấp', 350000);
INSERT INTO MonAn VALUES ('M009', N'Bít tết', 600000);
INSERT INTO MonAn VALUES ('M010', N'Bò lá lốt', 700000);
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
select * from Ban where daCoKhachDat = 0


insert into Ban_MonAn values(1, 'B01', 'M010')
insert into Ban_MonAn values(2, 'B01', 'M001')
insert into Ban_MonAn values(3, 'B01', 'M002')
insert into Ban_MonAn values(1, 'B02', 'M005')
insert into Ban_MonAn values(2, 'B02', 'M005')
select * from Ban_MonAn

--xoa nhan vien
create proc deleteStaff
@maNhanVien VARCHAR(10)
as
begin 
delete from NhanVien where maNhanVien=@maNhanVien
end
exec deleteStaff 'QL01'
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
exec updateStaff 'LT01', 1, N'Lễ tân', N'Trần thị B', 0
select * from NhanVien 

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
  exec addStaff 'QL01', '123', 0, N'Quản Lý', N'Nguyễn Văn A', 1
--sửa mật khẩu
drop proc resetPassWord
create proc resetPassWord
@maNhanVien varchar(10)
as
begin
update NhanVien
set  matKhau='1'
where maNhanVien=@maNhanVien
end
drop proc changePassWord 
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
exec changePassWord 'DB02','124'
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