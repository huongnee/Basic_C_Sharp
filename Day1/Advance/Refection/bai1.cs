using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;    // Thư viện hỗ trợ Reflection

namespace Day1.Advance.Refection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
    }
    public class bai1
    {
        public static void Main(string[] args)
        {
            //Lấy thông tin về student
            Type type = typeof(Student);
            // in ra tên class
            Console.WriteLine(type.Name);
            //In ra danh sách property
            foreach(PropertyInfo info in type.GetProperties())
            {
                Console.WriteLine(info.Name);
                Console.WriteLine(info.PropertyType);
            }


        }
    }
}
/*
 Bài tập 1: In thông tin class
    Yêu cầu: Tạo một class Student có các property như Id, Name, ClassName. Viết chương trình dùng Reflection để:

    In ra tên class.

    In ra danh sách property và kiểu dữ liệu của chúng.
 */