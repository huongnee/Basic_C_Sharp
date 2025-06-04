using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class DaoNguocChuoi
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray(); // hàm có sẵn 
            //Phương thức chuyển chuỗi đó thành một mảng các ký tự(char[]).
            //Ví dụ, nếu input = "hello", thì chars sẽ là mảng['h', 'e', 'l', 'l', 'o'].
            Array.Reverse(chars);// hàm đảo ngược 
            Console.WriteLine("Chuỗi đảo ngược: " + new string(chars));
        }
    }
}
