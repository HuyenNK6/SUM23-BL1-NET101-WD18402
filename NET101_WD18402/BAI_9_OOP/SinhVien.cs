using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_9_OOP
{
    internal class SinhVien
    {
        //1.Thuộc tính
        //phải private tất cả thuộc tính
        private string msv;
        private string ten;
        private int namSinh;
        private double diem;
        private int gioiTinh; //0- nam, 1- nữ

        //2. constructor - hàm tạo
        // => tạo đối tượng
        //2.1 constructor ko tham số
        //ctor tab tab
        //public SinhVien()
        //{
        //    
        //}
        public SinhVien()
        {
            namSinh = 2004;
            Console.WriteLine("Đây là Sinh Viên!");
        }
        //2.2 constructor có tham số
        //- bôi đen toàn bộ thuộc tính
        //- click chuột phải => Quick Action...
        //- Generate constructor(...
        //this: biến tham chiếu tới đối tượng của lớp hiện tại
        public SinhVien(string msv, string ten, int namSinh, double diem, int gioiTinh)
        {
            this.msv = msv;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
            this.gioiTinh = gioiTinh;
        }
        //3. Properties
        //get-set
        //- bôi đen toàn bộ thuộc tính
        //- click chuột phải => Quick Action...
        //- Encapsulate field (... -> dưới
        public string Msv { get => msv; set => msv = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        
        //4. Phương thức InThongTin()

        public void InThongTin()
        {
            Console.WriteLine($"Sinh vien: " +
                $"{msv}| " +
                $"{ten}| " +
                $"{DateTime.Now.Year- namSinh}| " +
                $"{diem}| " +
                $"{(gioiTinh == 0 ? "Nam": "Nữ")} | " +
                $"{GetGioiTinh()}");
        }
        //bổ sung
        public string GetGioiTinh()
        {
            if(gioiTinh == 0)
            {
                return "Nam";
            }
            return "Nu";
        }
    }
}
