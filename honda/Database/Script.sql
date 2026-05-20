-- Tạo Database
CREATE DATABASE HondaManagement;
GO

USE HondaManagement;
GO

-- 1. Bảng Tài Khoản (TaiKhoan)
CREATE TABLE TaiKhoan (
    Username NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    Role NVARCHAR(20) NOT NULL -- 'Admin', 'Staff'
);
GO

-- 2. Bảng Khách Hàng (KhachHang) - [Nhiệm vụ của Quân]
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(200),
    CCCD NVARCHAR(20)
);
GO

-- 3. Bảng Xe (Xe) - [Nhiệm vụ của Ninh]
CREATE TABLE Xe (
    MaXe INT IDENTITY(1,1) PRIMARY KEY,
    TenXe NVARCHAR(100) NOT NULL,
    LoaiXe NVARCHAR(50), -- Vision, SH, Air Blade...
    SoKhung NVARCHAR(50) UNIQUE NOT NULL,
    SoMay NVARCHAR(50) UNIQUE NOT NULL,
    GiaNhap DECIMAL(18, 2) NOT NULL, -- Giá đại lý nhập về
    GiaBan DECIMAL(18, 2) NOT NULL,  -- Giá bán niêm yết
    MauSac NVARCHAR(50),             -- Màu xe
    TrangThai NVARCHAR(20) DEFAULT N'Chưa bán' -- 'Chưa bán', 'Đã bán'
);
GO

-- 4. Bảng Hóa Đơn Bán Hàng (HoaDon) - [Nhiệm vụ của Khoa]
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaXe INT FOREIGN KEY REFERENCES Xe(MaXe),
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    Username NVARCHAR(50) FOREIGN KEY REFERENCES TaiKhoan(Username), -- Nhân viên bán
    VAT DECIMAL(5, 2) DEFAULT 10.00,       -- Phần trăm VAT (ví dụ: 10%)
    PhiTruocBa DECIMAL(18, 2) DEFAULT 0,  -- Lệ phí trước bạ
    TongTien DECIMAL(18, 2) NOT NULL       -- Tổng thanh toán thực tế
);
GO

-- 5. Bảng Phụ Tùng (PhuTung) - [Nhiệm vụ của Trường]
CREATE TABLE PhuTung (
    MaPhuTung INT IDENTITY(1,1) PRIMARY KEY,
    TenPhuTung NVARCHAR(100) NOT NULL,
    GiaBan DECIMAL(18, 2) NOT NULL,
    SoLuongTon INT NOT NULL
);
GO

-- 6. Bảng Phiếu Sửa Chữa / Bảo Dưỡng (PhieuSuaChua) - [Nhiệm vụ của Trường]
CREATE TABLE PhieuSuaChua (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    BienSo NVARCHAR(20) NOT NULL,
    NgayLap DATETIME DEFAULT GETDATE(),
    NoiDung NVARCHAR(250) NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL
);
GO

-- ==========================================
-- DỮ LIỆU MẪU (SEED DATA)
-- ==========================================

-- Tài khoản đăng nhập
INSERT INTO TaiKhoan (Username, Password, FullName, Role) VALUES 
('admin', '123', N'Quản trị viên', 'Admin'),
('staff', '123', N'Nhân viên bán hàng', 'Staff');

-- Khách hàng mẫu
INSERT INTO KhachHang (TenKH, SDT, DiaChi, CCCD) VALUES
(N'Nguyễn Văn A', '0912345678', N'Cầu Giấy, Hà Nội', '001090123456'),
(N'Trần Thị B', '0987654321', N'Đống Đa, Hà Nội', '002090987654'),
(N'Lê Văn C', '0901234567', N'Thanh Xuân, Hà Nội', '003090555666');

