using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11_ArrayList_List
{
    internal class Program
    {
        /*
       *  ArrayList
       *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                      danh sách các đối tượng theo kiểu mảng (truy
                      cập các phần tử bên trong thông qua chỉ số
                      index)
          Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                      linh hoạt và có thể tự điều chỉnh kích cỡ một
                      cách tự động.
          Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                      thêm thư viện System.Collections
          Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
       */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          ....................................
         */

        /*
         *  LIST trong C# Generic Collections nó dùng lưu trữ giống như ArrayList vê khái niệm.
         *
         *  1.Khai báo:
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>();
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>(size);//Khai báo kích thước định sẵn
         */

        /*
         * A. CÁC PHƯƠNG THỨC TRONG List
         * 1. Add(object Value): Thêm đối tượng vào cuối.
         * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
         * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
         * 4. Clear(): Xóa tất cả các phần tử.
         * 5. Clone(): Tạo 1 bản sao của danh sách đó.
         * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
         * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
         * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
         *9.CopyTo(<tên mảng>,<index>): Thực hiện sao chép các phần tử List về mảng 1 chiều từ index của mảng
         * 10. Remove(<value>): Xóa value ở trong List
         *
         * Ngoài ra còn có thêm 1 số phương thức khác
         */
        static void Main(string[] args)
        {
            //PHẦN 1: ARRAYLIST
            //1. khởi tạo
            ArrayList arrLstPoly = new ArrayList();
            //2. thêm phần tử vào arrLst
            arrLstPoly.Add(2);
            arrLstPoly.Add(10);
            arrLstPoly.Add(6);
            arrLstPoly.Add(4);

            arrLstPoly.Add("Ha noi");
            arrLstPoly.Add(true);

            //3. truy xuất phần tử
            Console.WriteLine("arrLstPoly[0]=" + arrLstPoly[0]);

            //4. duyệt arrLst
            //cách 1: for i -> for tab
            for (int i = 0; i < arrLstPoly.Count; i++)
            {
                Console.WriteLine($"arrLstPoly[{i}]= {arrLstPoly[i]}");
            }
            //cách 2: foreach -> fore tab
            foreach (var item in arrLstPoly)
            {
                Console.WriteLine(item);
            }

            //PHẦN 2: LIST
            Console.WriteLine("----LIST------");
            //1. khởi tạo
            List<int> lstTuoi = new List<int>();
            //2. thêm phần tử
            lstTuoi.Add(10);
            lstTuoi.Add(20);
            lstTuoi.Add(15);
            lstTuoi.Add(9);
            //lstTuoi.Add("HuyenNK6");
            //3. truy xuât phần tử
            Console.WriteLine(lstTuoi[1]);
            //4. duyệt list
            //cách 1: for tab
            for (int i = 0; i < lstTuoi.Count; i++)
            {
                Console.WriteLine(lstTuoi[i]);
            }
            //cách 2: fore tab
            lstTuoi.Sort();// sắp xếp
            foreach (var item in lstTuoi)
            {
                Console.WriteLine(item);
            }
            



        }
    }
}
/*BTVN
 * P1. Tạo class DieuHoa gồm các thuộc tính
 * - id: int
 * - hang: string
 * - congSuat: int
 * - gia: double
 * - xuatXu: string
 * => private tất cả thuộc tính, 
 * tạo constructor ko tham số và có tham số,
 * có đầy đủ properties, tạo phương thức InThongTin()
 * 
 * tạo phương thức KiemTra(): bool 
 * => kiểm tra nếu gia > 20,000,000 và công suất >=3000 trả về đúng, và ngược lại
 * 
 * bổ sung vào thêm phương thức InThongTin():
 * in ra "Hàng Chất Lượng Cao"
 * nếu KiemTra() trả về kết quả đúng

 * P2.
 * - tạo 4 đối tượng bằng ctor có tham số
 * - tạo 1 đối tượng bằng ctor không tham số -> nhập thông tin từ bàn phím
 * - tạo List<DieuHoa> chứa tất cả 5 đối tượng trên
 * - sau đó in thông tin ra màn hình 
 */