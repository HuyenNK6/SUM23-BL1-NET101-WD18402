using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_KE_THUA
{
    internal class NhanVien : Nguoi
    {
        private string mnv;
        private string chucVu;
        public NhanVien()
        {

        }
        public NhanVien(string ten, int namSinh, int gioiTinh, string mnv, string chucVu) : base(ten, namSinh, gioiTinh)
        {
            this.mnv = mnv;
            this.chucVu = chucVu;
        }

        public string Mnv { get => mnv; set => mnv = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"{mnv}| {chucVu}");
        }
    }
}
