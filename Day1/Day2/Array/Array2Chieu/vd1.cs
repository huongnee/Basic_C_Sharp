using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Array.Array2Chieu
{
    internal class vd1
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int [2,2]; // khai báo 1 mảng 2 chiều gồm 2 hàng 3 cột
            // cách nhập 1
            arr[0,0] = 1; // gán giá trị hàng 0 cột 0 bằng 1
            arr[0,1] = 2; // gán giá trị hàng 0 cột 1 bằng 2
            arr[1, 0] = 10; // gán giá trị hàng 1 cột 0 bằng 10
            arr[1, 1] = 20; // gán giá trị hàng 1 cột 1 bằng 20
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" "+arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
