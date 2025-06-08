using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.BaiTapOOP.Inheritance
{
    public class Account
    {
        private string chuTK;

        public string ctk
        {
            get { return chuTK; }
            set { chuTK = value; }
        }

        private double Balance;

        public double sodu
        {
            get { return Balance; }
            set { Balance = value; }
        }
        //gửi tiền
        public void Deposit(double soTien)
        {
            if (soTien > 0) 
            { 
                sodu = sodu + soTien;
                Console.WriteLine($"Đã gửi {soTien} vào tài khoản.");
            }
            else
            {
                Console.WriteLine("Số tiền gửi vào phải lớn hơn 0");
            }
        }

        //rút tiền
        public void Withdraw(double soTien)
        {
            if (soTien > 0)
            {
                sodu = sodu - soTien;
                Console.WriteLine($"Đã rút {soTien},Hiện tại tài khoản còn lại {sodu}");
            }
            else
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0");
            }
        }
        //Hiển thị thông tin tài khoản
        public void infoAccount()
        {
            Console.WriteLine($"Chủ tài khoản {chuTK} - Số dư {sodu}");
        }


    }
    //Tài khoản tiết kiệm
    public class SavingAccount : Account 
    {
        //lãi suất
        private double InterestRate;

        public double laisuat
        {
            get { return InterestRate; }
            set { InterestRate = value; }
        }
        //Tính tiền lãi
        public Double CalculateInterest()
        {
            
            return sodu * laisuat / 100;
        }


    }
    public class MainVD2
    {
        public static void Main(string[] args)
        {
            Account account = new Account();
            account.ctk = "hehe";
            account.sodu = 100000;
            Console.WriteLine($"Hiển thị thông tin khách hàng {account.ctk} Số dư {account.sodu}");

            Console.WriteLine("Nhập số tiền muốn gửi");
            double money = Convert.ToDouble(Console.ReadLine());
            account.Deposit(money);
            Console.WriteLine("Nhập số tiền muốn rút");
            double money1 = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(money1);
            Console.WriteLine($"Hiển thị lại thông tin khách hàng {account.ctk} Số dư {account.sodu}");

            SavingAccount account2 = new SavingAccount();
            // gán số dư (sodu) cho đối tượng SavingAccount account2
            account2.sodu = account.sodu; // Hoặc gán cho số dư bạn muốn
            Console.WriteLine("Nhập vào lãi suất");
            account2.laisuat = Convert.ToDouble(Console.ReadLine());
            //Tính tiền lãi
            Console.WriteLine($"Tính tiền lãi {account2.CalculateInterest()}");


        }
    }
}
