using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*
 🧪 Bài 2: Attribute cho method
Yêu cầu:

Tạo attribute LogAttribute để đánh dấu các method cần log khi gọi.

Gắn attribute này cho một số method trong class Calculator.

Dùng Reflection để in ra tên các method có [Log].

✅ Mục tiêu học được:

Gắn Attribute cho method.

Duyệt method bằng MethodInfo[] methods = type.GetMethods().
 */
namespace Day1.Advance.BaiTap
{
    //Bước 1 tạo 1 cái attribute mới
    [AttributeUsage(AttributeTargets.Method)]
    public class LogAttribute : Attribute
    {
        public int maloi { get; set; }
        public void loi()
        {
            Console.WriteLine("Lỗi nè!");
        }
    }

    //Bước 2 gắn att cho class/
// các hàm có log là add và sub
    public class Calculator
    {
        [Log]
        public void Add(int a, int b)
        {
            Console.WriteLine($"Tổng: {a + b}");
        }

        [Log]
        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Hiệu: {a - b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Tích: {a * b}");
        }
    }
    public class b2
    {
        //Bước 3: Dùng Reflection để đọc thông tin Attribute
        public static void Main(string[] args)
        {
            // Lấy dữ liệu (metadata) của class Calculator

            Type type = typeof(Calculator);

            // Lấy tất cả Attribute gắn trên class (Duyệt method bằng MethodInfo[])
            MethodInfo[] methodInfos = type.GetMethods();

            //
            foreach (MethodInfo method in methodInfos)
            {
                if (method.GetCustomAttribute(typeof(LogAttribute)) != null)
                {
                    Console.WriteLine($"- {method.Name}");
                }
            }

        }
    }
}
