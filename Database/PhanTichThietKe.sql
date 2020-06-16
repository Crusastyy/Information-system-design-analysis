create database PhanTichThietKe

use PhanTichThietKe;

drop database PhanTichThietKe;

create table NhanVien
(
	MaNV int identity(1,1) not null primary key,
	HoTen nvarchar(50) not null,
	NgaySinh date not null ,
	SDT varchar(15) not null unique,
	GioiTinh bit not null,
	email varchar(50),
	ChucDanh bit default(0) not null
);


create table TaiKhoanNV
(
	MaNV		int not null,
	TaiKhoan	varchar(30) not null unique,
	MatKhau		varchar(50) not null,

	constraint FK_TaiKhoanNV_NhanVien foreign key (MaNV) references NhanVien(MaNV)
);

create table KhachHang
(
	MaKH int identity(1,1) not null primary key,
	HoTen nvarchar(50) not null,
	NgaySinh date,
	SDT varchar(15) not null unique,
	GioiTinh bit,
	TichLuy int default(0) not null
);

create table SanPham 
(
	MaSP int identity(1,1) not null primary key,
	LoaiSP nvarchar(50) not null,
	HinhSP varchar(max),
	TenSP nvarchar(50) not null,
	Size char default('S'),
	Price int not null
);

create table HoaDon 
(
	MaHD int identity(1,1) not null primary key,
	NgHD date not null,
	ThoiGianHD time(7) not null,
	MaKh int default(null),
	TriGia int not null default(0),
	MaNV int not null,

	constraint FK_HoaDon_KhachHang foreign key (MaKH) references KhachHang(MaKH),
	constraint FK_HoaDon_NhanVien foreign key (MaNV) references NhanVien(MaNV)
);

create table CTHD
(
	MaHD int not null,
	MaSP int not null,
	Size char not null,
	SL int not null,
	Price int not null,

	constraint FK_CTHD_HoaDon foreign key (MaHD) references HoaDon(MaHD),
	constraint FK_CTHD_SanPham foreign key (MaSP) references SanPham(MaSP)
);

/* Này là insert vô bảng Nhân Viên với bảng tài khoản 1 lần */
insert into NhanVien (HoTen, SDT, NgaySinh, GioiTinh, email, ChucDanh) values (N'Bành Phúc Thịnh', '0767062905', '2000-09-24', 1, '18521435@gm.uit.edu.vn', 1)
insert into TaiKhoanNV values ((select @@IDENTITY ),'18521435','c4ca4238a0b923820dcc509a6f75849b');


/* Vi du them mon vao */

insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values ('Cafe','Noi Dung trong notepad',N'Cafe Đen','S',15);
insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe',N'Cafe Đen','M',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe',N'Cafe Đen','L',25);


insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values ('Cafe','Noi dung trong Notepad',N'Cafe Sữa','S',15);
insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe',N'Cafe Sữa','M',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe',N'Cafe Sữa','L',25);


insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe','Noi dung trong notepad',N'Bạc Sỉu','S',15);
insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe',N'Bạc Sỉu','M',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values ('Cafe',N'Bạc Sỉu','L',25);

/*Trà */
insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values (N'Trà','Noi dung trong notepad',N'Lục Trà','S',15);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà',N'Lục Trà','M',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà',N'Lục Trà','L',25);

insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values (N'Trà','Noi dung trong notepad',N'Trà Đào','S',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà',N'Trà Đào','M',25);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà',N'Trà Đào','L',30);

insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values (N'Trà','Noi dung trong notepad',N'Trà Vải','S',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà',N'Trà Vải','M',25);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà',N'Trà Vải','L',30);


/*Trà Sữa*/
insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values (N'Trà Sữa','Noi dung trong notepad',N'Cacao Sữa','S',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà Sữa',N'Cacao Sữa','M',25);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà Sữa',N'Cacao Sữa','L',30);

insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values (N'Trà Sữa','Noi dung trong notepad',N'Lục Trà Sữa','S',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà Sữa',N'Lục Trà Sữa','M',25);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà Sữa',N'Lục Trà Sữa','L',30);

insert into SanPham (LoaiSP,HinhSP, TenSp, Size, Price) values (N'Trà Sữa','Noi dung trong notepad',N'Trà Sữa Đường Đen','S',20);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà Sữa',N'Trà Sữa Đường Đen','M',25);
insert into SanPham (LoaiSP, TenSp, Size, Price) values (N'Trà Sữa',N'Trà Sữa Đường Đen','L',30);

