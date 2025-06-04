using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Array
{
    public class b1arr
    {
        public static void input(int[] arr)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("Nhập phần tử thứ {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }    
        }
        public static void output(int[] arr)
        {
            foreach(int a in arr)
            {
                Console.WriteLine($"arr[] = {a}");
            }
        }
        public static void sum(int[] arr)
        {
            int sum = 0;
            int tbc = 0;
            int count = 0;
            foreach (int a in arr)
            {
                sum = sum + a;
                count++;
            }
            Console.WriteLine($"Tổng các phần tử trong mảng là {sum}");
            Console.WriteLine($"Trung bình cộng các phần tử trong mảng là {(float)sum / count}");

        }
        public static void Max(int[] arr)
        {
            int max = arr[0];
            foreach(int a in arr)
            {
                if( a > max )
                    max = a;
            }
            Console.WriteLine($"GTLN trong mảng là {max}");
        }
        public static void Min(int[] arr)
        {
            int min = arr[0];
            foreach (int a in arr)
            {
                if (a < min)
                    min = a;
            }
            Console.WriteLine($"GTNN trong mảng là {min}");
        }
        public static int slChan(int[] arr)
        {
            int count = 0;
            foreach (int a in arr)
            {
                if(a % 2 == 0)
                {
                    count++;
                }
            }    
            return count;
        }
        public static int slLe(int[] arr)
        {
            int count = 0;
            foreach (int a in arr)
            {
                if (a % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static void SapXepTangDan(int[] arr)
        {
            int tmp = 0;
            for(int i  = 0; i < arr.Length -1; i++)
            {
                for (int j = i+1;j < arr.Length;j++)
                {
                    if(arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }    
            }

        }
        public static void SapXepGiamDan(int[] arr)
        {
            int tmp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

        }
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhập số lượng phần tử của mảng:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            input(arr);
            output(arr);
            sum(arr);
            Max(arr);
            Min(arr);
            Console.WriteLine($"Có tổng cộng {slChan(arr)} số chẵn trong mảng");
            Console.WriteLine($"Có tổng cộng {slLe(arr)} số lẻ trong mảng");
            Console.WriteLine("Sắp xếp mảng tăng dần");
            SapXepTangDan(arr);
            output(arr);
            Console.WriteLine("Sắp xếp mảng giảm dần");
            SapXepGiamDan(arr);
            output(arr);

        }

    }
}
/*
    Nhập mảng số nguyên n phần tử, in ra các phần tử.

    Tính tổng và trung bình các phần tử trong mảng.

    Tìm phần tử lớn nhất và nhỏ nhất trong mảng.

    Đếm số lượng số chẵn và lẻ trong mảng.

    Sắp xếp mảng tăng dần.
 */