using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Method
{
    public class TinhToan
    {
        public static object Sum(object a, object b) // nếu mà là static thì ko cần gọi đối tượng t.sum mà là tinhtoan.sum luon
        {
            return (int)a + (int)b;
        }
        public object div(object a, object b) {
            return Convert.ToSingle(a) / Convert.ToSingle(b);
        }
    }
    public class TutorialMethod
    {
        public static void Main(string[] args) {
            TinhToan t = new TinhToan();
            Console.WriteLine("Nhập số thứ nhất ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tổng 2 số đã nhập là"+TinhToan.Sum(a,b));
            Console.WriteLine("Thương 2 số đã nhập là" + t.div(a, b));

        }
    }
}
