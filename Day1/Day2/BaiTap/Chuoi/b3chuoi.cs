using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Chuoi
{
    internal class b3chuoi
    {
        // 1. Đếm số lần xuất hiện của 1 từ trong chuỗi
        public static int DemSoLanXuatHien(string chuoi, string tuCanTim)
        {
            int count = 0;
            string[] tu = chuoi.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string t in tu)
            {
                if (t.Equals(tuCanTim, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }

        // 2. Tách họ, tên đệm, tên từ chuỗi họ tên đầy đủ
        public static void TachHoTen(string hoTen, out string ho, out string tenDem, out string ten)
        {
            string[] arr = hoTen.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ho = arr[0];
            ten = arr[arr.Length - 1];
            if (arr.Length > 2)
            {
                tenDem = string.Join(" ", arr, 1, arr.Length - 2);
            }
            else
            {
                tenDem = "";
            }
        }

        // 3. Mã hóa chuỗi: thay mỗi ký tự bằng ký tự kế tiếp trong bảng chữ cái
        public static string MaHoaChuoi(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'y')
                    sb.Append((char)(c + 1));
                else if (c == 'z')
                    sb.Append('a');
                else if (c >= 'A' && c <= 'Y')
                    sb.Append((char)(c + 1));
                else if (c == 'Z')
                    sb.Append('A');
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        // Hàm Main
        static void Main(string[] args)
        {
            // Nhập chuỗi bất kỳ
            Console.Write("Nhập chuỗi: ");
            string chuoi = Console.ReadLine();

            // 1. Đếm số lần xuất hiện của 1 từ
            Console.Write("Nhập từ cần đếm: ");
            string tuCanTim = Console.ReadLine();
            int soLan = DemSoLanXuatHien(chuoi, tuCanTim);
            Console.WriteLine($"Từ \"{tuCanTim}\" xuất hiện {soLan} lần trong chuỗi.");

            // 2. Tách họ, tên đệm, tên
            Console.Write("Nhập họ tên đầy đủ: ");
            string hoTen = Console.ReadLine();
            string ho, tenDem, ten;
            TachHoTen(hoTen, out ho, out tenDem, out ten);
            Console.WriteLine($"Họ: {ho}");
            Console.WriteLine($"Tên đệm: {tenDem}");
            Console.WriteLine($"Tên: {ten}");

            // 3. Mã hóa chuỗi
            Console.Write("Nhập chuỗi cần mã hóa: ");
            string chuoiCanMaHoa = Console.ReadLine();
            string chuoiMaHoa = MaHoaChuoi(chuoiCanMaHoa);
            Console.WriteLine($"Chuỗi sau khi mã hóa: {chuoiMaHoa}");

            // Dừng màn hình
            Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }

}
/*
    Tìm và đếm số lần xuất hiện của 1 từ trong chuỗi.
    Tách họ, tên đệm, tên từ chuỗi họ tên đầy đủ.
    VD: "Nguyễn Văn An" → Họ: Nguyễn, Tên đệm: Văn, Tên: An

    Mã hóa chuỗi: thay mỗi ký tự bằng ký tự kế tiếp trong bảng chữ cái.
 */