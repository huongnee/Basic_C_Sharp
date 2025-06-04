using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Structure
{
    struct ngayThangNam
    {
        private int day;

        public int ngay
        {
            get { return day; }
            set { day = value; }
        }

        private int month;

        public int thang
        {
            get { return month; }
            set { month = value; }
        }
        private int year;

        public int nam
        {
            get { return year; }
            set { year = value; }
        }
        public ngayThangNam(int ngay, int thang, int nam)
        {
            this.day = ngay;
            this.month = thang;
            this.year = nam;
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        private int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    return 31;
            }
        }

        public bool IsValidDate()
        {
            if (year < 1)
                return false;

            if (month < 1 || month > 12)
                return false;

            if (day < 1 || day > GetDaysInMonth(month, year))
                return false;

            return true;
        }
    }
    public class bai4
    {
        public static void Main(string[] args)
        {
            // Test case 1: Valid date
            ngayThangNam date1 = new ngayThangNam(1, 1, 2023);
            Console.WriteLine($"Date: {date1.ngay}/{date1.thang}/{date1.nam} is {(date1.IsValidDate() ? "valid" : "invalid")}");

            // Test case 2: Invalid day
            ngayThangNam date2 = new ngayThangNam(31, 4, 2023);
            Console.WriteLine($"Date: {date2.ngay}/{date2.thang}/{date2.nam} is {(date2.IsValidDate() ? "valid" : "invalid")}");

            // Test case 3: Invalid month
            ngayThangNam date3 = new ngayThangNam(15, 13, 2023);
            Console.WriteLine($"Date: {date3.ngay}/{date3.thang}/{date3.nam} is {(date3.IsValidDate() ? "valid" : "invalid")}");

            // Test case 4: Leap year February
            ngayThangNam date4 = new ngayThangNam(29, 2, 2024);
            Console.WriteLine($"Date: {date4.ngay}/{date4.thang}/{date4.nam} is {(date4.IsValidDate() ? "valid" : "invalid")}");

            // Test case 5: Invalid leap year February
            ngayThangNam date5 = new ngayThangNam(29, 2, 20283);
            Console.WriteLine($"Date: {date5.ngay}/{date5.thang}/{date5.nam} is {(date5.IsValidDate() ? "valid" : "invalid")}");
        }
    }
}
/*
🔰 Bài 4: Struct Ngày tháng năm
Yêu cầu:

Tạo struct Ngay gồm: int ngay, thang, nam.

Viết hàm kiểm tra xem ngày đó có hợp lệ không (kiểm tra ngày trong tháng, năm nhuận, v.v).

*/