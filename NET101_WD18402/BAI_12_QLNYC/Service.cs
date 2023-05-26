using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12_QLNYC
{
    internal class Service
    {
        //toàn cục
        //tạo 1 list NYC
        List<NguoiYeuCu> _lstNYC= new List<NguoiYeuCu>();
        public void NhapDS()
        {
            string tiepTuc; //kiểm tra xem ng dùng có tiếp tục ko
            do
            {
                //1. khởi tạo đối tượng
                NguoiYeuCu nyc= new NguoiYeuCu();
                //2. nhập thông tin cho đối tượng
                Console.WriteLine("Nhap id= ");
                nyc.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap ten= ");
                nyc.Ten= Console.ReadLine();
                Console.WriteLine("Nhap gioiTinh (0/1)= ");
                nyc.GioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap nam sinh= ");
                nyc.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap so thich= ");
                nyc.SoThich = Console.ReadLine();
                //3. thêm đối tượng vào danh sách
                _lstNYC.Add(nyc);
                //4. hỏi tiếp tục hay ko?
                Console.WriteLine("Co muon tiep tuc ko (co/ko)? ");
                tiepTuc = Console.ReadLine();   
            } while (tiepTuc == "co");
        }
        public void XuatDS()
        {
            foreach (var item in _lstNYC)
            {
                item.InThongTin();
            }
        }
    }
}
