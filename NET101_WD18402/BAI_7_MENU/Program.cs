using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7_MENU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.Unicode;
            Console.InputEncoding= Encoding.Unicode;
            Menu();
            Console.WriteLine("To be continue...");
        }
        static void Menu()
        {
            int chon;
            do
            {
                Console.WriteLine("======MENU=========");
                Console.WriteLine("1. Gỏi gà măng cụt");
                Console.WriteLine("2. Xa lát giun");
                Console.WriteLine("3. Trà mãng cầu");
                Console.WriteLine("4. Gỏi xoài");
                Console.WriteLine("0. Thoát CT");
                Console.WriteLine("====================");
                Console.WriteLine("Mời chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
                //sw tab tab
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1. Gỏi gà măng cụt");
                        break;
                    case 2:
                        Console.WriteLine("2. Xa lát giun");
                        break;
                    case 3:
                        Console.WriteLine("3. Trà mãng cầu");
                        break;
                    case 4:
                        //Console.WriteLine("4. Gỏi xoài");
                        //break;
                    case 0:
                        Console.WriteLine("0. Thoát CT");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Mời chọn lại!!");
                        break;
                }
            } while (chon != 0);
        }

        static void CheckNgayTrongThang()
        {
            //In ra số ngày trong tháng => switch case
            //nếu tháng 2 => kiểm tra năm nhuận
            //xem lại điều kiện năm nhuận
        }
    }
    //nếu quan tâm: nhập ngày hiện tại
    //=> in ra ngày hôm trước và ngày hôm sau
}
