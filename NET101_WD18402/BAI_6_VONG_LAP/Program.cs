using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6_VONG_LAP
{
    internal class Program
    {  /*
       * Bài Vòng lặp:
       *
       * Định nghĩa chung cho tất cả vòng lặp:
       * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
       *
       * Các loại vòng lặp: while, do..while, for, foreach
       *
       * Từ khóa sử dụng trong vòng lặp:
       *
       * break - ngắt vòng lặp
       * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
       *
       * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
       * + Cách dùng: wh + tab
       *
       * + Công thức:
       *  while (true)
          {
              //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
          }
          Vòng lặp Do..While: Thực hiện hành động ít nhất là 1 lần. Điều kiện đề vòng lặp chạy giống như While(True).
         Cách gõ: do + tab

       Công thức:
         do {
                    //Thực hiện hành động ít nhất là 1 lần.
         } while (true);
      */

        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.Unicode;
            Console.InputEncoding= Encoding.Unicode;
            //PHẦN 1: VÒNG FOR
            //for tab tab
            //for (khởi tạo; điều kiện; bước nhảy)
            for (int i = 0; i < 10; i++)
            {
                if( i == 4)
                {
                    Console.WriteLine("Cô Huyền xinh gái");
                    //break; 
                    //return; //=> thoát luôn
                    continue; //bỏ qua vòng hiện tại
                              ////=> nhảy đến vòng tiếp theo luôn
                }
                Console.WriteLine($"i= {i}");
            }
            Console.WriteLine("Cô Huyền xinh gái 2");

            //PHẦN 2: WHILE

            int n = 0;
            while(n < 20)
            {
                Console.WriteLine($"{n+1}. Xin nhỗi em, Ngàn lần xin nhỗi em");
                n++;
            }
            //PHẦN 3: DO- WHILE
            int tuoi = 30;
            do
            {
                Console.WriteLine("Nhập tuổi: ");
                tuoi = Convert.ToInt32(Console.ReadLine());
                if(tuoi >= 18 && tuoi <= 50)
                {
                    Console.WriteLine("Đã đến tuổi lấy vợ");
                    break;
                    //return;
                }
                Console.WriteLine("Mời bạn nhập tuổi 18-50!!");
            } while (tuoi < 18 || tuoi > 50);
            //nếu tuổi ngoài khoảng từ 18-50 => phải nhập lại


        }
    }
}
