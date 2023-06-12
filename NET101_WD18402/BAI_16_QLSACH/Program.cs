using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_16_QLSACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            SachService service = new SachService();
            int chon;
            Console.WriteLine("1. Nhập 1 đối tượng hoặc danh sách đối tượng\r\n" +
                "2. Xuất danh sách đối tượng\r\n" +
                "3. Xuất danh sách Sách có giá trong khoảng người dùng nhập\r\n" +
                "4. Sắp xếp giảm dần theo năm xuất bản\r\n" +
                "5. Tìm kiếm sách theo Code\r\n" +
                "6. Xóa Sách theo code\r\n" +
                "7. Sắp xếp tăng dần theo tên\r\n" +
                "8. Sắp xếp giảm dần theo giá\r\n" +
                "9. Xuất danh sách các  Sách được xuất bản sau năm 2000\r\n" +
                "10. Tìm tất cả Sách có thể loại chính xác là Sách khoa học\r\n" +
                "11. Tìm tất cả Sách có tên gần đúng (tên chứa) được nhập từ bàn phím\r\n" +
                "12. Xuất thông tin của Sách có giá lớn nhất và bé nhất\r\n" +
                "13. Đếm xem có tất cả bao nhiêu Sách có giá ngoài khoảng người dùng nhập\r\n" +
                "14. Tìm tất cả sách có mã bắt đầu bằng SGK" +
                "0.Thoát ");
            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("Mời chọn: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        service.NhapDS();
                        break;
                    case 2:
                        service.XuatDS();
                        break;
                    case 3:
                        service.DSTheoKhoangGia();
                        break;
                    case 11:
                        service.DSTheoTenGanDung();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Mời nhập lại!!!!!!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
