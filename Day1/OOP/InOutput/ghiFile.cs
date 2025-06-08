using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.InOutput
{
    public class ghiFile
    {
        public static void Main(string[] args)
        {
            //ghi đè nội dung mới vào file
            string path = @"E:\Downloads\hehe.txt";
            File.WriteAllText(path, "Nội dung mới sẽ thay thế nội dung cũ!");
            //Ghi từng dòng bằng File.WriteAllLines()
            string[] lines = { "Dòng 1", "Dòng 2", "Dòng 3" };
            File.WriteAllLines(path, lines);
            //Ghi bằng StreamWriter
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Ghi dòng 1");
                writer.WriteLine("Ghi dòng 2");
            }
            //lưu ý nếu muốn lưu thêm nội dung vào file chứ không phải ghi đè lại toàn bộ thì dùng
            //Ghi thêm nội dung vào file (append)
            /*
             Khi bạn đặt append: true, nghĩa là nội dung mới sẽ được ghi thêm vào cuối file (append = nối thêm),
            không xóa nội dung cũ.
            Nếu bạn để append: false (hoặc không truyền tham số này), thì mỗi lần mở file để ghi,
            file sẽ bị xóa trắng nội dung cũ trước khi ghi mới.
             */
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine("Dòng mới thêm");
            }


        }
    }
}
