using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.Exception
{
    public class BaiTap2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
/*
 🧠 Bài 3: Truy cập mảng
Yêu cầu: Khởi tạo một mảng 5 phần tử. Nhập chỉ số từ bàn phím, in ra phần tử tương ứng.
✅ Xử lý lỗi vượt chỉ số mảng.

Gợi ý:
Dùng IndexOutOfRangeException
 */