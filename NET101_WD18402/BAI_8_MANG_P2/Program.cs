using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8_MANG_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Nhập tòa học của các bạn: string
             * - nhập tầng học: int
             * - nhập số lượng phòng học tại tầng học đó
             * =>  tạo 1 mảng phòng học tại tầng học đó
             * - nhập số lượng sinh viên trong từng phòng học
             * - xuất toàn bộ mảng
             * - sắp xếp tăng dần mảng
             */
            Console.WriteLine("Nhap toa hoc: ");
            string toa = Console.ReadLine();
            Console.WriteLine("Nhap tang hoc: ");
            int tang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nhap so luong phong tai tang {tang} toa {toa}:");
            int soLuong= Convert.ToInt32(Console.ReadLine());

            int[] arrPhong = new int[soLuong];
            Console.WriteLine("========NHAP MANG==========");
            for (int i = 0; i < arrPhong.Length; i++)
            {
                Console.Write($"Nhap sv tai phong {toa}{tang}0{i+1}= ");
                arrPhong[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("========XUAT MANG==========");
            for (int i = 0; i < arrPhong.Length; i++)
            {
                Console.WriteLine($"SV tai phong {toa}{tang}0{i + 1}={arrPhong[i]}");
            }

        }
    }
}
/* BTVN
 * +-------- Thông tin Ti Vi cửa hàng -------+
	- Mời nhập số lượng ti vi : 
	- Nhập mảng kích cỡ cho từng ti vi : ….
   +------  Xuất thông tin Ti Vi ------ +
	- Số lượng ti vi là :  …… 
	- Kích cỡ trung bình tivi :……  
	- Vị trí Ti vi có kích cỡ lớn nhất là : ….. 
    - Số lượng Ti vi có kích thước là số chẵn là: 
    - Mảng kích cỡ Ti Vi theo thứ tự tăng dần là: 
 */
