using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI_15_CHUOI_REGEX
{
    internal class Program
    {
        #region Xử lý Chuỗi
        /*
         * 1. Khai báo chuỗi
         * string s= "...";
         * 
         * 2. Lấy chiều dài chuỗi: str.Length: lấy chiều dài chuỗi
         *
         * 3. So sánh 2 chuỗi
         * Cách 1: Phép so sánh == sẽ so sánh 2 object có cùng trỏ vào 1 ô nhớ hay không. Nếu đúng thì trả về true, sai sẽ trả về false.
	     * Cách 2: sử dụng Equals
	       Phương thức equals() sẽ so sánh 2 object nhưng chỉ so sánh về mặt giá trị. 
	       Nếu giá trị bằng nhau thì sẽ trả về true, ngược lại sẽ trả về false
         * Cách 3: sử dụng String.Compare (phân biệt hoa thường và không phân biệt hoa thường)
         * String.Compare(str1,str2,<ignoreCase>)
         * true- không phân biệt, false-có phân biệt chữ hoa chữ thường.
         
         *
         * 4. Kiểm tra đầu chuỗi và cuối chuỗi có tồn tại chuỗi cần tìm hay không?
         * StartsWith & EndsWith là 2 hàm kiểm tra xem đầu chuỗi hoặc cuối chuỗi có tồn tại ký tự hoặc chuỗi ký tự cần tìm hay không?
         *
         * 5. Kiểm tra sự tồn tại của chuỗi 1 trong chuỗi 2
         * Str1.Contains(Str2) :Kiểm tra trong chuỗi Str1 có chuỗi Str2 hay không?
         *
         * 6. Tìm vị trí hiển thị của chuỗi
         * Str1.IndexOf("chuỗi"): Vị trí xuất hiện đầu tiên của ký tự "chuỗi" trong Str1.
            Trả về -1 nếu trong Str1 không có ký tự "chuỗi".
         * 7. Tìm vị trí xuất hiện cuối cùng của chuỗi
            Str1.LastIndexOf("chuỗi"): Vị trí xuất hiện cuối cùng của ký tự "chuỗi" trong Str1.
            Trả về -1 nếu trong Str1 không có ký tự "chuỗi".
         * 8.Kiểm tra xem chuỗi 1 có bắt bầu bằng ký tự trong chuỗi 2 không.
            Str1.StartsWith(Str2):Kiểm tra xem chuỗi Str1 có bắt đầu bằng chuỗi Str2 không?
         * 9. Thay thế chuỗi
            Str = Str.Replace(",","."):Thay thế dấu ',' thành dấu '.' trong chuỗi Str.
            Str = Str.Replace("xử lý","hàm chuỗi"):Thay thế chuỗi 'xử lý' thành chuỗi ''hàm chuỗi' trong chuỗi Str
            Thay thế chuỗi đầu tiên được tim thấy và tùy chỉnh số lượng thay thế của chuỗi.
         * 10. Cắt chuỗi con
            Str1 = Str.SubString(4):Tạo chuỗi con từ chuỗi Str bắt đầu từ vị trí 4 đến hết
            substring(int startIndex,int length)    
            Str1 = Str.Substring(0,8): Cắt chuỗi từ vị trí đầu tiên(vị trí 0), có độ dài bằng 8
         * 11. Tách chuỗi .Split (Chuyển từ chuỗi string sang mảng Array)
            string str="các hàm xử lý chuỗi, xử lý chuỗi trong c#";
            string[] arrListStr = str.Split(',');//tách trong chuỗi str trên khi gặp ký tự ','
            kết quả arrListStr[0]='các hàm xử lý chuỗi' và arrListStr[1]='xử lý chuỗi trong c#'
        * 12. Chuyển từ mảng Array sang chuỗi String với String.Join
            Hàm string.join giúp convert chuyển từ mảng array sang chuỗi.
            string[] Array= new string[] { "xử lý", "chuỗi trong", "c#" };
            string str = string.Join(", ", Array);
        * 13. Chuyển chữ hoa sang chữ thường và ngược lại
            Str1 = Str.ToLower() :Chuyển chuỗi sang chữ thường
            Str1 = Str.ToUpper() Chuyển chuỗi sang chữ hoa
        * 14. Cắt hết khoảng trắng ở đầu và cuối.
            Str = Str.Trim() Cắt hết khoảng trắng ở đầu và cuối chuỗi
            Str = Str.TrimLeft() Cắt hết khoảng trắng ở đầu chuỗi
            Str = Str.TrimRight() Cắt hết khoảng trắng ở cuối chuỗi
        * 15. Xóa chuỗi
            Str1.Remove(2): Xóa chuỗi Str1 từ vị trí 2 đến hết.
            Str.Remove(4,9) : Xóa 1 chuỗi con trong Str1 có chiều dài là 6. Từ vị trí 4 đến vị trí 9
        * 16. Cắt/Xóa ký tự đặc biệt hay bất kỳ ở đầu và cuối chuỗi.
            Key serch: xóa ký tự cuối cùng hay đầu chuỗi hay bất kỳ trong c#
            Xóa ký tự đặc biệt hay chỉ định bất kỳ ở đầu chuỗi:
            TrimStart(KyTuCanXoa)
            Hàm xóa đầu chuỗi những ký tự hoặc chuỗi ký tự được truyền vào.
            Có thể xóa được cả mảng ký tự cần xóa với
            KyTuCanXoa: là 1 ký tự hoặc 1 mảng ký tự cần xóa
            string MyString = "-Xử lý chuỗi C#";
            string NewString = MyString.TrimStart('-');
            Xóa ký tự đặc biệt hay chỉ định bất kỳ ở cuối chuỗi:
            TrimEnd(KyTuCanXoa)
            Hàm xóa cuối chuỗi những ký tự hoặc chuỗi ký tự được truyền vào.
            Có thể xóa được cả mảng ký tự cần xóa với
            KyTuCanXoa: là 1 ký tự hoặc 1 mảng ký tự cần xóa
         */
        #endregion

        #region REGEX: biểu thức chính quy
        /*
         * REGEX hoặc Regular Expression trong C#Regular Expression hay tiếng Việt được gọi là Biểu thức chính quy, 
         * là một cấu trúc rất mạnh để mô tả một chuỗi theo cách thống nhất chung.

        Regular Expression bao gồm tập hợp các ký tự, toán tử hay ký hiệu toán học
        nhằm biểu thị một chuỗi theo cấu trúc chung mà mọi người học theo. */
        /* 
         * 1. Các lớp ký tự Regex
            Regex	Mô tả
            [...]	trả về một ký tự phù hợp
            [abc]	a, b, hoặc c
            [^abc]	Bất kỳ ký tự nào ngoại trừ a, b, hoặc c
            [a-zA-Z]	ký tự chữ từ a tới z hoặc A tới Z
            [0-9]	ký tự số 0 tới 9
         */
        /* 2. Số lượng ký tự trong Regex
         * Regex	Mô tả	Pattern	Ví dụ
            X?	X xảy ra một hoặc không lần	hellos?	hello, hellos, helloss
            X+	X xảy ra một hoặc nhiều lần	Version \w-\w+	Version A-b1_1
            X*	X xảy ra không hoặc nhiều lần	A*B*C*	AAACC
            X{n}	X chỉ xảy ra n lần	\d{4}	2018, 20189, 201
            X{n,}	X xảy ra n hoặc nhiều lần	\d{4,}	2018, 20189, 201
            X{y,z}	X xảy ra ít nhất y lần nhưng nhỏ hơn z lần	\d{2,3}	2018, 201
         */

        /*3. Ký tự đặc biệt trong Regex
         * Regex	Mô tả
            .	Bất kỳ ký tự nào
            ^	Có 2 cách sử dụng.
                1. Đánh dấu bắt đầu của một dòng, một chuỗi.
                2. Nếuu sử dụng trong dấu [...] thì nó có nghĩa là phủ định.
                    [0-9] [^0-9]
            $	Đánh dấu Kết thúc của một dòng
            \d	Bất kỳ chữ số nào, viết tắt của [0-9]
            \D	Bất kỳ ký tự nào không phải chữ số, viết tắt của [^0-9]
            \s	Bất kỳ ký tự trống nào (như dấu cách, tab, xuống dòng, ...), viết tắt của [\t\n\x0B\f\r]
            \S	Bất kỳ ký tự trống nào không phải ký tự trống, viết tắt của [^\s]
            \w	Bất kỳ ký tự chữ nào (chữ cái và chữ số và dấu gạch dưới), 
                viết tắt của [a-zA-Z_0-9]
            \W	Bất kỳ ký tự nào không phải chữ cái và chữ sốvà dấu gạch dưới, 
                viết tắt của [^\w]
            \b	Ranh giới của một từ
            \B	Không phải ranh giới của một từ
         */
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //XuLyChuoi();
            string ten = KiemTraChu();
            Console.WriteLine("Tên là: "+ ten);
            int tuoi = KiemTraSo();
            Console.WriteLine("Tuổi là: "+ tuoi);
        }
        static void XuLyChuoi()
        {
            string[] arrTen = { "Ngoc", "Ha", "Lan", "hang", "Tuyet" };
            Console.WriteLine("----Chuỗi bắt đầu/ kết thúc----");
            foreach (var ten in arrTen)
            {
                if (ten.ToUpper().StartsWith("H")){
                    Console.WriteLine(ten);
                }
            }
            Console.WriteLine("-----Chuỗi chứa-----");
            foreach (var item in arrTen)
            {
                if (item.ToLower().Contains("n"))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("--------Tách chuỗi---------");
            string s = "            FPT Polytechnic Ha Noi             ";
            string[] arrChuoi = s.Trim().Split(' ');
            Console.WriteLine("arrChuoi[1]= "+ arrChuoi[1]);
            foreach (var chuoi in arrChuoi)
            {
                Console.WriteLine(chuoi);
            }
            Console.WriteLine("-----Nối chuỗi---------");
            string result = string.Join("- ", arrChuoi);
            Console.WriteLine( result);
            Console.WriteLine("-----Cắt chuỗi con-----");
            string str = result.Substring(4);
            Console.WriteLine(str);
            string str2 = result.Substring(4, 10);
            Console.WriteLine(str2);
        }
        //chỉ dc phép nhập chữ -> nếu sai bắt nhập lại
        static string KiemTraChu()
        {
            string s;
            do
            {
                Console.WriteLine("Nhập vào chữ: ");
                s = Console.ReadLine();
            } while (!Regex.IsMatch(s, @"^[a-zA-Z ]+$"));
            return s;
            //@"^[a-zA-Z ]+$" tương ứng @"^[a-zA-Z\s]+$"
        }
        static int KiemTraSo()
        {
            string s;
            do
            {
                Console.WriteLine("Nhập vào so: ");
                s = Console.ReadLine();
            } while (!Regex.IsMatch(s, @"^[\d]+$"));
            return Convert.ToInt32(s);
            //@"^[0-9]+$" tương ứng @"^[\d]+$"
        }
        //kiểm tra số double
        //kiểm tra số điện thoại
        //kiểm tra email có đuôi là @fpt.edu.vn
    }
}
