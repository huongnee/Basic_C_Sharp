using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;               // Thư viện cơ bản chứa các class như Console
using System.Reflection;    // Thư viện hỗ trợ Reflection

namespace Day1.Advance.Refection
{
    public class person 
    {
        public string name { get; set; }
        private string age { get; set; } // muốn lấy dùng GetProperties(BindingFlags.NonPublic | BindingFlags.Instance)
        private int ageNumbe;  //muốn lấy GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
        public void Greeting()
        {
            Console.WriteLine("Xin chào bạn !");
        }
    }

    public class vd1
    {
        public static void Main()
        {
            // Lấy kiểu (type) của class Person bằng typeof
            Type type = typeof(person);

            // In ra tên của class đó
            Console.WriteLine($"Tên của class đó là {type.Name}");

            // In ra tất cả các thuộc tính (property) của class - public có getset
            foreach(PropertyInfo info in type.GetProperties())
            {
                Console.WriteLine($"Tên của các thuộc tính lần lượt là : {info.Name}");
            }
            // In ra tất cả các thuộc tính (property) của class - private có getset
            foreach (PropertyInfo info in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"Tên của các thuộc tính lần lượt là : {info.Name}");
            }
            // In ra tất cả các thuộc tính (property) của class - private ko có get set
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"Tên của các thuộc tính lần lượt là : {info.Name}");
            }

            // In ra các phương thức (method) của class
            Console.WriteLine("Các phương thức:");
            foreach (MethodInfo infor in type.GetMethods())
            {
                if(infor.DeclaringType == typeof(person))//  // Chỉ lấy các phương thức do Person định nghĩa (bỏ những method có sẵn từ object như ToString)
                {
                    Console.WriteLine($"Tên của các phương thức lần lượt là : {infor.Name}");

                }

            }
            {

            }

        }
    }
}
