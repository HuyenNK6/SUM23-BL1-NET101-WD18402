using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLGV
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
            QLGV ql = new QLGV();
            int chon;
            do
            {
                Console.WriteLine("-----MENU----");
                Console.WriteLine("1. Nhập DS");
                Console.WriteLine("2. Xuất DS");
                Console.WriteLine("3. Tìm kiếm theo khoảng");
                Console.WriteLine("4. Tìm theo id");
                Console.WriteLine("5. Xóa theo id");
                Console.WriteLine("6. Sửa theo id");
                Console.WriteLine("7. Sắp xếp theo số giờ dạy");
                Console.WriteLine("0. Thoát CT");
                Console.WriteLine("--------------");
                Console.WriteLine("-----Mời chọn: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        ql.TimKiemTheoKhoang();
                        break;
                    case 4:
                        ql.TimKiemTheoID();
                        break;
                    case 5:
                        ql.Xoa();
                        break;
                    case 6:
                        ql.Sua();
                        break;
                    case 7:
                        ql.SapXep();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhập lại!!!!!");
                        break;
                }

            } while (chon!=0);

        }
    }
}
