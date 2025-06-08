using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day1.OOP.BaiTapOOP.Abstraction.abs
{
    public abstract class Employee
    {
        private string name;

        public string ten
        {
            get { return name; }
            set { name = value; }
        }


        public abstract void CalculateSalary();

    }
    public class FullTimeEmployee : Employee
    {
        public double FixedSalary { get; set; }

        public FullTimeEmployee(string nten, double fixedSalary)
        {
            ten = nten;
            FixedSalary = fixedSalary;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Nhân viên FullTime {ten} có lương: {FixedSalary} VNĐ");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public PartTimeEmployee(string name, double hoursWorked, double hourlyRate)
        {
            ten = name;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override void CalculateSalary()
        {
            double salary = HoursWorked * HourlyRate;
            Console.WriteLine($"Nhân viên PartTime {ten} có lương: {salary} VNĐ");
        }
    }

    public class vdAbs
    {
        static void Main(string[] args)
        {
            Employee emp1 = new FullTimeEmployee("Nguyễn Văn A", 15000000);
            Employee emp2 = new PartTimeEmployee("Trần Thị B", 80, 50000);

            emp1.CalculateSalary();
            emp2.CalculateSalary();
        }
    }
}
/*
 🔹 Bài 5: Nhân viên tính lương
    Yêu cầu:

    Tạo abstract class Employee với thuộc tính Name, phương thức abstract CalculateSalary().

    Tạo 2 lớp FullTimeEmployee (lương cố định) và PartTimeEmployee (tính theo giờ) kế thừa Employee.

    Input/Output mẫu:
    Employee e1 = new FullTimeEmployee("Lan", 15000000);
    Employee e2 = new PartTimeEmployee("Nam", 50, 100000);

    Console.WriteLine(e1.CalculateSalary()); // Output: 15,000,000
    Console.WriteLine(e2.CalculateSalary()); // Output: 5,000,000

 */