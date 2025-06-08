using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 🟢 #region và #endregion
 👉 Dùng để định nghĩa hoặc bỏ định nghĩa một tên (biến môi trường) cho điều kiện biên dịch.
 */
namespace Day1.OOP.ChiThiTienXuLy
{
    public class vd2TXL
    {
        #region Khai báo biến
        int a = 10;
        int b = 15;
        string ok = "haha";
        #endregion 

        static void Main()
        {
#pragma warning disable 414  // Tắt cảnh báo biến không dùng (CS0414)
            int unusedVariable = 10;    // Biến này không dùng, thường gây cảnh báo CS0414
#pragma warning restore 414  // Bật lại cảnh báo biến không dùng

            Console.WriteLine("Hello world!");
        }
    }
}

/*
 🟢 #warning và #error
👉 Dùng để tạo cảnh báo hoặc lỗi khi biên dịch, tùy điều kiện.
 */

/*
 
 */