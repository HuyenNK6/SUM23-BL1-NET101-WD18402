using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLGV
{
    internal class QLGV
    {
        List<GiaoVien> _lstGV = new List<GiaoVien>();
        //fakeData -> ko có điểm
        //ctor tab
        public QLGV()
        {//tạo sẵn list chứa 5 đối tượng
            _lstGV.Add(new GiaoVien(1, "Dung", 20));
            _lstGV.Add(new GiaoVien(2, "Tien", 32));
            _lstGV.Add(new GiaoVien(3, "Phong", 50));
            _lstGV.Add(new GiaoVien(4, "Khanh", 28));
            _lstGV.Add(new GiaoVien(5, "Linh", 41));
        }
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đối tượng
                GiaoVien gv = new GiaoVien();
                //2. nhập tt
                Console.WriteLine("Nhập id= ");
                gv.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tên= ");
                gv.Ten = Console.ReadLine();
                Console.WriteLine("Nhập số giờ dạy= ");
                gv.SoGioDay = Convert.ToDouble(Console.ReadLine());
                //3. thêm đối tượng vào ds
                _lstGV.Add(gv);
                //4. hỏi tiếp tục
                Console.WriteLine("Có muốn tiếp tục ko? (co/ko) ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc == "co");
        }
        public void XuatDS()
        {//kiểm tra
            if(_lstGV.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!!");
                return;
            }
            foreach (var item in _lstGV)
            {
                item.InThongTin();
            }
        }

        public void TimKiemTheoID()
        {
            Console.WriteLine("Nhập id cần tìm: ");
            int id = Convert.ToInt32(Console.ReadLine());
            //for tab
            for (int i = 0; i < _lstGV.Count; i++)
            {
                //tìm kiếm
                if (_lstGV[i].Id == id)
                {
                    _lstGV[i].InThongTin();//vì chỉ có 1 thôi
                    return; //nếu tìm thấy thì thoát luôn
                }
            }
            Console.WriteLine("Không tìm thấy!!");
        }

        public void TimKiemTheoKhoang()
        {
            //min- max 
            // số giờ >= min và <= max
        }
        public void Xoa()
        {

        }
        public void Sua()
        {

        }
        public void SapXep()
        {
            
        }
    }
    
}
