using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Chuoi
{
    internal class ChuoiNe
    {
        public static void Main(string[] args)
        {
            // Length – Lấy độ dài chuỗi
            string chuoi = "CSharp";
            Console.WriteLine(chuoi.Length);  // 6

            // ToUpper() – Viết hoa tất cả
            string ten = "huong";
            Console.WriteLine(ten.ToUpper());  // HUONG

            //ToLower() – Viết thường tất cả
            string ten1 = "HUONG";
            Console.WriteLine(ten1.ToLower());  // huong

            //Contains() – Kiểm tra chứa chuỗi con
            string text = "Xin chào C#";
            Console.WriteLine(text.Contains("C#"));  // true

            //IndexOf() – Vị trí xuất hiện chuỗi con
            string s = "Hello world";
            Console.WriteLine(s.IndexOf("world"));  // 6

            // Substring(start, length) – Cắt chuỗi con
            string ss = "Lập trình C#";
            string con = ss.Substring(10, 2);
            Console.WriteLine(con);  // C#

            // Replace(old, new) – Thay thế chuỗi
            string loi = "I love Java";
            string dung = loi.Replace("Java", "C#");
            Console.WriteLine(dung);  // I love C#

            //Split() – Tách chuỗi - Tách chuỗi thành mảng
            string danhSach = "An,Bình,Chi";
            string[] tten = danhSach.Split(',');
            foreach (string t in tten)
            {
                Console.WriteLine(t);  // An  Bình  Chi
            }

            // Trim() – Loại bỏ khoảng trắng đầu & cuối chuỗi - Xóa khoảng trắng
            string teen = "  Huong  ";
            Console.WriteLine(teen.Trim());  // "Huong"

            // Chèn chuỗi (String Interpolation)

            string tenn = "Hoa";
            int tuoi = 21;

            Console.WriteLine($"Chào {tenn}, bạn {tuoi} tuổi.");
            // Chào Hoa, bạn 21 tuổi.

            // So sánh chuỗi
            string a = "abc";
            string b = "ABC";

            Console.WriteLine(a == b);                      // false
            Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true



        }
    }
}
