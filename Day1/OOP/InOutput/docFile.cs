using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.InOutput
{
    public class docFile
    {
        public static void Main(string[] args)
        {
            //Dùng File.ReadAllText() – đọc toàn bộ nội dung
            string path = @"E:\Downloads\haha.txt";
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
            //Dùng File.ReadAllLines() – đọc từng dòng
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //Dùng StreamReader – đọc từng dòng linh hoạt hơn
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
