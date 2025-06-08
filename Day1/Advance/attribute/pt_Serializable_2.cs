using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Day1.Advance.attribute
{
    [Serializable]
    public class Student
    {

        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class pt_Serializable_2
    {
        public static void Main(string[] args)
        {
            Student s = new Student { Name = "Huong ne", Age = 20 };

            // Chuyển đối tượng Student thành chuỗi JSON
            string json = JsonSerializer.Serialize(s);

            // Ghi chuỗi JSON vào file student.txt
            File.WriteAllText(@"E:\Downloads\ikk1.txt", json);

            Console.WriteLine("Ghi file thành công!");
        }
    }
}
