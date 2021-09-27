# PRN292_ASM_1
Tạo 1 ứng dụng C# , thêm vào 1 class tên SinhVien gồm các thành phần dữ liệu private: string mMaSV , string HoTen, Date NgaySinh, string DiaChi, string DienThoai.
 - Viết các 2 constructors : 1 có tham số và 1 không có tham số
 - Viết các properties (set , get ) để truy cập các thành phần dữ liệu
 - Viết 1 phương thức public tên XemThongTin() : xuất tất cả thông tin của Sinh Viên ra màn hình.
 - Viết hàm Main() thực hiện các yêu cầu sau :
  a.Khai báo một mảng 1 chiều tên danhSachSinhVien để lưu tối đa 50 sinh viên( có thể dùng List, ArrayList, .. để thay cho mảng 1 chiều)
  b.In ra màn hình menu và thực hiện các chức năng :
    1. Xem danh sach sinh vien : in ra tất cả sinh viên ra màn hình
    2. Them sinh vien : thêm sinh viên mới vào danh sách (kiểm tra mã cho sinh viên không được trùng nhau )
    3. Tim sinh vien : tìm sinh viên theo MaSV , nếu tìm thấy trả về thông tin của sinh viên , ngược lại xuất thông báo “Không tìm thấy sinh viên có mã số xxx” với xxx là MaSV 
    4. Cap nhat thong tin sinh vien : Cập nhật tất cả các thông tin của sinh viên ( trừ MaSV )
