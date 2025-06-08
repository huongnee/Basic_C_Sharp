using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Advance.BaiTapATT
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute : Attribute
    {
        public string Description { get; set; }

        public string Category { get; set; }

        public InfoAttribute(string description, string category)
        {
            Description = description;
            Category = category;
        }
    }
    [Info("Vip", "IP17")]
    public class Printer
    {
        public void Print()
        {
            Console.WriteLine("Printting");
        }
        
    }
    public class b4
    {
        public static void Main(string[] args) 
        {
            //Có dữ ll
            Type type = typeof(Printer);

            //Tạo 1 biến để lưu dl về các att trong class đó

            object[] objects = type.GetCustomAttributes(typeof(InfoAttribute), true);

            // obj lưu r giờ hiển thị ra
            foreach (InfoAttribute obj in objects) 
            {
                Console.WriteLine($"{obj.Description} - {obj.Category}");
            }
        }
    }
}
/*
 ✅ Ví dụ mở rộng: Dùng InfoAttribute để mô tả thông tin một class
Yêu cầu:

Tạo một attribute tên InfoAttribute có 2 thuộc tính: Description và Category.

Áp dụng attribute vào lớp Printer.

In ra thông tin attribute của lớp Printer.


 */