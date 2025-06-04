using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Array
{
   
    public class b3arr
    {
        /// Gộp hai mảng số nguyên và sắp xếp kết quả theo thứ tự tăng dần
        /// <param name="arr1">Mảng số nguyên thứ nhất</param>
        /// <param name="arr2">Mảng số nguyên thứ hai</param>
        /// <returns>Mảng mới chứa tất cả phần tử của hai mảng đã được sắp xếp</returns>
        public static int[] GopHaiMang(int[] arr1, int[] arr2)
        {
            // Tạo mảng mới với kích thước bằng tổng độ dài của hai mảng đầu vào
            int[] result = new int[arr1.Length + arr2.Length];
            
            // Sao chép toàn bộ phần tử của mảng arr1 vào mảng result từ vị trí 0
            //thiếu tham số
            System.Array.Copy(arr1, result, arr1.Length);//Array.Copy(Array sourceArray, Array destinationArray, int length);
            /*
                arr1: mảng nguồn (source).
                result: mảng đích (destination).
                arr1.Length: số phần tử cần sao chép từ arr1 sang result.
             */

            // Sao chép toàn bộ phần tử của mảng arr2 vào mảng result
            // bắt đầu từ vị trí cuối của arr1 (arr1.Length)
            //đủ tham số
            System.Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
            /*
                Array.Copy(
                            Array sourceArray,         // Mảng nguồn
                            int sourceIndex,           // Vị trí bắt đầu từ mảng nguồn
                            Array destinationArray,    // Mảng đích
                            int destinationIndex,      // Vị trí bắt đầu trong mảng đích
                            int length                 // Số phần tử cần sao chép
                        );
             */
            // Sắp xếp mảng kết quả theo thứ tự tăng dần
            System.Array.Sort(result);
            
            return result;
        }

        /// Loại bỏ các phần tử trùng lặp trong mảng
        /// <param name="arr">Mảng đầu vào cần xử lý</param>
        /// <returns>Mảng mới chỉ chứa các phần tử duy nhất</returns>
        public static int[] LoaiBoPhanTuTrung(int[] arr)
        {
            // Sử dụng LINQ Distinct() để lọc ra các phần tử duy nhất
            // và chuyển kết quả thành mảng mới
            return arr.Distinct().ToArray();
        }

        /// Phương thức Main để chạy thử nghiệm các chức năng
        public static void Main(string[] args)
        {
            // Thử nghiệm gộp hai mảng
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 3, 4, 5 };
            int[] gopMang = GopHaiMang(arr1, arr2);
            Console.WriteLine("Mảng sau khi gộp: " + string.Join(", ", gopMang));

            // Thử nghiệm loại bỏ phần tử trùng
            int[] arr3 = { 1, 2, 2, 3, 4, 4, 5 };
            int[] mangKhongTrung = LoaiBoPhanTuTrung(arr3);
            Console.WriteLine("Mảng sau khi loại bỏ phần tử trùng: " + string.Join(", ", mangKhongTrung));
        }
    }
}
/*
  Gộp hai mảng thành một mảng mới rồi sắp xếp.

  Loại bỏ các phần tử trùng nhau trong mảng.
 */