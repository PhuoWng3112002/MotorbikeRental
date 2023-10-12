
CREATE DATABASE db_QuanLyChoThuePhuongTien
ON (
	NAME = ManagerRental,
	FILENAME = 'E:\Learning\NHAPMONCNPM\source\Sql\db_QuanLyChoThuePhuongTien.mdf',
	SIZE = 100MB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 10%
)



create database db_QuanLyChoThuePhuongTien
go
use db_QuanLyChoThuePhuongTien
go
/*****************************************************************************************/

/*CREATE TABLE*/
create table tblNCC
(
	PK_iNCC int primary key not null,
	sPhuongTienN nvarchar(100),
	sHangSanXuat nvarchar(100),
	iSoLuong int,
	iTrongTai int,
	fDonGiaN float
)
create table tblKho
(
	PK_iPhieuThu int primary key not null,
	iPhuongTien int,
	iSoLuong int,
	fTongTien float
)

create table tblPhieuNhap
(	
	PK_iPhieuN int primary key not null,
	iTTrangTai int,
	iTongSLN int,
	fTongGiaN float,
	FK_iNCC int,
	FK_sCMNDnv varchar(12),
	FK_iPhieuThu int
)

create table tblCTNV
(	
	PK_sCMNDnv varchar(12) primary key not null,
	sHoTennv nvarchar(100),
	dNgaySinhnv date,
	sDiaChinv nvarchar(255),
	sGioiTinhnv nvarchar(10),
	sDienThoainv nvarchar(10)
)

create table tblLoaiPhuongTien
(	
	PK_iLoaiPT int primary key not null,
	sLoaiPT nvarchar(100),
	sPhanKhoi nvarchar(100)
)
create table tblCTPhieuNhap
(	
	PK_iPhieuN int primary key not null,
	iPhuongTienN int,
	iSoLuongN int,
	fDonGiaN float,
	FK_iLoaiPT int,
)
create table tblPhieuXuat
(	
	PK_iPhieuX int primary key not null,
	iTongSLX int,
	fTongTien float,
	FK_sCMNDnv varchar(12),
	FK_iPhieuThu int,
)

create table tblCTPhieuXuat
(	
	PK_iPhieuX int primary key not null,
	iPhuongTienX int,
	iSoLuongX int,
	fDonGiaX float,
	FK_iLoaiPT int,
)

create table tblPhuongTien
(	
	PK_iPhuongTien int primary key not null,
	FK_iLoaiPT int,
	FK_iPhieuThu int
)
create table tblDanhGia
(		
	PK_iDanhGia int primary key not null,
	sDanhGia nvarchar(255),
	sCmt nvarchar(255),
	FK_iPhuongTien int,
	FK_sCMND varchar(12)
)
create table tblCTPhuongTien
(	
	PK_iPhuongTien int primary key not null,
	sTenPhuongTien nvarchar(255),
	fGiaThue float,
	fGiaGoc float,
	FK_iAnh int,
	sTinhTrang nvarchar(50),
	FK_iDanhGia int
)
create table tblAnhPT
(	
	PK_iAnh int primary key,
	sUrl image
)


create table tblChucVu
(
	PK_iChucVu int primary key,
	sChucVu nvarchar(100),
	sGhiChu nvarchar(255)
)
create table tblNguoiDung
(
	PK_sCMND varchar(12) primary key not null,
	sTK nvarchar(50) unique not null,
	sMK nvarchar(50),
	sCauHoiBM nvarchar(100),
	sCauTraLoi nvarchar(255),
	dTGDNThatBai datetime,
	dThoiGianDN datetime,
	FK_iChucVu int
)
create table tblCTNguoiDung
(	
	PK_sCMND varchar(12) primary key not null,
	sHoTen nvarchar(100),
	dNgaySinh date,
	sDiaChi nvarchar(255),
	sGioiTinh nvarchar(10),
	sDienThoai nvarchar(10),
	sChucVu nvarchar(100)
)

create table tblBanGiao
(	
	PK_iHopDong int primary key not null,
	iPhuongTien int,
	dNgayThue date,
	dNgayHenTra date,
	fTongTienDatCoc float,
	fTongTienThuePT float,
	sGhiChu nvarchar(255),
	FK_sCMND varchar(12),
	FK_sCMNDnv varchar(12),

)

