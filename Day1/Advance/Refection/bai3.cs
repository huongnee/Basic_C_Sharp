using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;    // Thư viện hỗ trợ Reflection

namespace Day1.Advance.Refection
{
    public class person
    {
        public string name { get; set; }
    }
    public class bai3
    {
        public static void Main(string[] args)
        {
            Type type = typeof(person);
            object obj = Activator.CreateInstance(type);
            PropertyInfo info = type.GetProperty("name");
            info.SetValue(obj,"Alice");
            string name = (string)(info.GetValue(obj));
            Console.WriteLine($"Name là : {name}");
        }
    }
}
/*
 Bài tập 3: Đọc và gán giá trị cho property
Yêu cầu: Dùng Reflection để:

Tạo đối tượng Person.

Set giá trị cho property Name là "Alice".

Lấy lại giá trị và in ra.
 */