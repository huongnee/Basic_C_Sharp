using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance; // Trường private

        // Property để truy cập _balance
        public decimal Balance
        {
            get { return _balance; }
            private set // Chỉ thiết lập giá trị trong class
            {
                if (value >= 0)
                    _balance = value;
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount; // Gọi setter của Balance
        }
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account._balance = 100;
            Console.WriteLine(account._balance);
        }
    }
}
