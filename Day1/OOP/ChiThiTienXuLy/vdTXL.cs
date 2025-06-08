//👉 Dùng để định nghĩa hoặc bỏ định nghĩa một tên (biến môi trường) cho điều kiện biên dịch.
#define DEBUG  // Định nghĩa biến môi trường tên DEBUG - khi viết debug phải có dòng này
#undef RELEASE // Huỷ định nghĩa biến RELEASE (nếu có)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 🟢 #if, #elif, #else, #endif
👉 Viết mã có điều kiện (code chỉ chạy nếu một tên đã được define).
 */
namespace Day1.OOP.ChiThiTienXuLy
{

    public class vdTXL
    {

        static void Main(string[] args)
        {
            string username = "admin";
            string password = "123456";

            Console.Write("Nhập tên đăng nhập: ");
            string inputUser = Console.ReadLine();

            Console.Write("Nhập mật khẩu: ");
            string inputPass = Console.ReadLine();

#if DEBUG
            // Log thông tin để lập trình viên dễ kiểm tra
            Console.WriteLine($"[DEBUG] Bạn đã nhập: {inputUser} / {inputPass}");
#endif

            if (inputUser == username && inputPass == password)
            {
                Console.WriteLine("Đăng nhập thành công!");
            }
            else
            {
                Console.WriteLine("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }
    }


}

/*
 Khi test thì debug nó chạy cả từ dòng #if debug đến #endif , còn khi release- build ra sản phẩm thì nó bỏ đoạn đó ko chạy

 */