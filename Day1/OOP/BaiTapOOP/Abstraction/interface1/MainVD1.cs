using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.BaiTapOOP.Abstraction.abs
{
    interface IPayment
    {
         void Pay(double amount);
    }
    public class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Thanh toan {amount} voi the tin dung");
        }
    }
    public class PaypalPayment : IPayment 
    {
        public void Pay(double amount) 
        { 
            Console.WriteLine($"Thanh toan {amount} voi paypal");
        }
    }

    public class MainABS
    {
        public static void Main(string[] args) 
        {
            IPayment p1 = new CreditCardPayment();
            p1.Pay(100); // Output: "Paid 100 using Credit Card"

            IPayment p2 = new PaypalPayment();
            p2.Pay(200); // Output: "Paid 200 using PayPal"

        }
    }
}
/*
 🔹 Bài 4: Hệ thống thanh toán
    - Yêu cầu:

    Tạo interface IPayment với phương thức Pay(double amount).

    Tạo 2 lớp CreditCardPayment, PaypalPayment thực hiện IPayment.

    - Input/Output mẫu:
    IPayment p1 = new CreditCardPayment();
    p1.Pay(100); // Output: "Paid 100 using Credit Card"

    IPayment p2 = new PaypalPayment();
    p2.Pay(200); // Output: "Paid 200 using PayPal"

 */