-- Function vốn bỏ ra của tháng
CREATE OR ALTER FUNCTION Func_TongTienPhieuChi(@ThangCanXuat int, @NamCanXuat int)
RETURNS @DSTienChi TABLE (ThangXuat int, NamXuat int, TongTien money)
AS
Begin
	Insert into @DSTienChi (ThangXuat, NamXuat, TongTien)
	Select MONTH(NgayXuatPhieu) as ThangXuat, Year(NgayXuatPhieu) as NamXuat, sum(SoTienChi) as TongTien
	From PhieuChi
	Where MONTH(NgayXuatPhieu) = @ThangCanXuat and YEAR(NgayXuatPhieu) = @NamCanXuat
	Group By MONTH(NgayXuatPhieu), YEAR(NgayXuatPhieu)
	Return
End

Select *
From Func_TongTienPhieuChi(2, 2023)

/* Function Lay Hoa Don Theo Ngay*/ 
Create or alter function Func_HoaDonTheoNgay(@NgayGioCanXuat date)
returns @HoaDonTheoNgay table (MaHD nchar(10), NGAYDONHANG date)
as
begin
	insert into @HoaDonTheoNgay (MaHD , NGAYDONHANG)
	select MaHoaDon,NgayGio
	from HoaDon
	where @NgayGioCanXuat = NgayGio
	return
end
go

--Function tính lương nhân viên theo tháng 
CREATE OR ALTER FUNCTION Func_LuongNhanVien(@ThangCanNhap int, @NamCanNhap int)
RETURNS @DSLuong TABLE (MaNhanVien nchar(10), HoVaTen nvarchar(50), ChucVu nvarchar(50), ThangLamViec int, NamLamViec int, ThanhTien money)
As
Begin
	Insert into @DSLuong (MaNhanVien, HoVaTen, ChucVu, ThangLamViec, NamLamViec, ThanhTien)
	Select NV.MaNhanVien, HoVaTen, L.ChucVu, Month(NgayLam) as ThangLamViec, Year(NgayLam) as NamLamViec, (((sum(ThoiGianKetThuc - ThoiGianBatDau)) * LuongTheoGio) + ThuongTheoDot) as ThanhTien
	From ChamCong CC, NhanVien NV, Luong L
	Where CC.MaNhanVien = NV.MaNhanVien and NV.ChucVu = L.ChucVu and MONTH(NgayLam) = @ThangCanNhap
	Group By NV.MaNhanVien, HoVaTen, L.ChucVu, MONTH(NgayLam), YEAR(NgayLam), LuongTheoGio, ThuongTheoDot
	Return
End
Go

Select *
From Func_LuongNhanVien(5, 2023)

/* Test Function lấy hoá đơn theo ngày*/ 
Select MaHDCC, ThanhTien, NGAYDONHANG
From Func_HoaDonTheoNgay('2023-04-12'), ChiTietHDCC
Where MaHD = MaHDCC

--Function lọc info nhân viên theo mã nhân viên
Create or alter function Func_InfoNhanVien(@MaNV nvarchar(10))
returns @InfoNhanVien table (HoVaTen nvarchar(200), SDT nchar(15), Tuoi int, DiaChi nvarchar(100),
QueQuan nvarchar(50), ChucVu nvarchar(50), NgayLam date, ThoiGianBatDau int, ThoiGianKetThuc int)
as
begin
	insert into @InfoNhanVien (HoVaTen, SDT, Tuoi, DiaChi, QueQuan, ChucVu, NgayLam, ThoiGianBatDau, ThoiGianKetThuc)
	select HoVaTen, SDT, Tuoi, DiaChi, QueQuan, ChucVu, NgayLam, ThoiGianBatDau, ThoiGianKetThuc
	from NhanVien NV, ChamCong CC
	where NV.MaNhanVien = @MaNV and NV.MaNhanVien = CC.MaNhanVien
	return
end
go

/*Procedure thêm nhân viên*/
CREATE PROCEDURE spThemNhanVien
@MaNhanVien nvarchar(10), 
@HoVaTen nvarchar(200), 
@SDT nvarchar(15), 
@Tuoi int, 
@DiaChi nvarchar(200), 
@GioiTinh nvarchar(50),
@QueQuan nvarchar(50), 
@ChucVu nvarchar(50)
As
Begin
Insert into NhanVien values (@MaNhanVien, @HoVaTen, @SDT, @Tuoi, @DiaChi, @GioiTinh, @QueQuan, @ChucVu)
End
EXEC ThemNhanVien '011', N'Nguyễn Minh Châu', '0984322198', '19', N'01 Võ Văn Ngân, Thủ Đức', N'Nữ', N'Lâm Đồng', N'Nhân Viên'

--Procedure sửa nhân viên
CREATE or ALTER PROCEDURE spCapNhatNhanVien 
@MaNhanVien nvarchar(10), 
@HoVaTen nvarchar(200), 
@SDT nvarchar(15), 
@Tuoi int, 
@DiaChi nvarchar(200), 
@GioiTinh nvarchar(50),
@QueQuan nvarchar(50)
AS
BEGIN
Update NhanVien
Set HoVaTen = @HoVaTen,
SDT = @SDT, Tuoi = @Tuoi,
DiaChi = @DiaChi,
GioiTinh = @GioiTinh,
QueQuan = @QueQuan
Where MaNhanVien = @MaNhanVien
END

--Procedure xóa nhân viên
CREATE OR ALTER PROCEDURE spXoaNhanVien
@MaNV nchar(10)
AS
BEGIN
 Delete From NhanVien where MaNhanVien = @MaNV
END

/* Procedure thêm thức uống*/-----------
CREATE PROCEDURE spThemThucUong
@MaThucUong nchar(10), 
@TenThucUong nvarchar(100), 
@MaNhomThucUong nchar(10), 
@GiaBan int
As
Begin
Insert into ThucUong values (@MaThucUong , @TenThucUong , @MaNhomThucUong , @GiaBan)
end
go

--Procedure sửa thức uống
CREATE or ALTER PROCEDURE spCapNhatThucUong 
@MaThucUong nchar(10), 
@TenThucUong nvarchar(100), 
@MaNhomThucUong nchar(10), 
@GiaBan int
AS
BEGIN
Update ThucUong
Set TenThucUong = @TenThucUong,
	MaNhomThucUong = @MaNhomThucUong,
	GiaBan = @GiaBan
Where MaThucUong = @MaThucUong
END

--Procedure xóa thức uống
CREATE OR ALTER PROCEDURE spXoaThucUong
@MaThucUong nchar(10)
AS
BEGIN
 Delete From ThucUong where MaThucUong = @MaThucUong
END


Exec ThemThucUong 'TS08', N'Trà sữa ôlong lài', 'TS', 25000

--Procedure đổi mật khẩu
CREATE OR ALTER PROCEDURE spDoiMatKhau
@MaNV nvarchar(10), @MatKhauCu nvarchar(50), @MatKhauMoi nvarchar(50)
AS
BEGIN
	Update TaiKhoan
	Set MatKhau = LTRIM(@MatKhauMoi)
	Where MaNhanVien = @MaNV and MatKhau = @MatKhauCu
End





