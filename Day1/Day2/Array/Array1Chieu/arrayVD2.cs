using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Array.Array1Chieu
{
    internal class arrayVD2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 10, 4, 5, };
            int max = arr[0];
            foreach(int tmp in arr)
            {
                Console.WriteLine(tmp);
            }
            foreach(int tmp1 in arr)
            {
                if(tmp1 > max)
                {
                    max = tmp1;
                }
            }
            Console.WriteLine("giá trị lớn nhất trong mảng là "+max);
        }

    }
}
