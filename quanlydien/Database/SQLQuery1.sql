create database QuanLyDien
go
use QuanLyDien
go
create table TaiKhoan
(
	TenTaiKhoan nvarchar(100) primary key,
	MatKhau nvarchar(1000) not null,
)
go
create table Thang
(
	MaThang nchar(30) primary key,
	TenThang nvarchar(100) not null
)
go
create table KhachHang
(
	MaKH nchar(30) primary key,
	HoTen nvarchar(100) not null,
	GioiTinh nvarchar(30) not null,
	NgaySinh date not null,
	SoCMT int not null,
	DiaChi nvarchar(100) not null,
	SDT int not null,
	NgayDangKy date not null
)
go
create table ChiSo
(
	MaKH nchar(30) not null,
	MaThang nchar (30) not null,
	LoaiDien nvarchar(50) not null,
	ChiSoCu int not null,
	ChiSoMoi int not null,
	primary key(MaKH, MaThang)
)
go
create table HoaDon
(
	MaHD nchar(30) not null,
	MaKH nchar(30) not null,
	MaThang nchar(30) not null,
	LDTT int,
	Tien int,
	DaNop bit not null,
	primary key(MaHD, MaKH, MaThang)
)
go
-------------
alter table ChiSo 
add foreign key(MaKH) references KhachHang(MaKH)
go
alter table ChiSo 
add foreign key(MaThang) references Thang(MaThang)
go
--------
alter table HoaDon 
add foreign key(MaKH) references KhachHang(MaKH)
go
alter table HoaDon 
add foreign key(MaThang) references Thang(MaThang)
go
-----------
insert into TaiKhoan(TenTaiKhoan, MatKhau) values(N'admin1', N'a')
go
insert into TaiKhoan(TenTaiKhoan, MatKhau) values(N'admin2', N'b')
go
-----------
insert into Thang(MaThang, TenThang) values(201801, N'Tháng 1')
go
insert into Thang(MaThang, TenThang) values(201802, N'Tháng 2')
go
insert into Thang(MaThang, TenThang) values(201803, N'Tháng 3')
go
insert into Thang(MaThang, TenThang) values(201804, N'Tháng 4')
go
insert into Thang(MaThang, TenThang) values(201805, N'Tháng 5')
go
insert into Thang(MaThang, TenThang) values(201806, N'Tháng 6')
go
insert into Thang(MaThang, TenThang) values(201807, N'Tháng 7')
go
insert into Thang(MaThang, TenThang) values(201808, N'Tháng 8')
go
insert into Thang(MaThang, TenThang) values(201809, N'Tháng 9')
go
insert into Thang(MaThang, TenThang) values(201810, N'Tháng 10')
go
insert into Thang(MaThang, TenThang) values(201811, N'Tháng 11')
go
insert into Thang(MaThang, TenThang) values(201812, N'Tháng 12')
go
insert into Thang(MaThang, TenThang) values(201901, N'Tháng 1')
go
insert into Thang(MaThang, TenThang) values(201902, N'Tháng 2')
go
insert into Thang(MaThang, TenThang) values(201903, N'Tháng 3')
go
insert into Thang(MaThang, TenThang) values(201904, N'Tháng 4')
go
insert into Thang(MaThang, TenThang) values(201905, N'Tháng 5')
go
insert into Thang(MaThang, TenThang) values(201906, N'Tháng 6')
go
insert into Thang(MaThang, TenThang) values(201907, N'Tháng 7')
go
insert into Thang(MaThang, TenThang) values(201908, N'Tháng 8')
go
insert into Thang(MaThang, TenThang) values(201909, N'Tháng 9')
go
insert into Thang(MaThang, TenThang) values(201910, N'Tháng 10')
go
insert into Thang(MaThang, TenThang) values(201911, N'Tháng 11')
go
insert into Thang(MaThang, TenThang) values(201912, N'Tháng 12')
go
insert into Thang(MaThang, TenThang) values(202001, N'Tháng 1')
go
insert into Thang(MaThang, TenThang) values(202002, N'Tháng 2')
go
insert into Thang(MaThang, TenThang) values(202003, N'Tháng 3')
go
insert into Thang(MaThang, TenThang) values(202004, N'Tháng 4')
go
insert into Thang(MaThang, TenThang) values(202005, N'Tháng 5')
go
insert into Thang(MaThang, TenThang) values(202006, N'Tháng 6')
go
insert into Thang(MaThang, TenThang) values(202007, N'Tháng 7')
go
insert into Thang(MaThang, TenThang) values(202008, N'Tháng 8')
go
insert into Thang(MaThang, TenThang) values(202009, N'Tháng 9')
go
insert into Thang(MaThang, TenThang) values(202010, N'Tháng 10')
go
insert into Thang(MaThang, TenThang) values(202011, N'Tháng 11')
go
insert into Thang(MaThang, TenThang) values(202012, N'Tháng 12')
go
----------
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20185672, N'Đinh Văn Hậu', N'Nam', '1988-03-03', 057643705, N'Xóm 2, xã Nghĩa Hải, huyện Nghĩa Hưng', 0325439720, '2018-11-08')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20193571, N'Nguyễn Văn Nghĩa', N'Nam', '1979-02-25', 056921573, N'Xóm Thống nhất, xã Công Lý, huyện Lý Nhân', 0965742982, '2019-05-08')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20197381, N'Trần Tiến Dũng', N'Nam', '1969-08-12', 051973804, N'Xóm 1, xã Nghĩa Hùng, huyện Nghĩa Hưng', 0314687259, '2019-10-20')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20187894, N'Nguyễn Thị Linh', N'Nữ', '1992-06-12', 056741982, N'Xóm 2, xã Công Lý, huyện Lý Nhân', 0369824156, '2018-11-12')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20206413, N'Nguyễn Tiến Duy', N'Nam', '1990-10-25', 057921492, N'Xóm 2, xã Công Lý, huyện Lý Nhân', 0914672416, '2020-02-02')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20195672, N'Phạm Thị Tâm', N'Nữ', '1975-05-23', 052891470, N'Xóm 4, xã Công Lý, huyện Lý Nhân', 0398562247, '2019-05-25')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20186914, N'Trần Tuấn Anh', N'Nam', '1978-08-27', 056921573, N'Xóm 2, xã Nghĩa Hải, huyện Nghĩa Hưng', 0976351248, '2018-05-08')
go
insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy)
values(20193975, N'Phạm Xuân Hoàn', N'Nam', '1989-11-25', 056942578, N'Xóm 4, xã Công Lý, huyện Lý Nhân', 0962398714, '2019-11-25')
go
---------
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20185672, 202003, N'Sinh hoạt', 134, 253)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20193571, 202003, N'Sinh hoạt', 264, 352)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20197381, 202003, N'Sinh hoạt', 152, 310)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20187894, 202003, N'Sinh hoạt', 110, 230)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20206413, 202003, N'Kinh doanh', 0, 352)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20195672, 202003, N'Sinh hoạt', 310, 425)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20186914, 202003, N'Kinh doanh', 252, 573)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20193975, 202003, N'Sản xuất', 524, 1054)
go
--------
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20185672, 202004, N'Sinh hoạt', 253, 392)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20193571, 202004, N'Sinh hoạt', 352, 490)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20197381, 202004, N'Sinh hoạt', 310, 453)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20187894, 202004, N'Sinh hoạt', 230, 375)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20206413, 202004, N'Kinh doanh', 352, 720)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20195672, 202004, N'Sinh hoạt', 425, 465)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20186914, 202004, N'Kinh doanh', 573, 910)
go
insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi)
values(20193975, 202004, N'Sản xuất', 1054, 1580)
go





