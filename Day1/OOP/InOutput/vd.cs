using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.InOutput
{
    internal class vd
    {
        public static void Main(string[] args)
        {
            string path = @"E:\Downloads\kaka.txt"; ;

            // Ghi nội dung mới
            File.WriteAllText(path, "Xin chào bạn!\n");

            // Thêm dòng mới
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine("Dòng mới được thêm!");
            }

            // Đọc lại và in ra
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}
