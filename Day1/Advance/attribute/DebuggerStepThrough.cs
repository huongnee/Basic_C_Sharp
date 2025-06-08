using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 DebuggerStepThrough – Bỏ qua khi debug (không bước vào hàm)
    ✔️ Ý nghĩa:
    Khi bạn bấm F11 debug, sẽ bỏ qua không vào hàm này — tiết kiệm thời gian khi debug các hàm phụ, ổn định.
 */
namespace Day1.Advance.attribute
{
    public class DebuggerStepThrough
    {
        [DebuggerStepThrough]
        static void Helper()
        {
            Console.WriteLine("Hàm phụ...");
        }

        public static void Main()
        {
            Console.WriteLine("Bắt đầu");
            Helper(); // Debug sẽ bỏ qua hàm này
            Console.WriteLine("Kết thúc");
        }
    }
}
