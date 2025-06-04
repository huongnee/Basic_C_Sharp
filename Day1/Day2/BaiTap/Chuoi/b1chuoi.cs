using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Chuoi
{
    internal class b1chuoi
    {
        public static void doDaiChuoi(string str)
        {
            Console.WriteLine(str);

            Console.WriteLine("Độ dài chuỗi: " + str.Length);
        }
        public static void demTatCa(string str)
        {
            Console.WriteLine("Số ký tự chuỗi là " + str.Length);
            int soChuCai = 0;
            int soChuSo = 0;
            int soKhoangTrang = 0;
            /*
              Hoặc làm kiể này
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
             */
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    soChuCai++;
                }
                else if (char.IsDigit(ch))
                {
                    soChuSo++;
                }
                else if (char.IsWhiteSpace(ch))
                {
                    soKhoangTrang++;
                }
            }
            Console.WriteLine("Số chữ cái trong chuỗi là "+soChuCai);
            Console.WriteLine("Số chữ số trong chuỗi là " + soChuSo);

            Console.WriteLine("Số khoảng trắng trong chuỗi là " + soKhoangTrang);

        }
        public static void inKyTu(string str)
        {
            // str = str.Trim(); sai cái này chỉ lọc được khoảng trắng đầu và cuối còn muốn lọc hết dùng replace
            str = str.Replace(" ", "");// bỏ toàn bộ khoảng trắng - cụ thể là thay thế chuỗi
            foreach (char ch in str)
            {
                Console.WriteLine($"{ch}");
            }
        }

    
    public static void Main(string[] args)
    {
            Console.WriteLine($"Vui lòng nhập vào 1 chuỗi ");
            string str = Console.ReadLine();
            doDaiChuoi(str);
            demTatCa(str);
            inKyTu(str);
    }
}
    }
/*
  Nhập vào 1 chuỗi, in ra chuỗi đó và độ dài.

  Đếm số ký tự, số chữ cái, chữ số và khoảng trắng trong chuỗi.

  In từng ký tự của chuỗi trên 1 dòng riêng.
 */