create table tblHopDong
(	
	PK_iHopDong int primary key not null,
	FK_iPhuongTien int,
	dNgayThue date,
	dNgayHenTra date,
	fTongTienDatCoc float,
	fTienThuePT float,
	FK_sCMND varchar(12),
	FK_sCMNDnv varchar(12),
	FK_iPhieuX int
)
create table tblNhanVien
(
	PK_sCMND varchar(12) primary key not null,
	sTK nvarchar(50) unique not null,
	sMK nvarchar(50),
	sCauHoiBM nvarchar(100),
	sCauTraLoi nvarchar(255),
	dTGDNThatBai datetime,
	dThoiGianDN datetime,
	FK_iChucVu int
)

/****************************************************************************************/
/*ADD CONSTRAINTS*/
alter table tblPhieuNhap
add constraint FK_NCC_PN foreign key (FK_iNCC) references tblNCC(PK_iNCC),
	constraint FK_Kho_PN foreign key (FK_iPhieuThu) references tblKho(PK_iPhieuThu),
	constraint FK_CTNV_PN foreign key (FK_sCMNDnv) references tblCTNV(PK_sCMNDnv)

alter table tblCTPhieuNhap
add constraint FK_PN_CTPN foreign key (PK_iPhieuN) references tblPhieuNhap(PK_iPhieuN),
	constraint FK_LoaiPT_CTPN foreign key (FK_iLoaiPT) references tblLoaiPhuongTien(PK_iLoaiPT)

alter table tblPhieuXuat
add constraint FK_Kho_PX foreign key (FK_iPhieuThu) references tblKho(PK_iPhieuThu),
	constraint FK_CTNV_PX foreign key (FK_sCMNDnv) references tblCTNV(PK_sCMNDnv)

alter table tblCTPhieuXuat
add 
	constraint FK_LoaiPT_CTPX foreign key (FK_iLoaiPT) references tblLoaiPhuongTien(PK_iLoaiPT),
	constraint FK_PX_CTPX foreign key (PK_iPhieuX) references tblPhieuXuat(PK_iPhieuX)

alter table tblPhuongTien
add 
	constraint FK_LoaiPT_PT foreign key (FK_iLoaiPT) references tblLoaiPhuongTien(PK_iLoaiPT),
	constraint FK_Kho_PT foreign key (FK_iPhieuThu) references tblKho(PK_iPhieuThu)

alter table tblDanhGia
add 
	constraint FK_CTND_DG foreign key (FK_sCMND) references tblCTNguoiDung(PK_sCMND),
	constraint FK_PT_DG foreign key (FK_iPhuongTien) references tblPhuongTien(PK_iPhuongTien)

alter table tblCTPhuongTien
add 
	constraint FK_PT_CTPT foreign key (PK_iPhuongTien) references tblPhuongTien(PK_iPhuongTien),
	constraint FK_DG_CTPT foreign key (FK_iDanhGia) references tblDanhGia(PK_iDanhGia),
	constraint FK_AnhPT_CTPT foreign key (FK_iAnh) references tblAnhPT(PK_iAnh)

alter table tblNguoiDung
add 
	constraint FK_CV_ND foreign key (FK_iChucVu) references tblChucVu(PK_iChucVu)

alter table tblCTNguoiDung
add 
	constraint FK_ND_CTND foreign key (PK_sCMND) references tblNguoiDung(PK_sCMND)

alter table tblBanGiao
add constraint FK_CTNV_BG foreign key (FK_sCMNDnv) references tblCTNV(PK_sCMNDnv),
	constraint FK_CTND_BG foreign key (FK_sCMND) references tblCTNguoiDung(PK_sCMND)

alter table tblHopDong
add constraint FK_BG_HD foreign key (PK_iHopDong) references tblBanGiao(PK_iHopDong),
	constraint FK_CTND_HD foreign key (FK_sCMND) references tblCTNguoiDung(PK_sCMND),
	constraint FK_CTPX_HD foreign key (FK_iPhieuX) references tblCTPhieuXuat(PK_iPhieuX),
	constraint FK_CTNV_HD foreign key (FK_sCMNDnv) references tblCTNV(PK_sCMNDnv),
	constraint FK_PT_HD foreign key (FK_iPhuongTien) references tblPhuongTien(PK_iPhuongTien)