-- Xe máy mẫu
INSERT INTO Xe (TenXe, LoaiXe, SoKhung, SoMay, GiaNhap, GiaBan, MauSac, TrangThai) VALUES 
(N'Honda Vision 2024 Đặc biệt', 'Vision', 'SK12345', 'SM12345', 30000000, 35000000, N'Xanh dương', N'Đã bán'),
(N'Honda SH 150i Thể thao', 'SH', 'SK67890', 'SM67890', 95000000, 110000000, N'Xám xi măng', N'Chưa bán'),
(N'Honda Air Blade 160 Đặc biệt', 'Air Blade', 'SK11223', 'SM11223', 52000000, 60000000, N'Đen vàng', N'Đã bán'),
(N'Honda Winner X Phiên bản Standard', 'Winner', 'SK44556', 'SM44556', 38000000, 45000000, N'Đỏ đen', N'Chưa bán'),
(N'Honda Vision 2024 Tiêu chuẩn', 'Vision', 'SK77889', 'SM77889', 28000000, 33000000, N'Trắng', N'Đã bán');

-- Hóa đơn mẫu (Bán xe)
INSERT INTO HoaDon (NgayLap, MaXe, MaKH, Username, VAT, PhiTruocBa, TongTien) VALUES 
('2026-05-01', 1, 1, 'staff', 10.00, 1750000, 36750000),
('2026-05-05', 3, 2, 'staff', 10.00, 3000000, 63000000),
('2026-05-10', 5, 3, 'staff', 10.00, 1650000, 34650000);

-- Danh mục Phụ tùng
INSERT INTO PhuTung (TenPhuTung, GiaBan, SoLuongTon) VALUES
(N'Dầu nhớt Honda 10W-30', 120000, 50),
(N'Dầu nhớt Honda tay ga', 150000, 30),
(N'Má phanh trước Vision', 95000, 20),
(N'Má phanh sau Vision', 90000, 25),
(N'Săm xe máy Casumina', 75000, 40),
(N'Lốp xe máy Vision', 320000, 15),
(N'Bugi NGK', 65000, 60),
(N'Lọc gió Air Blade', 110000, 15);

-- Phiếu sửa chữa / bảo dưỡng
INSERT INTO PhieuSuaChua (BienSo, NgayLap, NoiDung, TongTien) VALUES
('29A-123.45', '2026-05-18 09:30:00', N'Thay dầu nhớt & kiểm tra phanh', 120000),
('30K-999.99', '2026-05-19 14:15:00', N'Thay bugi & săm xe Casumina', 140000),
('29B-555.55', '2026-05-20 10:00:00', N'Bảo dưỡng định kỳ & thay má phanh sau', 90000);
GO

-- ==========================================
-- CHẠY CÁC LỆNH NÀY ĐỂ CẬP NHẬT DATABASE
-- (Chỉ chạy 1 lần trên database đang có)
-- ==========================================

-- Thêm cột MaPhuTung vào bảng PhieuSuaChua (liên kết tồn kho phụ tùng)
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('PhieuSuaChua') AND name = 'MaPhuTung')
    ALTER TABLE PhieuSuaChua ADD MaPhuTung INT NULL FOREIGN KEY REFERENCES PhuTung(MaPhuTung);
GO

-- Thêm cột GiaNhap và MauSac vào bảng Xe nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Xe') AND name = 'GiaNhap')
    ALTER TABLE Xe ADD GiaNhap DECIMAL(18,2) NOT NULL DEFAULT 0;
GO
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Xe') AND name = 'MauSac')
    ALTER TABLE Xe ADD MauSac NVARCHAR(50) NULL;
GO

-- Thêm cột VAT và PhiTruocBa vào bảng HoaDon nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('HoaDon') AND name = 'VAT')
    ALTER TABLE HoaDon ADD VAT DECIMAL(5,2) DEFAULT 10.00;
GO
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('HoaDon') AND name = 'PhiTruocBa')
    ALTER TABLE HoaDon ADD PhiTruocBa DECIMAL(18,2) DEFAULT 0;
GO

-- Thêm bảng KhachHang nếu chưa có
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='KhachHang' AND xtype='U')
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(200),
    CCCD NVARCHAR(20)
);
GO

-- Thêm MaKH vào HoaDon nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('HoaDon') AND name = 'MaKH')
    ALTER TABLE HoaDon ADD MaKH INT NULL FOREIGN KEY REFERENCES KhachHang(MaKH);
GO
