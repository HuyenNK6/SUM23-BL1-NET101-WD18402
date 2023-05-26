using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12_QLNYC
{
    internal class NguoiYeuCu
    {
        //1. thuộc tính
        private int id;
        private string ten;
        private int gioiTinh;
        private int namSinh;
        private string soThich;

        //2. constructor
        //2.1 ctor tab
        public NguoiYeuCu()
        {

        }
        //2.2 ctor có tham số ->> Generate ctor
        public NguoiYeuCu(int id, string ten, int gioiTinh, int namSinh, string soThich)
        {
            this.id = id;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.soThich = soThich;
        }
        //3. Properties
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string SoThich { get => soThich; set => soThich = value; }
    
        public void InThongTin()
        {
            Console.WriteLine($"{id}| {ten}| " +
                $"{(gioiTinh == 0? "Nam": "Nu")}| " +
                $"{DateTime.Now.Year- namSinh}| " +
                $"{soThich}");
        }
    }
}
