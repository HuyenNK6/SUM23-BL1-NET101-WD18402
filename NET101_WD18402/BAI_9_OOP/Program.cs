using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_9_OOP
{
    internal class Program
    {
        /*
   LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG OOP
   1. Định nghĩa:
       Lập trình hướng đối tượng (Object Oriented Programming- OOP) là đưa các đối tượng có trong thế giới
       thực (Sinh viên, ô tô, chó, mèo, người, hoa,...) vào trong lập trình để thao tác với các ĐỐI TƯỢNG
       (thêm, sửa, xóa,...) hoặc với các THUỘC TÍNH là các thông tin của đối tượng.
       Ngoài ra, đối tượng còn có các hành động và luôn phải là động từ thì trong lập trình nó sẽ là 
       METHOD hay còn gọi là phương thức của đối tượng.
   2. 4 tính chất của OOP
       - TC1: ĐÓNG GÓI (Encapsulation)
           Là trạng thái của đối tượng được bảo vệ không cho các truy cập từ code bên ngoài như thay đổi
           trạng thái hay nhìn trực tiếp. Việc cho phép môi trường bên ngoài tác động lên các dữ liệu 
           nội tại của một đối tượng theo cách nào là hoàn toàn tùy thuộc vào người viết mã.
           + Đây là tính chất đảm bảo sự toàn vẹn, bảo mật của đối tượng trong Java.
           + Tính đóng gói được thể hiện thông qua phạm vi truy cập (access modifier).
           Ngoài ra, các lớp liên quan đến nhau có thể được gom chung lại thành package.
               + Có 2 loại modifier trong java: access modifiers và non-access modifiers.
                   * java access modifiers có 4 kiểu:
                       - public: công khai hoàn toàn
                       - private: chỉ được phép sử dụng nội bộ trong class
                       - protected: tương tự như private nhưng cho phép truy cập 
                                từ lớp dẫn xuất lớp chứa nó
                       - internal: chỉ được truy cập trong cùng 1 Assembly 
                                (nói cách khác là cùng project)
                                Thường được dùng cho class
                       - protected internal: kết hợp 2 cái trên
                      
                   * non-access modifiers: static, abstract, symchronized, volatile,...
       - TC2: ĐA HÌNH (Polymorphism)
           Thể hiện rõ nhất khi gọi đến 1 phương thức của đối tượng giống nhau nhưng kết quả của phương
           thức đó có thể khác nhau.
           + NẠP CHỒNG (Overloading): Nạp chồng phương thức cùng tên cùng kiểu phương thức nhưng
           khác tham số truyền vào. Khi đưa đúng số lượng tham số truyền vào sẽ gọi đúng phương thức
           cần được thực hiện.
           + GHI ĐÈ (Overriding): Ghi đè phương thức có cùng tên cùng tham số giữa lớp cha và lớp con.
           Các phương thức của lớp con kế thừa từ lớp cha từ kiểu phương thức, tên, tham số truyền vào
           nhưng tại các lớp con có thể viết lại code hành động khác theo nghiệp vụ của nó với phương 
           thức được kế thừa.
       - TC3: THỪA KẾ (Inheritance)
           Cho phép định nghĩa một lớp đối tượng dựa trên các thuộc tính có sẵn của một lớp đã có.
       - TC4: TRỪU TƯỢNG (Abstration)
               Trừu tượng có nghĩa là tổng quát hóa 1 cái gì đó lên, không cần chú ý chi tiết bên trong,
               + Tính trừu tượng là 1 tiến trình ẩn các chi tiết trình triển khai và chỉ hiển thị
               tính năng tới người dùng.
               + Tính trừu tượng cho phép loại bỏ tính chất phức tạp của đối tượng bằng cách chỉ đưa ra các 
               thuộc tính và phương thức cần thiết của đối tượng trong lập trình.
               + Tính trừu tượng giúp tập trung vào những cốt lõi cần thiết của đối tượng thay vì quan tâm 
               đến cách nó thực hiện.
               + Trong C#, sử dụng abstract class và abstract interface để có tính trừu tượng.
   3. Khái niệm
       - LỚP (CLASS): có thể xem lớp Class như 1 khuôn mẫu (template) của đối tượng (Object)
               + Trong đó bao gồm thuộc tính dữ liệu của đối tượng (FIELDS hay PROPERTIES) 
               và các phương thức (METHODS)tác động lên thành phần dữ liệu, 
               đó gọi là các phương thức của lớp. 
               + Class là từ khóa để khai báo lớp
       - ĐỐI TƯỢNG (OBJECT): Object được xem là một thực thể trong thế giới thực
       - Object bao gồm: thuộc tính (Attribute) & phương thức (Method)
           + Attribute: các thuộc tính của đối tượng
           + Method: Phương thức hay còn gọi là hàm thành viên
                     1 phương thức là 1 nhóm lệnh cùng nhau thực hiện 1 tác vụ
       - Từ khóa this trong c# là 1 biến tham chiếu được sử dụng để tham chiếu tới đối tượng 
       của lớp hiện tại.
   */
        static void Main(string[] args)
        {
            //1. Khai báo đối tượng
            SinhVien sv;
            //2. Khởi tạo đối tượng
            sv = new SinhVien();
            //2.1 ctor ko tham số
            SinhVien svPoly = new SinhVien();
            //2.2 ctor có tham số
            SinhVien svFPT = new SinhVien("PH12345", "Hang", 2004, 8, 1);

            //3. Gán giá trị => properties - set
            svPoly.Msv = "PH67890";
            svPoly.Ten = "Dung";
            svPoly.NamSinh = 2003;
            svPoly.Diem = 10;
            svPoly.GioiTinh = 0;

            Console.WriteLine("Xin chao "+ svPoly.Ten);
            //4. In thông tin
            svPoly.InThongTin();
            svFPT.InThongTin();
            sv.InThongTin();

            SinhVien svNEU = new SinhVien();
            //nhập thông tin từ bàn phím cho svNEU
            ///....................
            svNEU.InThongTin();
        }
    }
}
/* BTVN
 * 
 * 1. Tạo class MayTinh gồm các thuộc tính
 * - ma: string
 * - hang: string
 * - namSX: int
 * - inch: double
 * - trangThai: int (1- mới, 2- cũ)
 * 2. Tạo class ConMeo gồm các thuộc tính
 * - id: int
 * - ten: string
 * - tuoi: int
 * - loai: string
 * - canNang: double
 * - gioiTinh: bool (true- đực, false- cái)
 * 
 * Đối với mỗi class, thực hiện các yêu cầu sau
 * => private tất cả thuộc tính, 
 * tạo constructor ko tham số và có tham số,
 * có đầy đủ properties, tạo phương thức InThongTin()
 * => sang Main(): 
 * - tạo 2 đối tượng bằng ctor có tham số 
 * - tạo 1 đối tượng bằng ctor không tham số 
 * và nhập thông tin từ bàn phím cho đối tượng đó
 * - in toàn bộ thông tin ra màn hình bằng phương thức InThongTin()
 *
*/
