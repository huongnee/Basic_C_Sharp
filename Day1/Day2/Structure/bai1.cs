using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Structure
{
    struct Diem
    {
        private int x;

        public int  diemX
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int diemY
        {
            get { return y; }
            set { y = value; }
        }

        //Constructor
        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double KhoangCachDenGocToaDo()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
    public class bai1
    {
        public static void Main()
        {
            Diem point  = new Diem();
            //Diem point;
            Console.Write("Nhập tọa độ x: ");
            point.diemX = int.Parse(Console.ReadLine());
            Console.Write("Nhập tọa độ y: ");
            point.diemY = int.Parse(Console.ReadLine());
            double distance = point.KhoangCachDenGocToaDo();
            Console.WriteLine($"Khoảng cách đến gốc tọa độ là: {distance}");
        }
    }
}
/*
    🔰 Bài 1: Struct Tọa độ điểm
        Yêu cầu:
        Tạo struct Diem với 2 thuộc tính int x, int y.
        Viết hàm tính khoảng cách từ điểm đến gốc tọa độ (0, 0).
        Nhập thông tin điểm từ bàn phím, sau đó in ra khoảng cách.
 */