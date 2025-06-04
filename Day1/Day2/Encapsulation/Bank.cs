using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Encapsulation
{
    public class Bank
    {
        private int _balance = 5000; // Dữ liệu được bảo vệ

        private void Credit(int amount) // Phương thức private
        {
            _balance += amount;
        }

        public void Login(int pin)
        {
            if (pin == 1234)
            {
                Credit(1000); // Gọi phương thức nội bộ
                Console.WriteLine($"Số dư: {_balance}");
            }
        }
        public static void Main(string[] args)
        {
            Bank account = new Bank();
            account.Login(1234); // Output: Số dư: 6000
        }
    }
}
