using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Example2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập họ tên của bạn: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());

            // Lấy năm hiện tại
            int namHienTai = DateTime.Now.Year;

            // Tính tuổi
            int tuoi = namHienTai - namSinh;

            // In kết quả
            Console.WriteLine($"Xin chào {hoTen}, bạn {tuoi} tuổi.");
        }
    }
}
