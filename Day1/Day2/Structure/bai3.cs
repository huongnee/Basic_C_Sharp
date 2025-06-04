using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Structure
{
    struct SanPham
    {
        private string  name;

        public string  ten
        {
            get { return name; }
            set { name = value; }
        }
        private int quantity;

        public int soluong
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double price;
        public double gia
        {
            get { return price; }
            set { price = value; }
        }
        public SanPham(string ten, int soLuong, double gia)
        {
            this.name = ten;
            this.quantity = soLuong;
            this.price = gia;
        }
        public double TongTien()
        {
            return price * quantity;
        }
        public void NhapThongTin()
        {
            Console.Write("Nhập tên sản phẩm: ");
            name = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            quantity = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.WriteLine($"Sản phẩm: {name}, Số lượng: {quantity}, Giá: {price}, Tổng tiền: {TongTien()}");
        }
    }
    public class bai3
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập số lượng sản phẩm: ");
            int n = int.Parse(Console.ReadLine());
            SanPham [] sp = new SanPham[n];

            for (int i = 0; i < n; i++) 
            {
                sp[i] = new SanPham();
                Console.WriteLine($"Nhập thông tin cho sản phẩm {i + 1}:");
                sp[i].NhapThongTin();
            }
            for (int i = 0; i < n; i++) {
                sp[i].HienThi();
            }


        }
    }
}

/*
 
    🔰 Bài 3: Struct Sản phẩm
        Yêu cầu:

        Tạo struct SanPham gồm:

        string ten

        double gia

        int soLuong

        Viết hàm tính tổng tiền của mỗi sản phẩm (gia * soLuong).

        Nhập danh sách sản phẩm và in ra tổng tiền của từng sản phẩm.

 */