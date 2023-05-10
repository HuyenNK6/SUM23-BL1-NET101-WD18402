using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_EP_KIEU
{
    internal class Program
    {/*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */
        static void Main(string[] args)
        {
            //PHẦN 1: ép kiểu giữa các số
            //ép kiểu ngầm định
            int a = 5;
            double b = a;
            Console.WriteLine($"b= {b}");
            //ép kiểu tường minh
            double c = 8.2;
            int d = (int) c;
            Console.WriteLine($"d= {d}");

            //PHẦN 2: ép kiểu từ string về số
            string num1 = "3";
            string num2 = "7";
            string result= num1 + num2; //cộng chuỗi
            Console.WriteLine($"result= {result}");

            //c1: dùng Parse
            int so1= int.Parse(num1);
            int so2= int.Parse(num2);
            int tong = so1 + so2;
            Console.WriteLine($"tong= {tong}");
            //c2: dùng Convert
            int so3 = Convert.ToInt32(num1);
            int so4= Convert.ToInt32(num2);
            int tong2 = so3 + so4;
            Console.WriteLine($"tong= {tong2}");
        }
    }
}
