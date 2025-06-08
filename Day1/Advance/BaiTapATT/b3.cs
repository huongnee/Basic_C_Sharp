using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Advance.BaiTapATT
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string name { get; set; }
        public string version { get; set; }

        public AuthorAttribute(string name, string version)
        {
            this.name = name;
            this.version = version;
        }
    }
    [Author("haha","v2.5")]
    public class Calculator 
    {
        public void cal()
        {
            Console.WriteLine("Tính toán");        
        }
    }


    public class b3
    {
        public static void Main(string[] args) 
        {
            Type type = typeof(Calculator);

            // lấy ra tất cả các att của calculator gán nó vào att

            object[] att = type.GetCustomAttributes(typeof(AuthorAttribute), false);

            foreach (AuthorAttribute o in att) { 
                
                Console.WriteLine(o.name + " " + o.version);
                
            }
        }
    }
}
/*
 ✅ Bài tập 1: Tạo Attribute đơn giản và sử dụng
Yêu cầu:

Tạo một attribute có tên AuthorAttribute có 2 thuộc tính: Name và Version.

Áp dụng attribute đó vào một lớp Calculator.

In ra thông tin attribute của lớp Calculator.
 */