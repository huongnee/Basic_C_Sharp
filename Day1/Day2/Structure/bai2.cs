using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Structure
{
    struct SinhVien
    {
        private string hoTen;

        public string ten
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private int age;

        public int tuoi
        {
            get { return age; }
            set { age = value; }
        }

        private double mark;

        public double diem
        {
            get { return mark; }
            set { mark = value; }
        }

        public SinhVien(string ten, int tuoi, double diemTB)
        {
            this.hoTen = ten;
            this.age = tuoi;
            this.mark = diemTB;
        }
        public void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm trung bình: ");
            mark = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            if(mark < 5)
            {
                return; // Không in ra nếu điểm TB < 5
            }
            else
            {
          
                Console.WriteLine($"Sinh viên: {hoTen}, Tuổi: {age}, Điểm TB: {mark}");
            }
        }


    }

    public class bai2
    {
        public static void Main()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] sinhVienList = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin cho sinh viên {i + 1}:");
                sinhVienList[i] = new SinhVien();
                sinhVienList[i].NhapThongTin();
            }
            for (int i = 0; i < n; i++)
            {
                sinhVienList[i].HienThi();
            }
        }
    }
}
/*
 🔰 Bài 2: Struct Sinh viên
    Yêu cầu:

    Tạo struct SinhVien với các thuộc tính:

    string hoTen

    int tuoi

    double diemTB

    Nhập thông tin cho n sinh viên.

    In ra danh sách sinh viên có điểm TB >= 5.
 */ 