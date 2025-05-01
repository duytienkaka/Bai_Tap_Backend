# Bài tập này

## Mô tả
Dự án này là một bài tập thực hành được xây dựng bằng Visual Studio. Nó bao gồm một giải pháp (`.sln`) và một dự án con (`Lab1_1`) được viết bằng ngôn ngữ C#. Mục tiêu của bài tập là giúp người dùng làm quen với việc sử dụng Visual Studio để phát triển ứng dụng .NET.

## Cấu trúc dự án
- **Thư mục mới.sln**: Tệp giải pháp chính của dự án.
- **Lab1_1**: Thư mục chứa mã nguồn của dự án con.
  - **Lab1_1.csproj**: Tệp cấu hình dự án.
  - Các tệp mã nguồn khác (ví dụ: `Program.cs`, `App.config`, v.v.).

## Yêu cầu hệ thống
- **Visual Studio**: Phiên bản 17.5.2 hoặc mới hơn.
- **.NET SDK**: Phiên bản 9.0 hoặc mới hơn.

## Hướng dẫn sử dụng

### Cách mở và chạy dự án
1. **Mở dự án**:
   - Mở Visual Studio.
   - Chọn `File > Open > Project/Solution`.
   - Duyệt đến tệp `Thư mục mới.sln` và mở nó.

2. **Chạy dự án**:
   - Chọn dự án con cần chạy (Lab1_1, Lab1_2, hoặc Lab1_3) trong Solution Explorer.
   - Nhấn `F5` để chạy dự án hoặc `Ctrl + F5` để chạy mà không gỡ lỗi.

3. **Xây dựng dự án**:
   - Nhấn `Ctrl + Shift + B` để xây dựng toàn bộ giải pháp.

4. **Chạy từ dòng lệnh**:
   - Mở terminal và điều hướng đến thư mục chứa dự án.
   - Chạy lệnh sau để chạy một dự án cụ thể:
     ```bash
     dotnet run --project Lab1_1/Lab1_1.csproj
     ```
     Thay [Lab1_1](http://_vscodecontentref_/8) bằng [Lab1_2](http://_vscodecontentref_/9) hoặc [Lab1_3](http://_vscodecontentref_/10) để chạy các dự án khác.

## Nội dung từng Lab

### Lab1_1
- **Bài 1**: Nhập tên và tuổi, in ra thông báo.
- **Bài 2**: Tính diện tích hình chữ nhật.
- **Bài 3**: Chuyển đổi nhiệt độ từ độ C sang độ F.
- **Bài 4**: Kiểm tra số chẵn/lẻ.
- **Bài 5**: Tính tổng và tích của hai số.
- **Bài 6**: Kiểm tra số dương, âm, hoặc không.
- **Bài 7**: Kiểm tra năm nhuận.
- **Bài 8**: In bảng cửu chương.
- **Bài 9**: Tính giai thừa.
- **Bài 10**: Kiểm tra số nguyên tố.

### Lab1_2
- **Bài 1**: Tính tổng các số chẵn trong mảng.
- **Bài 2**: Kiểm tra số nguyên tố trong mảng.
- **Bài 3**: Đếm số lượng số âm và số dương trong mảng.
- **Bài 4**: Tìm số lớn thứ hai trong mảng.
- **Bài 5**: Hoán vị hai số nguyên.
- **Bài 6**: Sắp xếp mảng số thực theo chiều tăng dần.

### Lab1_3
- **Bài tập mẫu**: In ra dòng chữ "Hello, World!".

## Ghi chú
- Đảm bảo rằng bạn đã cài đặt đầy đủ các thành phần cần thiết của Visual Studio để hỗ trợ phát triển .NET.
- Nếu gặp lỗi, kiểm tra lại cấu hình trong tệp `.csproj` hoặc `.sln`.

## Liên hệ
Nếu bạn có bất kỳ câu hỏi hoặc vấn đề nào, vui lòng liên hệ qua email: `support@example.com`.