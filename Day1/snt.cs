using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class snt
    {
        public static Boolean check(int n)
        {
           for(int i = 2;i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
        
            }    

            return true;
        }

         static void Main(string[] args) {
            Console.WriteLine("Nhập 1 số bất kỳ ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Các số nguyên tố từ 2 đến n là");
            if (n == 2)
            {
                Console.WriteLine("Có 1 số nguyên tố duy nhất là 2");
            }
            else 
            {
                for (int i = 2; i <= n; i++)
                {
                    if (check(i))
                    {
                        Console.WriteLine($"{i} là số nguyên tố");
                    }
                    
                }
            }
        }
    }
}
