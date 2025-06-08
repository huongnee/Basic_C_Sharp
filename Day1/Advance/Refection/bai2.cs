using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;    // Thư viện hỗ trợ Reflection

namespace Day1.Advance.Refection
{
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Hehe");
        }
    }
    public class bai2
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Animal);
            
            object obj = Activator.CreateInstance(type);

            MethodInfo info = type.GetMethod("Speak");

            info.Invoke(obj, null);

        }
    }

}
/*
Bài tập 2: Gọi phương thức bằng Reflection
Yêu cầu: Trong class Animal, tạo một phương thức Speak(). Sử dụng Reflection để:
Tạo đối tượng Animal.
Gọi phương thức Speak() bằng MethodInfo.

 */