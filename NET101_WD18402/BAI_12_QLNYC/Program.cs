using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12_QLNYC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Service service = new Service();
            int chon;
            do
            {
                Console.WriteLine("----MENU-----");
                Console.WriteLine("1. Nhap ");
                Console.WriteLine("2. Xuat ");
                Console.WriteLine("0. Thoat ");
                Console.WriteLine("-------------");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        service.NhapDS();
                        break;
                    case 2:
                        service.XuatDS();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai!!!!!");
                        break;
                }
            } while (chon!=0);
        }
    }
}
