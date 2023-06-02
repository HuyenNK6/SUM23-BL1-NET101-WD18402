using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_KE_THUA
{
    internal class SinhVien : Nguoi
    {
        private string msv;
        private string mailFpt;
        public SinhVien()
        {

        }

        public SinhVien(string ten, int namSinh, int gioiTinh, string msv, string mailFpt) : base(ten, namSinh, gioiTinh)
        {
            this.Msv = msv;
            this.MailFpt = mailFpt;
        }

        public string Msv { get => msv; set => msv = value; }
        public string MailFpt { get => mailFpt; set => mailFpt = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"{msv}| {mailFpt}");
        }
    }
}
