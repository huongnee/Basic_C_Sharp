using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day1.OOP.RegularExpression
{
    public class bai1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vui lòng nhập vào số điện thoại của bạn");
            string phone = Console.ReadLine();
            string pattern = @"^(03|09)\d{8}$";
            bool isValid = Regex.IsMatch(phone, pattern);
            Console.WriteLine(isValid); // Kết quả: True

        }
    }
}
/*
 🔰 Bài tập 1: Kiểm tra định dạng số điện thoại Việt Nam
    Yêu cầu: Viết Regex kiểm tra xem số điện thoại có đúng định dạng: bắt đầu bằng 0, theo sau là 9 chữ số.

    📌 Dạng đúng: 0987654321, 0912345678
 */