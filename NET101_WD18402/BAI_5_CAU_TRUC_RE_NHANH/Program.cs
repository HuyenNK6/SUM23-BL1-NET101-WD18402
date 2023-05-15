using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BAI_5_CAU_TRUC_RE_NHANH
{
    internal class Program
    {
        /*
	* 1. CẤU TRÚC IF
	*	if (điều kiện){
	*		//thực hiện công việc
	*	}
	* 2. CẤU TRÚC IF-ELSE
	*	if (điều kiện){
	*		//thực hiện công việc 1
	*	}else{
	*		//thực hiện công việc 2
	*	}
	* 3. CẤU TRÚC IF-ELSE IF
	*	if (điều kiện 1){
	*		//thực hiện công việc 1
	*	}else if(điều kiện 2){
	*		//thực hiện công việc 2
	*	}else if(điều kiện 3){
	*		//thực hiện công việc 3
	*	}else{
	* 		//thực hiện công việc n
	*	}
	*/
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tien cac ban co: ");
            int money = Convert.ToInt32(Console.ReadLine());

            //>=15 tỷ: roll royce
            //10-15 tỷ: G63
            //5-10 tỷ: mec glc
            //còn lại: kia morning
            if (money >= 15)
            {
                Console.WriteLine("Mua roll royce");
            }
            else if (money >= 10)
            {
                Console.WriteLine("Mua G63");
            }
            else if (money >= 5)
            {
                Console.WriteLine("Mua mec glc");
            }
            else
            {
                Console.WriteLine("Mua kia morning");

            }

            //////
            Console.WriteLine("Nhập giới tính (1- đực/ 2- cái): ");
            int gioiTinh = Convert.ToInt32(Console.ReadLine());
            ////
            Console.WriteLine($"Giới tính: {(gioiTinh == 1 ? "Đực": "Cái")}");
        }
    }
}
/* 
 * Nhập xuất thông tin của Con Chó
 * - id : int
 * - tên: string
 * - cân nặng: double
 * - loài: string
 * - giới tính: int (1- đực/2- cái)
 * Đánh giá cân nặng:
 * nếu cân nặng >= 20 => béo phì
 * nếu cân nặng 10-20 => chó đẹp dáng xinh
 * nếu cân nặng 5-10 => cần tăng cân
 * còn lại => suy dinh dưỡng
*/
