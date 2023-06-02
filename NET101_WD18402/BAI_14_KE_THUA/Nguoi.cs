using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_KE_THUA
{
    internal class Nguoi
    {
        private string ten;
        private int namSinh;
        private int gioiTinh;
        public Nguoi()
        {

        }

        public Nguoi(string ten, int namSinh, int gioiTinh)
        {
            this.ten = ten;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
        }

        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    
        //virtual: cấp quyền kế thừa
        public virtual void InThongTin()
        {
            Console.WriteLine($"{ten}|" +
                $" {DateTime.Now.Year- namSinh}| " +
                $" {(gioiTinh ==1 ?"Nam":"Nữ")}");
        }
    }
}
