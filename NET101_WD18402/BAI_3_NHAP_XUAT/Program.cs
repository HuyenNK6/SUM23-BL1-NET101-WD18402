using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_NHAP_XUAT
{
    internal class Program
    {
        /*
        * BÀI 3 Nhập xuất dữ liệu từ bàn phím
        *  1. Xuất dữ liệu ra màn hình
        *      + Phím tắt : cw + tab
        *      + Console.WriteLine(); Ghi xong thì xuống dòng
        *      + Console.Write(); Ghi xong thì không xuống dòng
        *  2. Nhập dữ liệu từ bàn phím:
        *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASCII
        *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("==========NHẬP==========");
            Console.WriteLine("Nhập tên NYC: ");
            string ten= Console.ReadLine();
            Console.WriteLine("Nhập tuổi NYC: ");
            //int tuoi= Console.ReadLine(); =>LỖI
            //vì Console.ReadLine(); => trả về string
            // ép kiểu từ string về số int
            int tuoi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==========XUẤT==========");
            Console.WriteLine($"NYC tên là: {ten}");
            Console.WriteLine($"Tuổi NYC là: {tuoi}");
        }
    }
}
/*BTVN:
 * Nhập và xuất thông tin của Trà sữa NYC thích ra màn hình:
 * - Tên hãng trà sữa: string
 * - Vị : string
 * - Size: string
 * - Giá: int
 * - Số lượng: int
 */