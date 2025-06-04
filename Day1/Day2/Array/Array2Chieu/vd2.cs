using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Array.Array2Chieu
{
    
    internal class vd2
    {
        public static void input(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Nhập giá trị");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());                
                }
            }    
        }
        public static void output(int[,] arr) 
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(" "+arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int[,] arr = new int[2,3];
            input(arr);
            output(arr);

        }
    }
}
