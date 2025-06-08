using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; // Dùng để truy xuất thông tin attribute (Reflection)

/*
 ✅ Yêu cầu:
    Tạo attribute tên là InfoAttribute

    Có 2 thuộc tính: Author và Date

    Gắn attribute đó vào 1 class

    Dùng Reflection để in ra thông tin từ attribute
 */
namespace Day1.Advance.attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] // Gắn được vào class hoặc method
    public class InfoAttribute : Attribute
    {
        public string Author { get; } // Tên tác giả
        public string Date { get; }   // Ngày tạo

        // Constructor nhận giá trị cho các thuộc tính
        public InfoAttribute(string author, string date)
        {
            Author = author;
            Date = date;
        }
    }

    // 🧱 Bước 2: Gắn attribute vào class
    [Info("Huong", "2025-06-05")] // Gắn attribute với thông tin tác giả và ngày
    public class StudentManager
    {
        public void Display()
        {
            Console.WriteLine("Quản lý sinh viên."); // In ra nội dung đơn giản
        }
    }

    // 🧱 Bước 3: Đọc thông tin attribute bằng Reflection
    class Program
    {
        static void Main()
        {
            // Lấy thông tin kiểu của class StudentManager
            //Chỗ dùng Reflection
            Type type = typeof(StudentManager);

            //Chỗ dùng Reflection
            // Lấy tất cả các attribute gắn trên class (không lấy từ class cha)
            object[] attributes = type.GetCustomAttributes(false);

            // Duyệt từng attribute
            foreach (object attr in attributes)
            {
                // Kiểm tra nếu attribute là InfoAttribute
                if (attr is InfoAttribute info)
                {
                    Console.WriteLine($"Tác giả: {info.Author}"); // In ra tên tác giả
                    Console.WriteLine($"Ngày tạo: {info.Date}");   // In ra ngày tạo
                }
            }

            // Khởi tạo đối tượng và gọi phương thức
            StudentManager manager = new StudentManager();
            manager.Display(); // Gọi method để hiển thị nội dung
        }
    }
}
