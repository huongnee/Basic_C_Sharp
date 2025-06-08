using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.BaiTapOOP.Polymorphism.overload
{
    public class Shape
    {
        public virtual double GetArea()
        {
            double area = 0;
            return area;
        }
    }
    public class Rectangle : Shape 
    {
        public double cd { get; set; }
        public double cr { get; set; }

        public Rectangle(double cd, double cr)
        {
            this.cd = cd;
            this.cr = cr;
        }

        public override double GetArea()
        {
            base.GetArea();
            double area;
            Console.WriteLine("Nhập chiều dài ");
            cd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng ");
            cr = Convert.ToDouble(Console.ReadLine());
            area = cd * cr;
            return area;
        }
    }
    public class Circle : Shape
    {
        public double canh { get; set; }

        public Circle(double canh)
        {
            this.canh = canh;
        }

        public override double GetArea()
        {
            base.GetArea();
            double area;
            Console.WriteLine("Nhập cạnh ");
             canh = Convert.ToDouble(Console.ReadLine());
            area = canh* canh;
            return area;
        }
    }
    public class HinhHoc
    {
        public static void Main(string[] args)
        {
            Shape shape1 = new Rectangle(5, 10);  // Diện tích = 50
            Shape shape2 = new Circle(3);         // Diện tích ≈ 28.27

            Console.WriteLine($"Diện tích HCN là {shape1.GetArea()}");
            Console.WriteLine($"Diện tích HV là {shape2.GetArea()}");

              // Output: 50
              // Output: 28.27
        }
    }
}
/*
  🔹 Bài 1: Hình học cơ bản
            Yêu cầu:

            Tạo lớp Shape có phương thức ảo GetArea().

            Tạo lớp Rectangle và Circle kế thừa Shape, override phương thức GetArea() để tính diện tích.

            Input/Output mẫu:
            Shape shape1 = new Rectangle(5, 10);  // Diện tích = 50
            Shape shape2 = new Circle(3);         // Diện tích ≈ 28.27

            shape1.GetArea();  // Output: 50
            shape2.GetArea();  // Output: 28.27

 */