using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Method
{
    internal class b1
    {
        public static int GiaiThua(int x)
        {
            //int kq_gt = 0;
            int tmp = 1;
            for (int i = 1; i <= x; i++) { 
                tmp = tmp * i ;
            }
            return tmp;
        }
        public static int BinhPhuong(int x)
        {
            int tmp = x*x;
           
            return tmp;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhập 1 số bất kỳ để tính giai thừa của nó");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GiaiThua(num));
            Console.WriteLine(BinhPhuong(num));




        }
    }
}

/*
 1: Viết phương thức tính giai thừa của một số nguyên dương n.

 2: Viết phương thức nhận vào một số, trả về bình phương của số đó.
 */