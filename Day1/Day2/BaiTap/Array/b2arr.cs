using System;
using System;

namespace Day1.Day2.BaiTap.Array
{
    internal class b2arr
    {
        public static int TimViTriDauTien(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i; // Trả về vị trí đầu tiên của x
                }
            }
            return -1; // Không tìm thấy
        }

        public static void XoaPhanTuTaiViTri(ref int[] arr, int viTri)
        {
            // Kiểm tra vị trí hợp lệ
            if (viTri < 0 || viTri >= arr.Length)
            {
                Console.WriteLine("Vị trí không hợp lệ.");
                return;
            }
            // Xóa phần tử tại vị trí viTri
            for (int i = viTri; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            System.Array.Resize(ref arr, arr.Length - 1); // Giảm kích thước mảng đi 1
        }

        public static void ChenPhanTuTaiViTri(ref int[] arr, int x, int viTri)
        {
            // Kiểm tra vị trí hợp lệ
            if (viTri < 0 || viTri > arr.Length)
            {
                Console.WriteLine("Vị trí không hợp lệ.");
                return;
            }
            // Tạo mảng mới với kích thước lớn hơn 1
            System.Array.Resize(ref arr, arr.Length + 1);

            for (int i = arr.Length - 1; i > viTri; i--)
            {
                arr[i] = arr[i - 1];
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Phần tử thứ "+i+ "=" +arr[i] + " "); // In ra các phần tử trước vị trí chèn
            }
            // Chèn phần tử x vào vị trí viTri
            arr[viTri] = x;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

            int x = 3;
            int viTriDauTien = TimViTriDauTien(arr, x);
            Console.WriteLine($"Vị trí đầu tiên của {x} là: {viTriDauTien}");

            XoaPhanTuTaiViTri(ref arr, viTriDauTien);
            Console.WriteLine("Mảng sau khi xóa phần tử tại vị trí " + viTriDauTien + ": " + string.Join(", ", arr));

            ChenPhanTuTaiViTri(ref arr, 10, 2);
            Console.WriteLine("Mảng sau khi chèn phần tử 10 vào vị trí 2: " + string.Join(", ", arr));
        }
    }
}

/*
 Tìm vị trí xuất hiện đầu tiên của 1 số trong mảng.

 Xóa phần tử tại 1 vị trí bất kỳ trong mảng.

 Chèn 1 phần tử vào vị trí bất kỳ trong mảng
 */