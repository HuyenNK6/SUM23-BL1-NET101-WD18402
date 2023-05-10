using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_KHAI_BAO_BIEN
{
    internal class Program
    {
        /*
        * Bài 1.1 Khai báo biến
        * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến được khởi tạo trong bộ nhớ ảo khi chương trình khởi chạy.
        *
        * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
        *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
        *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
        * 1. <Kiểu dữ liệu> 
        *  + Số nguyên:sbyte, byte, long, int
        *  + Sô thực: float, double, decimal
        *  + Chuỗi hoặc ký tự: string, char
        *  + Logic: bool
        *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
        * 2. <Tên Biến>
        *  + Quy tắc:
        *      - Tên biến phải có nghĩa
        *      - Có phân biệt chữ hoa chữ thường
        *      - Không bắt đầu bởi số, không dùng từ khóa
        *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
        *  + Khai báo tên biến với 2 từ trở lên:
        *      - Cách 1: normal = firstname
        *      - Cách 2: CamelCase = firstName
        *      - Cách 3: Under_Score = first_name, first_Name (hay còn gọi là snake_case)
        *      - Cách 3: Pascal Case = SinhVien
        *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
        *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
        *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
        *      - int _year = 1989;
        * 3.<Giá trị>
        *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
        *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
        *
        */
        static void Main(string[] args)
        {
            int namSinh = 2004;
            double diem = 8.2;
            char c = 'C';
            bool check = false;
            string hoTen = "HuyenNK6";
            float f;

            //var: tất cả các kiểu dữ liệu
            //phải bắt buộc khởi tạo giá trị
            var v1 = 5;
            var v2 = "Poly";
            var v3 = true;
            var v4 = 7.4;
            // var v5;

            //cw tab
            Console.WriteLine(namSinh);
            Console.WriteLine("Tuoi cua ban la: " + (2023 - namSinh));
            Console.WriteLine("Diem mon " + c + " cua tui la: " + diem);
            Console.WriteLine($"Diem mon {c} cua tui la: {diem}");
            Console.WriteLine($"Xin chao {hoTen}");
        }
    }
}
/* Cách chạy khi có nhiều project
 * c1: click chuột phải vào project => Set as startup project...
 * c2: thay đổi tên project trên phần Start
 */