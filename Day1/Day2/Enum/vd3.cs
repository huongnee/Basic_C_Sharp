using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Enum
{
    internal class vd3
    {
        public enum mdut
        {
            thap,
            trungbinh,
            cao
        }
        public static void Main(string[] args)
        {
            Console.Write("Vui lòng nhập mức độ ưu tiên");
            int muc = Convert.ToInt32(Console.ReadLine());
            mdut m = (mdut)muc;
            Console.WriteLine(m);
            Console.WriteLine((int)m);
        }
    }
}
/*
    🧪 Bài tập 3: Enum mức độ ưu tiên
        Yêu cầu:

        Tạo enum UuTien gồm Thap = 1, TrungBinh = 2, Cao = 3.

        Viết chương trình hiển thị thông báo tương ứng với mức độ:

        Enum	                        Thông báo
        Thap	                        ✅ Không cần gấp
        TrungBinh	                    ⚠ Cần thực hiện sớm
        Cao	                            🔥 Ưu tiên xử lý ngay
 */