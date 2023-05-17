using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8_MANG
{
    internal class Program
    {
       
/*
        * Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm định
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */

 /*
        * Thao tác với mảng
        *  ***Phương thức của Array
        *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
        *      + GetValue(index): lấy giá trị ở vị trí
        *      + IndexOf(<Array>,<value>): Tìm kiếm vị trí của phần tử
        *      + GetLength(0): Trả ra số lượng phần tử trong mảng
        *      + Reverse(<mảng>): Đảo ngược mảng
        *      + Sort(Array): Sắp xếp mảng
        
        */
        static void Main(string[] args)
        {
            //1. khai báo mảng
            int[] arrSo;
            //2. khởi tạo mảng
            //khởi tạo ngầm định => có sẵn 4 phần tử
            arrSo = new[]{ 4, 2, 5, 3};
            //khởi tạo tường minh => có sẵn 3 phần tử
            double[] arrDiem = new double[] {8.2,7.5,9};
            //khởi tạo 1 mảng string có kích thước = 5
            string[] arrTen = new string[5];
            //độ dài của mảng
            Console.WriteLine("length= "+arrTen.Length);

            //3. Gán giá trị
            //index từ 0- (n-1)
            arrTen[0] = "Mai";
            arrTen[1] = "Dao";
            arrTen[2] = "Quyt";
            arrTen[3] = "Man";
            arrTen[4] = "Hong";
            //arrTen[5] = "Hong"; => lỗi vì ngoài kích thước mảng
            //4. truy xuất phần tử
            Console.WriteLine($"arrDiem[1]= {arrDiem[1]}");
            //5. Duyệt mảng
            //cách 1: for i
            //for tab
            for (int i = 0; i < arrTen.Length; i++)
            {
                Console.WriteLine($"arrTen[{i}] = {arrTen[i]}");
            }
            //cách 2: foreach
            /*
            Cách gõ: fore + tab

            Công thức:  
            for (var arg in args) {

                }
            String arg: Kiểu dữ liệu và tên biến, tên biến sẽ đại diện là 1 giá trị
            args: Là Collection hoặc là 1 Array
             */
            foreach (var item in arrTen)
            {
                Console.WriteLine(item);
            }
            foreach (var diem in arrDiem)
            {
                Console.WriteLine(diem);
            }
            //6. thao tác với mảng
            Console.WriteLine("Sort: sap xep mang tang dan");
            Array.Sort(arrDiem);
            foreach (var item in arrDiem)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reverse: dao nguoc mang");
            Array.Reverse(arrDiem);
            foreach (var item in arrDiem)
            {
                Console.WriteLine(item);
            }
            //int arrSo = new[]{ 4, 2, 1, 3};
            //BinarySearch phải sort trước khi tìm kiếm
            Array.Reverse(arrSo);
            Array.Sort(arrSo);
            //index= 0 1 2 3
            //value= 1 2 3 4
            //{ 4, 2, 5, 3};
            //index= 0 1 2 3
            //value= 2 3 4 5
            //trả về index của value 2 trong mảng arrSo
            int index= Array.BinarySearch(arrSo, 2);
            Console.WriteLine("index= "+index);
        }
    }
}