alter table tblNhanVien
add 
	constraint FK_CV_NV foreign key (FK_iChucVu) references tblChucVu(PK_iChucVu)

alter table tblCTNV
add 
	constraint FK_NV_CTNV foreign key (PK_sCMNDnv) references tblNhanVien(PK_sCMND)



/*******************************************************************************************************/

/*CREATE VIEW*/
/* gp 2 tblND & tblNV*/
create view vv_TaiKhoan 
AS
SELECT *FROM tblNguoiDung
UNION
SELECT *FROM tblNguoiDung
go

select * from vv_TaiKhoan
/* gp 2 tblCTND & tblCTNV*/
create view vv_CTTaiKhoan 
AS
SELECT *FROM tblCTNguoiDung
UNION
SELECT *FROM tblCTNV
go

select * from tblCTNV
select * from tblCTNguoiDung

select * from vv_CTTaiKhoan
/**/

create view vv_TaiKhoan_ChucVu 
as
select vv_TaiKhoan.PK_sCMND, vv_TaiKhoan.sTK, vv_TaiKhoan.sMK,vv_TaiKhoan.sCauHoiBM, vv_TaiKhoan.sCauTraLoi,vv_TaiKhoan.FK_iChucVu,vv_TaiKhoan.dTGDNThatBai,vv_TaiKhoan.dThoiGianDN,tblChucVu.sChucVu, tblChucVu.sGhiChu 
from vv_TaiKhoan JOIN tblChucVu
on vv_TaiKhoan.FK_iChucVu=tblChucVu.PK_iChucVu
go

select * from vv_TaiKhoan_ChucVu

/***************view NCC *******************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW vv_NhaCungCap
AS
	SELECT PK_iNCC, sPhuongTienN, sHangSanXuat, iSoLuong, iTrongTai, fDonGiaN
	FROM tblNCC
GO

select *from tblNCC
select *from vv_NhaCungCap
/***************view User************/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW vv_CTTaiKhoan_Chucvu
AS
	SELECT vv_TaiKhoan_ChucVu.PK_sCMND,vv_TaiKhoan_ChucVu.sTK,vv_TaiKhoan_ChucVu.sMK, vv_TaiKhoan_ChucVu.sCauHoiBM,
	vv_TaiKhoan_ChucVu.sCauTraLoi,vv_TaiKhoan_ChucVu.dTGDNThatBai,vv_TaiKhoan_ChucVu.dThoiGianDN,vv_TaiKhoan_ChucVu.FK_iChucVu,
	vv_TaiKhoan_ChucVu.sChucVu,vv_TaiKhoan_ChucVu.sGhiChu,vv_CTTaiKhoan.sHoTen,vv_CTTaiKhoan.dNgaySinh,vv_CTTaiKhoan.sDiaChi,
	vv_CTTaiKhoan.sGioiTinh,vv_CTTaiKhoan.sDienThoai
	FROM vv_TaiKhoan_ChucVu JOIN vv_CTTaiKhoan
	ON vv_TaiKhoan_ChucVu.PK_sCMND = vv_CTTaiKhoan.PK_sCMND
GO

select *from vv_CTTaiKhoan_Chucvu
select * from tblCTNguoiDung

/********************************************************************************************************/

/*CREATE PROC*/

/*PROC sp_TimKiemTenTaiKhoan*/
CREATE PROC sp_TimKiemTenTaiKhoan (@TenTK VARCHAR(50))
AS
BEGIN
    SELECT * FROM vv_TaiKhoan_ChucVu WHERE sTK = @TenTK
END
GO

/*PROC sp_DoiMatKhau*/
CREATE PROC sp_DoiMatKhau (@tenTK nvarchar(50), @MK nvarchar(50))
AS
BEGIN
    UPDATE tblNhanVien 
	SET sMK = @MK
	WHERE sTK = @tenTK
	UPDATE tblNguoiDung 
	SET sMK = @MK
	WHERE sTK = @tenTK
END

CREATE proc sp_ThemND
	@CMND varchar(12),
	@TK nvarchar(50),
	@MK nvarchar(50),
	@CauHoi nvarchar(255),
	@CauTraLoi nvarchar(255),
	@HoTen nvarchar(100),
	@NgaySinh date,
	@DiaChi nvarchar(255),
	@GioiTinh nvarchar(10),
	@SDT varchar(10)
