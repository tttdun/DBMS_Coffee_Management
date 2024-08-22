Use QuanLiCuaHangThucUong
Go

-- Tạo phân quyền --
--Cho Quản Lí
CREATE ROLE rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON ChamCong TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON ChiTietHoaDon TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON HoaDon TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON ChiTietHDCC TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON HopDongCungCap TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON LoaiNguyenLieu TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON Luong TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON NguyenLieu TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON NhaCungCap TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON NhanVien TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON NhomThucUong TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON PhaChe TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON PhieuChi TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON TaiKhoan TO rQuanLi
GRANT SELECT, INSERT, UPDATE, REFERENCES ON ThucUong TO rQuanLi

GRANT SELECT ON View_Account TO rQuanLi
GRANT SELECT ON View_CaLam TO rQuanLi
GRANT SELECT ON View_HoaDon TO rQuanLi
GRANT SELECT ON View_LuongNhanVien TO rQuanLi
GRANT SELECT ON View_NhanVien TO rQuanLi
GRANT SELECT ON View_TinhTongHoaDon TO rQuanLi
GRANT SELECT ON View_TienPhieuChi TO rQuanLi

GRANT EXECUTE ON spCapNhatNhanVien TO rQuanLi
GRANT EXECUTE ON spCapNhatThucUong TO rQuanLi
GRANT EXECUTE ON spThemNhanVien TO rQuanLi
GRANT EXECUTE ON spThemThucUong TO rQuanLi
GRANT EXECUTE ON spXoaNhanVien TO rQuanLi
GRANT EXECUTE ON spXoaThucUong TO rQuanLi

GRANT SELECT ON Func_HoaDonTheoNgay TO rQuanLi
GRANT SELECT ON Func_InfoNhanVien TO rQuanLi
GRANT SELECT ON Func_LuongNhanVien TO rQuanLi
GRANT SELECT ON Func_TongTienPhieuChi TO rQuanLi

--Cho Nhân Viên
CREATE ROLE rNhanVien
GRANT SELECT, INSERT, UPDATE, REFERENCES ON ChamCong TO rNhanVien
GRANT SELECT, INSERT, UPDATE, REFERENCES ON ChiTietHoaDon TO rNhanVien

GRANT SELECT ON View_CaLam TO rNhanVien
GRANT SELECT ON View_HoaDon TO rNhanVien

GRANT EXECUTE ON spDoiMatKhau TO rNhanVien
GRANT EXECUTE ON spCapNhatNhanVien TO rNhanVien

GRANT SELECT ON Func_HoaDonTheoNgay TO rNhanVien
GRANT SELECT ON Func_InfoNhanVien TO rNhanVien
GRANT SELECT ON Func_LuongNhanVien TO rNhanVien 

Go
-- Trigger tao login đăng nhập và user cho từng logic khi chèn dữ liệu và gán chúng cho các quyền đã tạo
CREATE OR ALTER TRIGGER Trg_CreateSQLAccount ON TaiKhoan
AFTER Insert
AS
Begin
	Declare @SqlString nvarchar(200)
	Declare @TaiKhoan nvarchar(20)
	Declare @MatKhau nvarchar(20)
	Declare @ChucVu nvarchar(20)

	Select @TaiKhoan = TaiKhoan.TenTaiKhoan, @MatKhau = TaiKhoan.MatKhau, @ChucVu = NhanVien.ChucVu
	From TaiKhoan
	INNER JOIN NhanVien ON TaiKhoan.MaNhanVien = NhanVien.MaNhanVien
	INNER JOIN inserted ON TaiKhoan.MaNhanVien = inserted.MaNhanVien
 
	SET @SqlString= 'CREATE LOGIN [' + @TaiKhoan +'] WITH PASSWORD='''+ @MatKhau
	+''', DEFAULT_DATABASE=[QuanLiCuaHangThucUong], CHECK_EXPIRATION=OFF,
	CHECK_POLICY=OFF'
	EXEC (@SqlString)
	SET @SqlString= 'CREATE USER ' + @TaiKhoan +' FOR LOGIN '+ @TaiKhoan
	EXEC (@SqlString)

	-- role QuanLi
	if (@ChucVu = 'QuanLi')
	begin
		SET @SqlString = N'ALTER ROLE rQuanLi ADD MEMBER ' + @TaiKhoan;
		exec (@SqlString)
	end

	--  role NhanVien
	if (@ChucVu = 'NhanVien')
	begin
		SET @SqlString = N'ALTER ROLE rNhanVien ADD MEMBER ' + @TaiKhoan;
		exec (@SqlString)
	end
END
GO


