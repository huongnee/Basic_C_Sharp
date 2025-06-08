using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[Obsolete] — đánh dấu hàm cũ không nên dùng
namespace Day1.Advance.attribute
{
    public class MyClass
    {
        [Obsolete("Hàm này đã lỗi thời, hãy dùng newMethod()")]
        public void oldMethod()
        {
            Console.WriteLine("Đang chạy hàm cũ !");
        }
        public void newMethod()
        {
            Console.WriteLine("Đang chạy hàm mới");
        }
    }
    public class pt_Obsolete
    {
        public static void Main(string[] args) 
        {
            MyClass m1 = new MyClass();
            m1.oldMethod();
        }
    }
}
