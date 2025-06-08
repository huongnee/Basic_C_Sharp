using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;    // Thư viện hỗ trợ Reflection

namespace Day1.Advance.Refection
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Dividedd(int num1, int num2)
        {
            return num1 + num2;
        }

    }
    public class bai5
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Calculator);

            object obj = Activator.CreateInstance(type);

            MethodInfo info = type.GetMethod("Add");

            object sum = info.Invoke(obj, new object[] {51,2});
            int sum2 = (int)sum; 
            Console.WriteLine($"Tổng là {sum2}");
        }
    }
}
/*
 Bài tập 5: Gọi hàm có tham số
Yêu cầu: Dùng Reflection để gọi method Add(int a, int b) trong class Calculator, truyền tham số và in ra kết quả.
 */