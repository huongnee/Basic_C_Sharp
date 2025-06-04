using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Enum
{
   
    internal class vd2
    {
        public enum gioiTinh
        {
            nam, //0
            nu,
            khac
        }
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Vui lòng nhập tên người dùng");
            string tenNguoiDung = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập giới tính (0: Nam, 1: Nữ, 2: Khác)");
            int gtinh = Convert.ToInt32(Console.ReadLine());
            gioiTinh gt = (gioiTinh)gtinh;
            Console.WriteLine("Tên người dùng: " + tenNguoiDung);
            Console.WriteLine("Giới tính đã chọn: " + gt);
            
        }
    }
}
/*
    🧪 Bài tập 1: Enum giới tính
        Yêu cầu:

        Khai báo enum GioiTinh gồm: Nam, Nu, Khac.

        Viết chương trình nhập tên người dùng và chọn giới tính (theo số).

        In ra tên và giới tính đã chọn.
 */