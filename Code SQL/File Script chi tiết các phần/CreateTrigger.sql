use QuanLiCuaHangThucUong
-- Trigger tự động cập nhập thành tiền ở bảng ChiTietHDCC
CREATE OR ALTER Trigger Trg_ThanhTien_ChiTietHDCC on ChiTietHDCC
After Insert
As
Begin
	Declare @MaNguyenLieu nchar(10) = (Select TOP 1 MaNguyenLieu From ChiTietHDCC ORDER BY STT Desc)
	Declare @MaHDCC nchar(10) = (Select TOP 1 MaHDCC From ChiTietHDCC ORDER BY STT Desc)
	Declare @DonGia int = (Select DonGia From NguyenLieu Where MaNguyenLieu = @MaNguyenLieu)
	Update ChiTietHDCC
	Set ThanhTien = SoLuong * @DonGia
	Where MaNguyenLieu = @MaNguyenLieu and MaHDCC = @MaHDCC
End
GO

-- Trigger tự động cập nhập thành tiền ở bảng ChiTietHoaDon
CREATE OR ALTER Trigger Trg_ThanhTien_ChiTietHoaDon on ChiTietHoaDon
After Insert
As
Begin
	Declare @MaThucUong nchar(10) = (Select TOP 1 MaThucUong From ChiTietHoaDon ORDER BY STT Desc)
	Declare @MaHoaDon nchar(10) = (Select TOP 1 MaHoaDon From ChiTietHoaDon ORDER BY STT Desc)
	Declare @GiaBan int = (Select GiaBan From ThucUong Where MaThucUong = @MaThucUong)
	Update ChiTietHoaDon
	Set ThanhTien = SoLuong * @GiaBan
	Where (MaThucUong = @MaThucUong) and (MaHoaDon = @MaHoaDon)
End	
GO

-- Trigger giới hạn độ tuổi nhân viên được phép nhận làm
CREATE OR ALTER Trigger Trg_TuoiGN on NhanVien
For Insert, Update
As
	Declare @Tuoi int 

	SELECT @Tuoi = Tuoi  
	FROM NhanVien
	
	IF (@Tuoi < 18)
		Begin
			ROLLBACK TRAN
			PRINT N'Tuổi của nhân viên khi vào làm việc phải lớn hơn hoặc bằng 18'
		End
GO

-- Trigger cập nhập số tiền chi khi chèn dữ liệu vào ở bảng PhieuChi
CREATE OR ALTER Trigger Trg_TongTienPhieuChi on PhieuChi
After Insert
As
Begin
	Declare @MaPhieuChi nchar(10) = (Select TOP 1 MaPhieuChi From PhieuChi ORDER BY STT Desc)
	Declare @MaHDCC nchar(10) = (Select TOP 1 MaHDCC From PhieuChi ORDER BY STT Desc)
	Declare @TongTien int = (Select sum(ThanhTien) From ChiTietHDCC
							 Where MaHDCC = @MaHDCC)
	Update PhieuChi
	Set SoTienChi = @TongTien
	Where MaPhieuChi = @MaPhieuChi
End

-- Trigger cho phép đăng kí ca làm của nhân viên mà không xảy ra xung đột
CREATE OR ALTER TRigger Trg_CaLamViec on ChamCong
For Insert, Update
As
Begin
	Declare @ThoiGian date 
	Declare @GioBT int 
	Declare @GioKT int 

	Select @ThoiGian = CC.NgayLam, @GioBT = CC.ThoiGianBatDau, @GioKT = CC.ThoiGianKetThuc
	From ChamCong CC
	INNER JOIN NhanVien ON CC.MaNhanVien = NhanVien.MaNhanVien
	INNER JOIN inserted ON CC.MaNhanVien = inserted.MaNhanVien

	if (Select count(*) From ChamCong 
		Where (@ThoiGian = NgayLam and @GioBT >= ThoiGianBatDau and @GioKT <= ThoiGianKetThuc)) > 3
		Begin
			ROLLBACK TRAN
			PRINT N'Ca làm việc này đã đủ số lượng nhân viên đăng kí. Vui lòng chọn ca khác'
		End
End

-- Trigger thay đổi thành tiền khi cập nhập lại giá bán của thức uống 
CREATE OR ALTER TRIGGER Trg_CapNhatTienThucUong on ThucUong
After Update
As
Begin
	Update ChiTietHoaDon
	Set ThanhTien = SoLuong * (Select ThucUong.GiaBan 
	                           From ThucUong 
						       INNER JOIN inserted ON ThucUong.MaThucUong = inserted.MaThucUong
							   INNER JOIN ChiTietHoaDon ON ThucUong.MaThucUong = ChiTietHoaDon.MaThucUong)	 
End

-- Trigger cập nhập tiền khi cập nhập dữ liệu ở bảng ChiTietHoaDon
CREATE OR ALTER TRIGGER Trg_CapNhatThanhTien on ChiTietHoaDon
After update
As
Begin
	Declare @SLmoi int = (Select SoLuong From inserted)
	Declare @SLcu int = (Select SoLuong From deleted)
	if (@SLcu != @SLmoi)
	Begin
		Update ChiTietHoaDon
		Set ThanhTien = (ThanhTien / @SLcu) * @SLmoi
	End
	else
	Begin
		Update ChiTietHoaDon 
		Set ThanhTien = @SLmoi * (Select GiaBan From ThucUong 
								  Where MaThucUong = (Select MaThucUong From inserted))
	End
End