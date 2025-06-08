using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.Exception
{
    public class vidu2
    {
        public static void check(int age)
        {
            if (age < 0) {
                throw new ArgumentException("Tuổi không được nhỏ hơn 0");
            }
        }
        public static void Main(string[] args)
        {
            int n = 5;
            if (n < 0)
            {
                throw new ArgumentException("n không được nhỏ hơn 5");
            }
            Console.WriteLine("Vui lòng nhập vào tuổi");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                check(age);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Lỗi"+ex.Message);
            }


        }
    }
}
