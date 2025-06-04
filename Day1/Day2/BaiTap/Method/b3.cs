using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.BaiTap.Method
{
    public class b3
    {
        public static bool KiemTraNamNhuan(int nam)
        {
            // Năm nhuận nếu chia hết cho 4 nhưng không chia hết cho 100, hoặc chia hết cho 400
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }
        public static int DemSoChuSo(int so)
        {
            // Chuyển số thành chuỗi và đếm độ dài
            //Hàm ToString() trong C# là một phương thức dùng để chuyển đổi giá trị của một biến (như số nguyên, ký tự, số thực, v.v.)
            //thành chuỗi (string)
            return so.ToString().Length;
        }
        public static int DaoNguocSo(int so)
        {
            int daoNguoc = 0;
            while (so > 0)
            {
                daoNguoc = daoNguoc * 10 + so % 10;
                so /= 10;
            }
            return daoNguoc;
        }
        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
        public static bool KiemTraSoNguyenTo(int so)
        {
            if (so < 2) return false; // Số nguyên tố phải lớn hơn 1
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0) return false; // Nếu chia hết cho bất kỳ số nào từ 2 đến căn bậc hai của số thì không phải số nguyên tố
            }
            return true; // Nếu không chia hết cho bất kỳ số nào thì là số nguyên tố
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhập năm để kiểm tra năm nhuận:");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Năm {nam} {(KiemTraNamNhuan(nam) ? "là" : "không phải")} năm nhuận.");
            Console.WriteLine("Nhập một số nguyên để đếm số chữ số:");
            int so = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Độ dài của số vừa nhập là "+DemSoChuSo(so));
            Console.WriteLine("Nhập một số nguyên để đảo ngược:");
            int soDaoNguoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số đảo ngược là " + DaoNguocSo(soDaoNguoc));
            Console.WriteLine("Nhập hai số nguyên dương để tìm UCLN và BCNN:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"UCLN của {a} và {b} là {UCLN(a, b)}");
            Console.WriteLine("Nhập một số nguyên dương để kiểm tra số nguyên tố:"); 
            int soNguyenTo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Số {soNguyenTo} {(KiemTraSoNguyenTo(soNguyenTo) ? "là" : "không phải")} số nguyên tố.");
        }
    }
}


/*
  Viết phương thức kiểm tra 1 năm có phải năm nhuận không
  Viết phương thức đếm số chữ số của 1 số nguyên.
  Viết phương thức đảo ngược 1 số nguyên
  Viết phương thức tìm UCLN và BCNN của hai số nguyên dương a và b.
  Viết phương thức kiểm tra một số nguyên dương có phải là số nguyên tố hay không.
 */