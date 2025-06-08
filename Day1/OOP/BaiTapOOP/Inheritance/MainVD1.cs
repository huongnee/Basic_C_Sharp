using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day1.OOP.BaiTapOOP.Inheritance
{
    public class person
    {
        private string name;

        public string ten
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int tuoi
        {
            get { return age; }
            set { age = value; }
        }
        public virtual void display()
        {
            Console.WriteLine($"Tên : {name} Tuổi : {age}");
        }

    }
   
    public class teacher : person
    {
        private string subject;

        public string monhoc
        {
            get { return subject; }
            set { subject = value; }
        }
        public override void display() {
            base.display();
            Console.WriteLine($"Môn học {subject}");
        }

    }

    public class student : person
    {
        private string studentID;

        public string msv
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public override void display()
        {
            base.display();
            Console.WriteLine($"Mã sinh viên {studentID}");
        }

    }



    public class MainVD1
    {
        public static void Main(string[] args)
        {
            student sv1 = new student();
            sv1.ten = "Hehe";
            sv1.tuoi = 22;
            sv1.msv = "msv01";
            teacher teacher1 = new teacher();
            teacher1.ten = "kaka";
            teacher1.tuoi = 32;
            teacher1.monhoc = "Toán";
            Console.WriteLine("== Thông tin học sinh ==");
            sv1.display();
            Console.WriteLine("\n== Thông tin giáo viên ==");
            teacher1.display();
        }
    }
}
