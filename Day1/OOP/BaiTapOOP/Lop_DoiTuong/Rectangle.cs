using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.BaiTapOOP.Lop_DoiTuong
{
    public class HinhChuNhat
    {
        private double Length;

        public double chieudai
        {
            get { return Length; }
            set { Length = value; }
        }

        private double Width;

        public double chieurong
        {
            get { return Width; }
            set { Width = value; }
        }

        public double Area(double x, double y)
        {
            return x * y;
        }
        public double Perimeter(double x, double y)
        {
            return 2*(x + y);
        }

    }
    public class Rectangle
    {
        public static void Main(string[] args)
        {
            HinhChuNhat rectangle = new HinhChuNhat();
            Console.WriteLine("Nhập chiều dài của hình chữ nhật");
            double cd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng của hình chữ nhật");
            double cr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Chu vi của hình chữ nhật là : {rectangle.Perimeter(cd,cr)}");
            Console.WriteLine($"Diện tích của hình chữ nhật là : {rectangle.Area(cd, cr)}");



        }
    }
}
/*
 🧪 Bài 3: Quản lý hình chữ nhật
    Yêu cầu:
    Tạo lớp Rectangle với:

    Length, Width
    Tạo phương thức:

    Area() → trả về diện tích

    Perimeter() → trả về chu vi

    Thực hành: Tạo đối tượng hình chữ nhật và in ra diện tích, chu vi.
 */