use QuanLiCuaHangThucUong
-- View xem nhân viên
CREATE VIEW View_NhanVien
AS
	Select *
	From NhanVien
	Where ChucVu = 'NhanVien'
GO

-- View xem tài khoản
CREATE VIEW View_Account
AS
	Select *
	From TaiKhoan
GO

-- View tính tổng tiền hóa đơn
CREATE VIEW View_TinhTongHoaDon
AS
	select HD.MaHoaDon, MaNhanVien, sum(ThanhTien) as TongTien, NgayGio
	from HoaDon HD, ChiTietHoaDon CTHD
	where HD.MaHoaDon = CTHD.MaHoaDon
	group by HD. MaHoaDon, MaNhanVien, NgayGio
GO

-- View xem hóa đơn
CREATE VIEW View_HoaDon
AS
	Select HD.MaHoaDon, TenHoaDon , NgayGio , CTHD.TenThucUong, SoLuong, (GiaBan*SoLuong) as ThanhTien
	from HoaDon HD, ChiTietHoaDon CTHD, ThucUong TU
	where HD.MaHoaDon = CTHD.MaHoaDon and TU.MaThucUong = CTHD.MaThucUong
GO

-- View xem ca làm
CREATE VIEW View_CaLam
AS
	SELECT MaNhanVien, NgayLam, ThoiGianBatDau , ThoiGianKetThuc 
	from ChamCong
GO

-- View tính tiền phiếu chi cho từng hợp đồng
CREATE VIEW View_TienPhieuChi
As
	select MaPhieuChi, CTHD.MaHDCC, NgayXuatPhieu, sum(ThanhTien) as SoTienChi
	from ChiTietHDCC CTHD, PhieuChi PC
	where PC.MaHDCC = CTHD.MaHDCC  
	group by MaPhieuChi, CTHD.MaHDCC, NgayXuatPhieu
Go

-- View tính lương nhân viên
CREATE VIEW View_LuongNhanVien
AS
	Select NV.MaNhanVien, HoVaTen, L.ChucVu, (((sum(ThoiGianKetThuc - ThoiGianBatDau)) * LuongTheoGio) + ThuongTheoDot) as ThanhTien
	From ChamCong CC, NhanVien NV, Luong L
	Where CC.MaNhanVien = NV.MaNhanVien and NV.ChucVu = L.ChucVu
	Group By NV.MaNhanVien, HoVaTen, L.ChucVu, LuongTheoGio, ThuongTheoDot
Go