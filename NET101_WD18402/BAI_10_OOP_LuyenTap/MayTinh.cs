using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10_OOP_LuyenTap
{/* 1. Tạo class MayTinh gồm các thuộc tính
 * - ma: string
 * - hang: string
 * - namSX: int
 * - gia: double
 * - trangThai: int (1- mới, 2- cũ)*/
    internal class MayTinh
    {
        //1. thuộc tính
        private string ma;
        private string hang;
        private int namSX;
        private double gia;
        private int trangThai;

        //2. constructor
        //ctor tab
        public MayTinh()
        {

        }
        //click -> quick -> generate constructor
        public MayTinh(string ma, string hang, int namSX, double gia, int trangThai)
        {
            this.ma = ma;
            this.hang = hang;
            this.namSX = namSX;
            this.gia = gia;
            this.trangThai = trangThai;
        }
        //3. properties
        public string Ma { get => ma; set => ma = value; }
        public string Hang { get => hang; set => hang = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public double Gia { get => gia; set => gia = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
       
        //4. InThongTin()
        public void InThongTin()
        {
            Console.WriteLine($"{ma}| {hang}| {namSX}| " +
                $"{TinhLaiXuat()}| {(trangThai ==1? "Moi": "Cu")}");
        }
        public double TinhLaiXuat()
        {
            return gia * 0.08;
        }

    }
}
