using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.Lop_DoiTuong
{
    public class Cars
    {
        private string code;

        public string maxe
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string tenxe
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double giaxe
        {
            get { return price; }
            set { price = value; }
        }

        public Cars(string code, string name, double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
        public Cars()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine("Ma xe: " + code);
            Console.WriteLine("Ten xe: " + name);
            Console.WriteLine("Gia xe: " + price);
        }


    }
    public class vidu1
    {
        public static void Main(string[] args)
        {
            Cars volvo = new Cars();
            volvo.maxe = "Volvo123";
            volvo.tenxe = "Volvo XC90";
            volvo.giaxe = 50000.0;
            volvo.ShowInfo();

        }
    }
}
