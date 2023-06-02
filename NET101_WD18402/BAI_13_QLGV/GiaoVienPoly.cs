using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLGV
{
    internal class GiaoVienPoly :GiaoVien
    {
        private string nganhDay;

        //ctor tab
        public GiaoVienPoly()
        {

        }
        //generate constructor
        public GiaoVienPoly(int id, string ten, double soGioDay, string nganhDay) : base(id, ten, soGioDay)
        {
            this.nganhDay = nganhDay;
        }
        //property

        public string NganhDay { get => nganhDay; set => nganhDay = value; }

        //override InThongTin()
        //-> phải có quyền kế thừa: virtual
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine(nganhDay);
        }

    }
}
