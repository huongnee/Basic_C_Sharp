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
        public int Add(int num1,int num2)
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
    public class bai4
    {
        public static void Main(string[] args) 
        {
            Type type = typeof(Calculator);

            object obj = Activator.CreateInstance(type);


            foreach (MethodInfo info in type.GetMethods())
            {
                Console.WriteLine($"Tên : {info.Name} - SL tham số {info.GetParameters().Length} - Kiểu trả về của nó là {info.ReturnType}");

            }
        }
    }
}
/*
 Bài tập 4: Duyệt tất cả method của một class
    Yêu cầu: Tạo class Calculator có các method: Add, Subtract, Multiply, Divide. Dùng Reflection để:

    In ra tên và số lượng tham số của từng method.

    Kiểm tra kiểu trả về của mỗi method.
 */