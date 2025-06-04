using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Method
{
    internal class b2
    {
        public static int chuyenDoiMangSangTong(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++) 
            { 
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int DemSoLe(int[] arr)
        {
            int Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Count++;
                }
            }
            return Count;
        }
        public static bool KiemTraNguyenAm(char c)
        {
            char [] nguyenAm = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return nguyenAm.Contains(c);
        }
        public static int DemKyTuVietHoa(string str)
        {
           int count = 0;
           foreach(char kytu in str)
            {
                if (char.IsUpper(kytu))
                {
                    count++;
                }
            }
           /*
           for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    count++;
                }
            }
           */
            // Hoặc có thể dùng LINQ
            // count = str.Count(char.IsUpper);
            return count;
        }
        public static void Main(string[] args)
        {
            char TestnNguyenAm = 'a';
            int [] arr = { 1, 2, 3, 15, 4, 5 , 10};
            Console.WriteLine("Tổng các phần tử trong mảng là "+chuyenDoiMangSangTong(arr));
            Console.WriteLine("Phần tử lớn nhất trong mảng là " + Max(arr));
            Console.WriteLine("Số lượng số lẻ trong mảng là " + DemSoLe(arr));
            Console.WriteLine("Ký tự " + TestnNguyenAm + " có phải là nguyên âm không? " + KiemTraNguyenAm(TestnNguyenAm));
            string str = "Hello World!";
            Console.WriteLine("Số lượng ký tự viết hoa trong chuỗi \"" + str + "\" là " + DemKyTuVietHoa(str));
        }   
    }
}
/*
    ✅ Viết phương thức nhận vào một mảng số nguyên và trả về tổng các phần tử.

    ✅ Viết phương thức tìm phần tử lớn nhất trong mảng.

    ✅ Viết phương thức đếm số lượng số lẻ trong mảng.

    ✅ Viết phương thức kiểm tra một ký tự có phải là nguyên âm không.

    ✅ Viết phương thức nhận chuỗi và đếm số lượng ký tự viết hoa.

 */