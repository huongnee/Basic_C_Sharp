using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.Exception
{
   
    public class BaiTap1
    {
        public static void kiemtra(int a, int b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Không thể chia cho 0");
            }
            Console.WriteLine("Kết quả phép chia là " + (a / b));
        }
        public static void Main(string[] args) {

            try
            {
                Console.WriteLine("Nhập 1 số bất kỳ ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập 1 số bất kỳ ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                kiemtra(number1, number2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi" + ex.Message);
            }
            catch(FormatException e) {
                Console.WriteLine("Lỗi" + e.Message);
            }
        }
    }
}
/*
 🧠 Bài 1: Chia hai số
Yêu cầu: Nhập 2 số nguyên từ người dùng. In kết quả phép chia.
✅ Xử lý ngoại lệ chia cho 0 và lỗi định dạng nếu nhập sai.

Gợi ý:
Dùng DivideByZeroException

Dùng FormatException
 */