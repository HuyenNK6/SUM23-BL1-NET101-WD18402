using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10_OOP_LuyenTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MayTinh mt = new MayTinh();
            Console.WriteLine("-------NHAP-----------");
            Console.WriteLine("Nhap ma: ");
            mt.Ma = Console.ReadLine();
            Console.WriteLine("Nhap hang: ");
            mt.Hang = Console.ReadLine();
            Console.WriteLine("Nhap nam sx: ");
            mt.NamSX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia: ");
            mt.Gia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap trang thai (1/2): ");
            mt.TrangThai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------XUAT-----------");
            mt.InThongTin();
            ///////////////////////////
            MayTinh mt1 = new MayTinh("MT1", "Dell", 2020, 15, 2);
            MayTinh mt2 = new MayTinh("MT2", "Asus", 2022, 40, 1);
            MayTinh mt3 = new MayTinh("MT3", "Mac", 2023, 50, 1);
            MayTinh mt4 = new MayTinh("MT4", "Hp", 2019, 20, 2);
            MayTinh mt5 = new MayTinh("MT5", "Acer", 2022, 18, 2);
            //1. khởi tạo list máy tính
            List<MayTinh> lstMT = new List<MayTinh>();
            //2. thêm đối tượng vào list
            lstMT.Add(mt);//0
            lstMT.Add(mt1);//1
            lstMT.Add(mt2);//2
            lstMT.Add(mt3);
            lstMT.Add(mt4);
            lstMT.Add(mt5);
            //3. truy xuất
            Console.WriteLine(lstMT[2].Hang);
            lstMT[2].InThongTin();

            //4. duyệt
            //cách 1: for tab
            //lstMT[i]: đối tượng máy tính tại vị trí i
            for (int i = 0; i < lstMT.Count; i++)
            {
                lstMT[i].InThongTin();
            }
            //cách 2: fore tab
            //item là đối tượng Máy tính
            foreach (var item in lstMT)
            {
                item.InThongTin();
            }
        }   
    }
}