AS
BEGIN

	INSERT INTO tblNguoiDung
	VALUES(@CMND,@TK ,@MK ,@CauHoi ,@CauTraLoi,NULL,NULL,3)
	INSERT INTO tblCTNguoiDung
	VALUES(@CMND,@HoTen ,@NgaySinh ,@DiaChi ,@GioiTinh ,@SDT)
END
select*from tblNguoiDung
select*from tblCTNguoiDung
/************/
CREATE proc sp_SuaNCC
	@NCC int,
	@PhuongTienN nvarchar(50),
	@HangSanXuat nvarchar(50),
	@SoLuong int,
	@TrongTai int,
	@DonGiaN float
AS
BEGIN

	UPDATE tblNCC
	SET
	PK_iNCC = @NCC ,
	sPhuongTienN=@PhuongTienN ,
	sHangSanXuat=@HangSanXuat ,
	iSoLuong=@SoLuong ,
	iTrongTai=@TrongTai ,
	fDonGiaN=@DonGiaN 
	where @NCC =PK_iNCC
END


CREATE PROCEDURE sp_XoaNCC
    @NCC int,
	@PhuongTienN nvarchar(50),
	@HangSanXuat nvarchar(50),
	@SoLuong int,
	@TrongTai int,
	@DonGiaN float
AS
BEGIN
    DELETE FROM tblNCC
    WHERE PK_iNCC= @NCC
END
GO

/***************************************/
/*tblNCC*/
/*************THÊM NCC*******************/
CREATE proc sp_ThemNCC
	@NCC int,
	@PhuongTienN nvarchar(50),
	@HangSanXuat nvarchar(50),
	@SoLuong int,
	@TrongTai int,
	@DonGiaN float
AS
BEGIN

	INSERT INTO tblNCC
	VALUES(@NCC,@PhuongTienN ,@HangSanXuat ,@SoLuong ,@TrongTai ,@DonGiaN )
END
/************/
CREATE proc sp_SuaNCC
	@NCC int,
	@PhuongTienN nvarchar(50),
	@HangSanXuat nvarchar(50),
	@SoLuong int,
	@TrongTai int,
	@DonGiaN float
AS
BEGIN

	UPDATE tblNCC
	SET
	PK_iNCC = @NCC ,
	sPhuongTienN=@PhuongTienN ,
	sHangSanXuat=@HangSanXuat ,
	iSoLuong=@SoLuong ,
	iTrongTai=@TrongTai ,
	fDonGiaN=@DonGiaN 
	where @NCC =PK_iNCC
END


CREATE PROCEDURE sp_XoaNCC
    @NCC int,
	@PhuongTienN nvarchar(50),
	@HangSanXuat nvarchar(50),
	@SoLuong int,
	@TrongTai int,
	@DonGiaN float
AS
BEGIN
    DELETE FROM tblNCC
    WHERE PK_iNCC= @NCC
END
GO

/****/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC sp_TimKiemNCC (
	@NCC int,
	@PhuongTienN nvarchar(50),
	@HangSanXuat nvarchar(50),
	@SoLuong int,
	@TrongTai int,
	@DonGiaN float)
AS
BEGIN
	SELECT * 
	FROM tblNCC
	WHERE (@NCC IS NULL OR @NCC = '' OR PK_iNCC = CONVERT(INT, @NCC) )
			AND (@PhuongTienN IS NULL OR sPhuongTienN LIKE '%' + @PhuongTienN + '%')
			AND (@HangSanXuat IS NULL OR sHangSanXuat LIKE '%' + @HangSanXuat + '%')
			AND (@SoLuong IS NULL OR @SoLuong = '' OR iSoLuong = CONVERT(INT, @SoLuong))
			AND (@TrongTai IS NULL OR @TrongTai = '' OR iTrongTai = CONVERT(INT, @TrongTai))
			AND (@DonGiaN IS NULL OR @DonGiaN = '' OR fDonGiaN = CONVERT(FLOAT, @DonGiaN))
			
END
GO

select * from tblPhuongTien
select * from tblCTPhuongTien
select * from tblDanhGia



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC sp_ThemAnh (@id int,@url Image)
AS	
BEGIN
	insert into tblAnhPT values(@id,@url)
			
END
GO

select * from tblAnhPT

