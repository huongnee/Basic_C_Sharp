using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 🧪 Bài 1: Tạo Attribute đơn giản cho class
Yêu cầu:
Tạo một Attribute tên là InfoAttribute chứa thông tin tác giả và ngày tạo.
Gắn attribute này cho một class Book.
Sử dụng Reflection để in ra thông tin đó.
✅ Mục tiêu học được:
Cách định nghĩa và gắn Attribute.
Cách dùng Type.GetCustomAttributes() để lấy thông tin.
 */
namespace Day1.Advance.BaiTap
{
    //Bước 1 tạo 1 Attribute mới
    //[AttributeUsage(AttributeTargets.Class)] nghĩa là Attribute này chỉ được gắn cho class
    //(không dùng cho method, property...).
    [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute : Attribute // phải kế thừa từ System.Attribute
    {
        public string author { get; set; }
        public string date { get; set; }

        public InfoAttribute(string author, string date)
        {
            this.author = author;
            this.date = date;
        }
    }

    //Bước 2: Gắn Attribute vào class Book
    [Info("kaka","20-12-2003")]// gán
    public class Book
    {
        public string title { get; set; }
        public Book(string title)
        {
            this.title = "hehe";
        }
        public void ShowInfo() => Console.WriteLine($"Sách: {title}");
    }
    public class b1
    {
        //Bước 3: Dùng Reflection để đọc thông tin Attribute
        public static void Main(string[] args) 
        {
            // Lấy kiểu dữ liệu của class Book
            Type ty = typeof(Book);// lúc này ty nó chứa hết thông tin của book r từ method, filed, enum hay các
            // các attribute
            // Lấy tất cả Attribute gắn trên class (trả về mảng object)
            object[] attributes = ty.GetCustomAttributes(false);
            // lấy tất cả att không phân biệt loại
            // Object[] att = ty.GetCustomAttributes(typeof(InfoAttribute), false); lấy att có phân biệt loại, đây là lấy loại info thôi
            /// Duyệt từng attribute để kiểm tra có phải là InfoAttribute không
            foreach (object o in attributes) 
            { 
                if(o is InfoAttribute info)
                {
                    Console.WriteLine("Tên tác giả "+ info.author + "Ngày : " + info.date);
                }    
            }
            // Gọi thử class Book
            Book book = new Book("kaka");
            book.ShowInfo();
        }
    }
}
