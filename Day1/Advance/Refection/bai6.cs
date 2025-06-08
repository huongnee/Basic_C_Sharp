using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.ConstrainedExecution;    // Thư viện hỗ trợ Reflection

namespace Day1.Advance.Refection
{
    public class Book
    {
        public string title { get; set; }
        public int year { get; set; }

        public Book(string title, int year)
        {
            this.title = title;
            this.year = year;
        }
    }
    public class bai6
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Book);

           // object obj = Activator.CreateInstance(type);
            object obj = Activator.CreateInstance(type, "Some Title", 2024); // nếu class trên có construc thì đây phải khai hoặc trên tạo construc k tham số


            foreach (ConstructorInfo info in type.GetConstructors())
            {
                ParameterInfo[] parameters = info.GetParameters();
                Console.WriteLine($"Số lượng tham số: {parameters.Length}");
                Console.Write("Kiểu các tham số: ");
                foreach (ParameterInfo param in parameters)
                {
                    Console.Write($"{param.ParameterType.Name} ");
                }
                Console.WriteLine(); // Xuống dòng cho đẹp
            }
        }
    }
}
/*
 ✅ Bài tập 6: Lấy thông tin constructor
    Yêu cầu: Tạo class Book có constructor nhận string title, int year. Dùng Reflection để:
    Lấy constructor này.
    In ra số lượng tham số và kiểu của chúng.
 */