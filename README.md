# 🏍️ QLCHHONDA - Hệ Thống Quản Lý Cửa Hàng Xe Máy Honda

[![Framework](https://img.shields.io/badge/.NET-10.0--windows-blue.svg?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/Database-SQL_Server-red.svg?style=flat-square&logo=microsoft-sql-server)](https://www.microsoft.com/en-us/sql-server/)
[![Architecture](https://img.shields.io/badge/Architecture-3--Tier-orange.svg?style=flat-square)](https://en.wikipedia.org/wiki/Multitier_architecture)

**QLCHHONDA** là phần mềm quản lý cửa hàng kinh doanh và dịch vụ sửa chữa xe máy Honda, được xây dựng trên nền tảng **Windows Forms hiện đại (.NET 10.0)** sử dụng kiến trúc **3 lớp (3-Tier)** chuẩn hóa. 

Hệ thống sở hữu giao diện phẳng tinh tế (Modern Flat Design), font chữ Segoe UI sang trọng và khả năng tự co giãn linh hoạt (Responsive Layout), mang lại trải nghiệm chuyên nghiệp cho người dùng trên mọi độ phân giải màn hình.

---

## ✨ Các Tính Năng Cốt Lõi

1.  **📊 Dashboard & Thống Kê Trực Quan**:
    *   Xem nhanh số liệu doanh thu bán hàng và dịch vụ sửa chữa.
    *   Thống kê lượng khách hàng mới, lượt xe làm dịch vụ trong ngày/tháng.
    *   Trực quan hóa dữ liệu bằng biểu đồ doanh thu tự động.
2.  **👥 Quản Lý Khách Hàng**:
    *   Lưu trữ thông tin khách hàng, số điện thoại, địa chỉ, CCCD.
    *   Tự động kiểm tra trùng lặp số điện thoại, validate định dạng nhập liệu.
    *   Tìm kiếm khách hàng nhanh chóng theo tên hoặc số điện thoại.
3.  **🏍️ Quản Lý Kho Xe & Xe Máy**:
    *   Quản lý danh mục xe máy (Tên xe, dòng xe, màu sắc, phân khối, số lượng tồn kho, giá bán).
    *   Cập nhật thông tin nhập/xuất kho xe nhanh chóng.
4.  **🔧 Dịch Vụ Sửa Chữa & Bảo Dưỡng**:
    *   Lập phiếu sửa chữa cho xe của khách hàng.
    *   Quản lý danh mục phụ tùng thay thế và đơn giá dịch vụ đi kèm.
    *   Theo dõi tiến độ sửa chữa của kỹ thuật viên.
5.  **🧾 Hóa Đơn Bán Hàng & Thanh Toán**:
    *   Lập hóa đơn bán xe máy mới với giao diện chọn nhanh trực quan.
    *   Tự động tính toán tổng tiền, VAT và in thông tin hóa đơn.
    *   Lưu lịch sử giao dịch chi tiết phục vụ đối soát.
6.  **🔐 Phân Quyền & Đăng Nhập Hệ Thống**:
    *   Xác thực tài khoản và phân cấp quyền sử dụng rõ ràng.
    *   Quyền **Admin**: Được truy cập toàn quyền tất cả tính năng, cấu hình hệ thống, xem báo cáo doanh thu.
    *   Quyền **Staff** (Nhân viên): Chỉ được phép sử dụng các chức năng nghiệp vụ hàng ngày (Lập hóa đơn, dịch vụ sửa chữa, thông tin khách hàng). Menu Thống kê và Quản lý kho xe sẽ tự động ẩn đi để bảo mật.

---

## 💻 Công Nghệ Sử Dụng

*   **Ngôn ngữ**: C# 12 / .NET 10.0 (Windows Forms).
*   **Thư viện kết nối**: `Microsoft.Data.SqlClient` (Version 5.1.1 - Bảo mật và tối ưu nhất cho SQL Server).
*   **Thư viện vẽ biểu đồ**: `System.Windows.Forms.DataVisualization`.
*   **CSDL**: Microsoft SQL Server / SQL LocalDB.

---

## 🚀 Hướng Dẫn Setup & Chạy Dự Án

### 1. Tải Mã Nguồn Về Máy (Clone Repository)

Để tải toàn bộ mã nguồn của dự án về máy tính cá nhân, bạn hãy mở **Git Bash** hoặc **Terminal (CMD/PowerShell)** lên và chạy lệnh sau:

```bash
git clone https://github.com/turretsz/QLCHHONDA.git
```

Sau khi clone xong, di chuyển vào thư mục của dự án:

```bash
cd QLCHHONDA
```

### 2. Cập Nhật Mã Nguồn Mới Nhất (Pull Code)

Trong quá trình làm việc nhóm, để cập nhật tất cả những thay đổi mới nhất từ các thành viên khác trên GitHub về máy của mình, bạn hãy chạy lệnh:

```bash
git pull origin main
```

> **Lưu ý**: Hãy chắc chắn đã lưu hoặc commit các thay đổi cá nhân trước khi chạy lệnh pull để tránh xung đột mã nguồn (merge conflicts).

---

### 3. Cài Đặt Cơ Sở Dữ Liệu

1.  Mở công cụ **SQL Server Management Studio (SSMS)** hoặc kết nối Database trong Visual Studio.
2.  Mở file script SQL nằm tại đường dẫn: **`honda/Database/Script.sql`**.
3.  Nhấn nút **Execute** (hoặc phím **F5**) để khởi tạo database `HondaManagement`, tạo các bảng liên kết và chèn dữ liệu mẫu ban đầu.

---

### 4. Cấu Hình Chuỗi Kết Nối & Chạy Chương Trình

1.  Dùng **Visual Studio 2022** mở file giải pháp: **`honda.slnx`** (hoặc `.sln` nếu có).
2.  Mở file cấu hình kết nối CSDL tại: [DataProvider.cs](file:///Users/turrets/Downloads/honda/honda/DAL/DataProvider.cs).
3.  Tìm đến dòng số **16** để kiểm tra và chỉnh sửa chuỗi kết nối (`connectionString`) phù hợp với máy của bạn:
    *   *Mặc định dự án dùng SQL LocalDB*:
        ```csharp
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=HondaManagement;Trusted_Connection=True;TrustServerCertificate=True;";
        ```
    *   *Nếu dùng SQL Express*: Thay đổi `Server=(localdb)\MSSQLLocalDB` thành `Server=.\SQLEXPRESS`.
4.  Nhấn **Start** (hoặc **F5**) để biên dịch và chạy phần mềm.

---

## 🔑 Tài Khoản Đăng Nhập Mẫu

Bạn có thể sử dụng các tài khoản sau để đăng nhập trải nghiệm hệ thống:

| Vai Trò | Tài Khoản | Mật Khẩu | Quyền Hạn |
| :--- | :--- | :--- | :--- |
| **Quản trị viên (Admin)** | `admin` | `admin` (hoặc `123`) | Toàn quyền kiểm soát hệ thống, xem doanh thu và kho xe |
| **Nhân viên (Staff)** | `staff` | `123` | Lập hóa đơn bán xe, tiếp nhận dịch vụ sửa chữa và khách hàng |

---

## 📘 Tài Liệu Dành Cho Lập Trình Viên

Nếu bạn là thành viên phát triển dự án, hãy đọc kỹ file tài liệu hướng dẫn nội bộ **[HUONG_DAN_DOC_CODE.md](HUONG_DAN_DOC_CODE.md)** để nắm rõ cấu trúc kiến trúc 3 lớp, quy ước viết code và cách phân công nhiệm vụ cụ thể.

---
*Chúc bạn có trải nghiệm tuyệt vời cùng phần mềm quản lý QLCHHONDA!*
