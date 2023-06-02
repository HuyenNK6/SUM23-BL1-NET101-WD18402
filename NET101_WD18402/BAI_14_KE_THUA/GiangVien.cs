using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_KE_THUA
{
    //kế thừa từ lớp cha là lớp NGƯỜI
    //thông qua dấu :
    //Lớp Con là Lớp GIẢNG VIÊN
    //Con có thể kế thừa dc tất cả thuộc tính & phương thức của Cha
    //trừ constructor
    internal class GiangVien : Nguoi
    {
        //bổ sung thêm các thuộc tính riêng của con
        private string account;
        private string mailFe;
        //ctor tab
        public GiangVien()
        {

        }
        //1. click chuột phải vào tên lớp con
        //-> Quick Action... -> Generate ctor...(thứ 2 từ dưới)
        //2. bôi  đen thuộc tính -> click chuột 
        //-> Quick Action... -> Add parameters tó ctor -> add to ctor có tham số

        public GiangVien(string ten, int namSinh, int gioiTinh, string account, string mailFe) : base(ten, namSinh, gioiTinh)
        {
            this.account = account;
            this.mailFe = mailFe;
        }

        public string Account { get => account; set => account = value; }
        public string MailFe { get => mailFe; set => mailFe = value; }

        //3. click chuột phải -> Quick Action...
        //Generate Override -> tích chọn method

        //this: là biến tham chiếu tới đối tượng của lớp hiện tại
        //supper: là biến tham chiếu tới đối tượng của lớp cha
        //override: ghi đè phương thức
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"{account}| {mailFe}");
        }

       


    }
}
