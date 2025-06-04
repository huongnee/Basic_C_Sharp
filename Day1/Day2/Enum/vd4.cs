using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Enum
{
    public enum qlTTDH
    {
        choxacnhan,
        danggiao,
        dagiao,
        dahuy
    }
    public class DonHang
    {
        private string maDH;

        public string madonhang
        {
            get { return maDH; }
            set { maDH = value; }
        }
        // Trạng thái 
        private qlTTDH trangThai;

        public qlTTDH trangthai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public void input()
        {
            Console.WriteLine("Nhập mã đơn hàng");
            maDH = Console.ReadLine();
            Console.WriteLine("Nhập trạng thái đơn hàng");
            trangThai = (qlTTDH)Convert.ToInt32(Console.ReadLine());
        }
        public void output() 
        { 
            
            Console.WriteLine($"Mã đơn hàng: {maDH}");
            Console.WriteLine($"Trạng thái đơn hàng: {trangThai}");
        }



        }
        internal class vd4
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Vui lòng chọn số lượng đơn hàng muốn nhập");
            int n = Convert.ToInt32(Console.ReadLine());
            DonHang [] dh = new DonHang[n];

            for (int i = 0; i < n; i++) 
            {
                dh[i] = new DonHang();
                Console.WriteLine($"Nhập đơn hàng thứ {i+1}" );
                dh[i].input();
            }
            //Hiển thị ra các đơn hàng đã giao
            for(int i = 0; i < n; i++)
            {
                if (dh[i].trangthai == qlTTDH.dagiao)
                {
                    Console.WriteLine($"Thông tin đơn hàng thứ {i + 1}");
                    dh[i].output();
                }    
               
            }
        }
    }
}
/*
 🧪 Bài tập 4: Quản lý trạng thái đơn hàng
        Yêu cầu:

        Tạo enum TrangThaiDonHang: ChoXacNhan, DangGiao, DaGiao, DaHuy.

        Viết class DonHang gồm:

        Mã đơn hàng (string)

        Trạng thái (enum)

        Tạo danh sách 3 đơn hàng với trạng thái khác nhau.

        Viết vòng lặp in ra đơn hàng nào đã giao thành công.
 */