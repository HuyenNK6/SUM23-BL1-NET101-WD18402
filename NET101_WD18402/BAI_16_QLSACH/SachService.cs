using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_16_QLSACH
{
    internal class SachService
    {
        List<Sach> lstSachs= new List<Sach>();
        public SachService()
        {
            lstSachs.Add(new Sach("100001", "Hạt giống tâm hồn", "Self-help", 2019, 90000));
            lstSachs.Add(new Sach("100002", "Phân tích kỹ thuật", "Khoa học", 2021, 120000));
            lstSachs.Add(new Sach("100003", "The Discoverers", "Khoa học", 2015, 150000));
            lstSachs.Add(new Sach("100004", "Rùa và thỏ", "Truyện", 2010, 50000));
            lstSachs.Add(new Sach("100005", "Vũ trụ", "Khoa học", 2023, 80000));
            lstSachs.Add(new Sach("100006", "Đắc nhân tâm", "Self-help", 2022, 100000));
        }
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đối tượng
                Sach sach = new Sach();
                //2. nhập tt
                Console.WriteLine("Nhập code: ");
                sach.Code = Console.ReadLine();
                Console.WriteLine("Nhập tên: ");
                sach.Ten = Console.ReadLine();
                Console.WriteLine("Nhập thể loại: ");
                sach.TheLoai = Console.ReadLine();
                Console.WriteLine("Nhập năm xuất bản: ");
                sach.NamXuatBan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập giá: ");
                sach.Gia = Convert.ToDouble(Console.ReadLine());
                //3. thêm đối tượng vào ds
                lstSachs.Add(sach);
                //4. hỏi tiếp tục
                Console.WriteLine("Có muốn tiếp tục ko? ");
                tiepTuc= Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        public void XuatDS()
        {
            foreach (var item in lstSachs)
            {
                item.InThongTin();
            }
        }
           //3. Xuất danh sách Sách có giá trong khoảng người dùng nhập
        public void DSTheoKhoangGia()
        {
            Console.WriteLine("Nhập giá min: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập giá max: ");
            double max = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < lstSachs.Count; i++)
            {
                if (lstSachs[i].Gia > min && lstSachs[i].Gia < max)
                {
                    lstSachs[i].InThongTin();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Không tìm thấy!!!");
            }
        } 
        //4. Sắp xếp giảm dần theo năm xuất bản
           //5. Tìm kiếm sách theoCode
           //6. Xóa Sách theo code
           //7. Sắp xếp tăng dần theo tên
           //8. Sắp xếp giảm dần theo giá
           //9. Xuất danh sách các  Sách được xuất bản sau năm 2000
           //10. Tìm tất cả Sách có thể loại chính xác là Sách khoa học
           //11. Tìm tất cả Sách có tên gần đúng(tên chứa) được nhập từ bàn phím
        public void DSTheoTenGanDung()
        {
            Console.WriteLine("Nhập tên sách cần tìm: ");
            string input = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < lstSachs.Count; i++)
            {
                if (lstSachs[i].Ten.Contains(input))
                {
                    lstSachs[i].InThongTin();
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Không tìm thấy!!!");
            }
        } 
        //12. Xuất thông tin của Sách có giá lớn nhất và bé nhất
         //13. Đếm xem có tất cả bao nhiêu Sách có giá ngoài khoảng người dùng nhập
         // 14. Tìm tất cả sách có mã bắt đầu bằng "SGK"
         //15. kế thừa

    }
}
