using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Example
    {
        public static void Input(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhập phần tử thứ "+i);
                arr[i] =  Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Output(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("giá trị thứ " + i + " = "+ arr[i]);

            }
        }
        static void Main(string[] args)
        {
            //Bài 7
            Console.WriteLine("Số lượng muốn cấp phát cho mảng ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] mang = new int[n];
            Input(mang);
            Output(mang);
            //Bài 1
            String name = "Hưởng", ho = "Ngô";
            int age = 21;
            float mark = 9.8f;
            Boolean status = true;

            Console.WriteLine("Name: " + name + " Age " + age + " Mark " + mark + "status " + status);

            //Bài 2
            String a1 = "25", a2 = "26.8";
            int num1 = Convert.ToInt32(a1);
            float num2 = Convert.ToSingle(a2);
            Console.WriteLine("Tổng 2 số là "+((float)num1 + num2));

            //Bài 3
            Console.WriteLine("Vui lòng nhập vào chiều dài : ");
            float cd = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập vào chiều rộng : ");
            float cr = Convert.ToSingle(Console.ReadLine());
            float dt = cd * cr;
            Console.WriteLine("Diện tich"+dt);

            //Bài 4
            const float PI = 3.14f; // Hằng số ko bị thay đổi
            //Bài 5
            Console.WriteLine("Nhập vào điểm");
            float diem = Convert.ToSingle(Console.ReadLine());
            if (diem >= 8)
            {
                Console.WriteLine("giỏi");
            }
            else if (diem < 5) {
                Console.WriteLine("giỏi");
            }
            else if(diem > 5 && diem < 8)
            {
                Console.WriteLine("Khá");
            }

            //Bài 6 Nhập một số n, in ra bảng cửu chương của n từ 1 đến 10.
            Console.WriteLine("Nhap bang cuu chuong muon hien : ");
            int sum;
            int cuuchuong = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++) {
                sum = cuuchuong * i;
                Console.WriteLine(cuuchuong + " *" + i +" = "+ sum );
            }

            
        }
    }
}
