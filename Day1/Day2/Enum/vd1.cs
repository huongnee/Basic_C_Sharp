using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Enums
{
    internal class vd1
    {
        // Định nghĩa enum cho các ngày trong tuần
        public enum NgayTrongTuan
        {
            ChuNhat = 1,
            ThuHai,
            ThuBa,
            ThuTu,
            ThuNam,
            ThuSau,
            ThuBay
        }
        public static void Main()
        {
            // Sử dụng enum
            NgayTrongTuan homNay = NgayTrongTuan.ThuTu;

            Console.WriteLine($"Hôm nay là: {homNay} ({(int)homNay})"); // Hôm nay là: ThuTu (4)

            // Kiểm tra giá trị của enum
            if (homNay == NgayTrongTuan.ThuTu)
            {
                Console.WriteLine("Hôm nay là thứ Tư!");
            }
        }
    }
}