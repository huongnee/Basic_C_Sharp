#define DEBUG_MODE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Conditional – Gọi hàm chỉ khi có định nghĩa cụ thể
    ✔️ Ý nghĩa:
    Chỉ gọi hàm nếu biến điều kiện được định nghĩa bằng #define.
    📌 Dùng để bỏ qua/hạn chế hàm trong từng chế độ build (Debug/Release).
 */
namespace Day1.Advance.attribute
{
    public class Conditional
    {
        [Conditional("DEBUG_MODE")] // biến điều kiện của hàm, ở đây dk là có #define DEBUG_MODE ở đầu
        public static void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }

        public static void Main()
        {
            Log("Đang chạy chương trình...");
            Console.WriteLine("Kết thúc.");
        }
    }
}
