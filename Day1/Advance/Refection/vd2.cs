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
        public string Species { get; set; }  // Thuộc tính Species (loài động vật)
        public string Name { get; set; }
        public string Description { get; set; }
        public void run()
        {
            Console.WriteLine("Animal is running");
        }
        public void speak()
        {
            Console.WriteLine("Animal is speaking");
        }
    }
    public class vd2
    {
        //type.GetMethods() --> trả về 1 mảng các giá tr
        public static void Main(string[] args)
        {
            // Lấy kiểu (metadata) của class Animal, dùng cho Reflection
            Type type = typeof(Animal);
            //Tạo một đối tượng mới của kiểu (class) mà biến type đại diện, và gán nó vào biến obj kiểu object
            object obj = Activator.CreateInstance(type);
            // Lấy thông tin về thuộc tính "Species" của class Animal
            PropertyInfo info = type.GetProperty("Description");
            Console.WriteLine(info.Name);
            // Gán giá trị "Cat" cho thuộc tính Species của đối tượng obj
            info.SetValue(obj, "cat");
            Console.WriteLine(info.GetValue(obj));
            // Lấy giá trị thuộc tính Species từ obj và ép kiểu về string
            string spe = (string)info.GetValue(obj);
            Console.WriteLine($"Species : {spe}");
            // Lấy thông tin về phương thức "Speak"
            MethodInfo mt = type.GetMethod("speak");
            Console.WriteLine(mt.Name);

            // Gọi phương thức Speak() trên đối tượng obj
            mt.Invoke(obj, null);// gọi ra các phương thức, muốn gọi hết thì dùng vòng lặp
            // chứ ở đây chọn speak r nó in ra mỗi speak
        }

    }
}
