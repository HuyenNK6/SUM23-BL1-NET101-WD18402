using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_TOAN_TU
{
    internal class Program
    {
        /*
         * 4 Loại toán tử trong lập trình
         *  1. Toán tử số học:
         *  (+ - * / % ++ --)
         *      +: Tính tổng của 2 số hoặc dùng để cộng chuỗi
         *      -: Phép trừ của 2 số
         *      *: Phép nhân của 2 số
         *      /: Phép chia lấy nguyên của 2 số
         *      %: Phép chia lấy dư của 2 số
         *      ++: Tăng lên 1 đơn vị
         *      --: Giảm 1 đơn vị
         *  2. Toán tử so sánh:
         *  (> < >= <= == !=)
         *      >: Lớn hơn
         *      <: nhỏ hơn
         *      >=: lớn hơn hoặc bằng
         *      <=: nhỏ hơn hoặc bằng
         *      ==: so sánh bằng
         *      !=: so sánh khác
         *  3. Toán tử Logic:
         * (&& || !)
         *      &&: Yêu cầu các mệnh đề phải luôn đúng
         *      ||: Yêu cầu 1 trong các mệnh đề dúng là được
         *      !: Lấy giá trị phủ định của mệnh đề.
         *  4. Toán tử gán:
         * (= += -= *= /= %=)
         *      +=: Cộng tiếp với vế bên phải các phép còn lại tương tự
         */

        /*
         * Toán tử ba ngôi
         *  (<biểu thức> ? <kết quả đúng> : <kết quả sai>)
         */
        static void Main(string[] args)
        {
            /* Nhập xuất thông tin của Điện thoại
             * - mã đt: string
             * - tên: string
             * - giá: double
             * - dung lượng: int
             * - trangThai: boolean (true/false)
             *  => in ra: true- máy mới/ false - máy cũ
             */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("===========NHẬP==========");
            Console.WriteLine("Nhập Mã điện thoại: ");
            string ma = Console.ReadLine();
            Console.WriteLine("Nhập Tên điện thoại: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập Giá tiền: ");
            double gia = Convert.ToDouble(Console.ReadLine());
            //ví dụ
            //float price = (float)Convert.ToDouble(Console.ReadLine());
            //float price2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập Dung lượng: ");
            int dungLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập trạng thái (true/false)");
            bool trangThai = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("===========XUẤT==========");
            Console.WriteLine($"Mã điện thoại: {ma}");
            Console.WriteLine($"Tên: {ten}");
            Console.WriteLine($"Giá: {gia}");
            Console.WriteLine($"Dung lượng: {dungLuong}");
            //trangThai ? => trangThai == true
            Console.WriteLine($"Trạng thái: {(trangThai ? "Máy mới" : "Máy cũ")}");
            //!trangThai ? => trangThai == false
            Console.WriteLine($"Trạng thái: {(!trangThai ? "Máy cũ" : "Máy mới")}");
        }
    }
}
