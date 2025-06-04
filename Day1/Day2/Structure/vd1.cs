using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Structure
{
    struct Diem
    {
        public int x;
        public int y;

        // Constructor
        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Hàm hiển thị thông tin điểm
        public void HienThi()
        {
            Console.WriteLine($"Tọa độ: ({x}, {y})");
        }
    }
    public class vd1
    {
        static void Main()
        {
            Diem d1 = new Diem(3, 4);
            d1.HienThi();  // Tọa độ: (3, 4)
        }
    }
}
