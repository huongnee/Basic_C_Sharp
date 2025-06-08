using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
DllImport – Gọi hàm từ thư viện ngoài (interop)
✔️ Ý nghĩa:
Gọi hàm từ thư viện C/C++ hoặc thư viện hệ thống (DLL).
📌 Dùng trong các ứng dụng liên kết với C (Interop).
 */
namespace Day1.Advance.attribute
{   //  🧪 Ví dụ: Gọi hàm MessageBox từ thư viện Windows
    public class pt_DllImport
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int type);
        public static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Chào bạn!", "Thông báo", 0);
        }
    }
}
