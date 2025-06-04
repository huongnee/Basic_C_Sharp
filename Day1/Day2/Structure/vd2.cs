using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Structure
{
    struct Sach
    {
        public string tenSach;
        public string tacGia;
        public int namXuatBan;

        public void HienThi()
        {
            Console.WriteLine($"Tên sách: {tenSach}");
            Console.WriteLine($"Tác giả: {tacGia}");
            Console.WriteLine($"Năm xuất bản: {namXuatBan}");
        }
    }
    public class vd2
    {
        static void Main()
        {
            Sach s1;
            s1.tenSach = "Lập trình C#";
            s1.tacGia = "Nguyễn Văn A";
            s1.namXuatBan = 2023;

            s1.HienThi();
        }
    }
}
