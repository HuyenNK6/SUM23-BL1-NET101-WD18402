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
            Console.WriteLine("Nhập số giờ dạy min= ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số giờ dạy max= ");
            double max = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < _lstGV.Count; i++)
            {
                if (_lstGV[i].SoGioDay >= min &&
                        _lstGV[i].SoGioDay <= max)
                {
                    _lstGV[i].InThongTin();
                    count++;//nếu tìm thấy thì tăng count 1 đơn vị
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Không tìm thấy!!");
            }
            else
            {
                Console.WriteLine($"Có {count} GV có số giờ dạy trong khoảng" +
                                  $" từ {min} đến {max}");
            }
        }
        public void Xoa()
        {
            Console.WriteLine("Nhập id cần xóa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            //for tab
            for (int i = 0; i < _lstGV.Count; i++)
            {
                //tìm kiếm
                if (_lstGV[i].Id == id)
                {
                    _lstGV[i].InThongTin();//vì chỉ có 1 thôi
                    _lstGV.RemoveAt(i);//xóa đối tượng tại vị trí i
                    Console.WriteLine("Đã xóa thành công !!!!");
                    return; //nếu tìm thấy thì thoát luôn
                }
            }
            //foreach (var gv in _lstGV)
            //{
            //    if(gv.Id == id)
            //    {
            //        _lstGV.Remove(gv);
            //        return;
            //    }
            //}
            Console.WriteLine("Không tìm thấy!!");
        }
        public void Sua()
        {
            //tìm GV có id nhập từ bàn phím -> sửa số giờ dạy
            Console.WriteLine("Nhập id cần sửa thông tin: ");
            int id = Convert.ToInt32(Console.ReadLine());
            //for tab
            for (int i = 0; i < _lstGV.Count; i++)
            {
                //tìm kiếm
                if (_lstGV[i].Id == id)
                {
                    //trước
                    _lstGV[i].InThongTin();
                    Console.WriteLine("Nhập số giờ dạy mới= ");
                    //cập nhật lại số giờ
                    _lstGV[i].SoGioDay= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Số giờ dạy đã sửa thành công!!");
                    //sau
                    _lstGV[i].InThongTin();
                    return; 
                }
            }
            Console.WriteLine("Không tìm thấy!!");
        }
        public void SapXep()
        {
            //sắp xếp theo số giờ dạy
            //cách 1: ko làm thay đổi ds gốc
            //biểu thức lambda
            // tham số => biểu thức
            // => là toán tử lambda
            //x là tham số đại diện cho đối tượng GV trong list
            Console.WriteLine("C1: Tăng dần");
            foreach (var item in _lstGV.OrderBy(x => x.SoGioDay))
            {
                item.InThongTin();
            }
            Console.WriteLine("C1: Giảm dần");
            foreach (var item in _lstGV.OrderByDescending(x => x.SoGioDay))
            {
                item.InThongTin();
            }
            //cách 2: làm thay đổi ds gốc
            Console.WriteLine("C2: Tăng dần");
            _lstGV = _lstGV.OrderBy(gv => gv.SoGioDay).ToList();
            XuatDS(); 
            Console.WriteLine("C2: Giảm dần");
            _lstGV = _lstGV.OrderByDescending(gv => gv.SoGioDay).ToList();
            XuatDS(); 
        }

        public void KeThua()
        {
            GiaoVienPoly gvPoly = new GiaoVienPoly(66, "Minh", 40, "PTPM");
            gvPoly.InThongTin();
        }
    }
    
}
