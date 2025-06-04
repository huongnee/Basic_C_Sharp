using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Nullable
{
    public class Nullable
    {
        static void Main()
        {
            int? tuoi = null; // Chưa biết tuổi

            if (tuoi.HasValue)
            {
                // Nếu biến có giá trị, in ra
                Console.WriteLine("Tuổi là: " + tuoi.Value);
            }
            else
            {
                // Nếu biến chưa có giá trị
                Console.WriteLine("Chưa nhập tuổi");
            }

            // Gán giá trị cho biến nullable
            tuoi = 22;

            // Viết ngắn gọn hơn bằng toán tử null-coalescing
            Console.WriteLine("Tuổi hiện tại: " + (tuoi ?? -1));
        }
    }
    //hoặc ví dụ khác như sau
    public class NhanVien
    {
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; } // Có thể chưa cập nhật ngày sinh
    }

}
