using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_16_QLSACH
{
    internal class Sach
    {
        private string code;
        private string ten;
        private string theLoai;
        private int namXuatBan;
        private double gia;
        public Sach()
        {

        }

        public Sach(string code, string ten, string theLoai, int namXuatBan, double gia)
        {
            this.code = code;
            this.ten = ten;
            this.theLoai = theLoai;
            this.namXuatBan = namXuatBan;
            this.gia = gia;
        }

        public string Code { get => code; set => code = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public double Gia { get => gia; set => gia = value; }

        public void InThongTin()
        {
            Console.WriteLine($"{code}| {ten}| {theLoai}| {namXuatBan}|{gia}");
        }
    }
}
