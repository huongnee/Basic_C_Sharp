using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Chuoi
{
    internal class b2chuoi
    {
        public static void daoNguocChuoi(string str)
        {
            if (str == null)
            {
                Console.WriteLine("Chuỗi rỗng không đảo ngược được");
            }
            else
            {
                str = string.Concat(str.Reverse());// sau khi đảo ngược thì nối chuỗi
                Console.WriteLine(str);
            }
        }

        public static void kiemTraChuoiDoiXung(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Chuỗi rỗng không kiểm tra được");
                return;
            }

            str = str.ToLower(); // chuyển về chữ thường để so sánh
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    Console.WriteLine("Chuỗi không đối xứng");
                    return;
                }
                left++;
                right--;
            }
            Console.WriteLine("Chuỗi đối xứng");
        }

        public static int demTuTrongChuoi(string str)
        {
            /* cách 1
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Chuỗi rỗng không đếm được số từ");
                return;
            }

            // Split by whitespace and remove empty entries
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine($"Số từ trong chuỗi là: {words.Length}");
            */
            /*
             count: Biến đếm số từ.,inWord: Biến cờ cho biết hiện tại con trỏ đang ở trong một từ (true) hay không (false)
             */
            /*
                Duyệt từng ký tự c trong chuỗi.
                Nếu c là khoảng trắng (char.IsWhiteSpace(c)), nghĩa là đã kết thúc một từ hoặc đang ở giữa các khoảng trắng, nên đặt inWord = false.

                Nếu c không phải khoảng trắng:

                Nếu trước đó không ở trong từ (!inWord), tức là vừa gặp ký tự đầu tiên của một từ mới, nên tăng biến đếm count lên 1, và đặt inWord = true để đánh dấu là đang ở trong một từ.

                Nếu đã ở trong từ rồi, tiếp tục duyệt, không tăng count
             */
            int count = 0;
            bool inWord = false;

            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
            }
            return count;
        }

        public static void chuyenDoiChuoi(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Chuỗi rỗng không thể chuyển đổi");
                return;
            }

            string chuThuong = str.ToLower();
            string chuHoa = str.ToUpper();
            
            Console.WriteLine($"Chuỗi chữ thường: {chuThuong}");
            Console.WriteLine($"Chuỗi chữ hoa: {chuHoa}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Vui lòng nhập vào chuỗi muốn kiểm tra: ");
            string str = Console.ReadLine();
            Console.WriteLine("Chuỗi đảo ngược là: ");
            daoNguocChuoi(str);
            Console.WriteLine("Kiểm tra chuỗi đối xứng: ");
            kiemTraChuoiDoiXung(str);
            Console.WriteLine("Chuyển đổi chữ hoa/thường:");
            chuyenDoiChuoi(str);
        }
    }
}
/*
     Đảo ngược chuỗi.

     Viết chương trình kiểm tra chuỗi có đối xứng không (Palindrome).

     Đếm số từ trong chuỗi (tách bằng khoảng trắng).

     Chuyển đổi chuỗi thành chữ thường và chữ hoa
 */