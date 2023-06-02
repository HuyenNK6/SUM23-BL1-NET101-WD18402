using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_KE_THUA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng = ctor có tham số
            GiangVien gv = new GiangVien("Huyen", 2004, 2,
                            "HuyenNK6", "huyennk6@fe.edu.vn");
            gv.InThongTin();
            //tạo đối tượng = ctor ko tham số
            GiangVien gvFPT = new GiangVien();
            gvFPT.Ten = "Dung";
            gvFPT.NamSinh = 2000;
            gvFPT.GioiTinh = 1;
            gvFPT.Account = "Dungna29";
            gvFPT.MailFe = "dungna29@fe.edu.vn";
            gvFPT.InThongTin();
        }
    }
}
