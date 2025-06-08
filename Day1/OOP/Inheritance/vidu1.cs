using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.Inheritance
{
    public class animal
    {
        private string name;

        public string ten
        {
            get { return name; }
            set { name = value; }
        }

        private string color;

        public string mausac
        {
            get { return color; }
            set { color = value; }
        }


        public virtual void an()
        {

        }
    }

        public class cat : animal
        {
            private bool swming;

            public bool Swim
            {
                get { return swming; }
                set { swming = value; }
            }
        
        public override void an()
        {
            Console.WriteLine("Con meo an ca");
        }

        public void input()
        {
            Console.WriteLine("Nhap ten meo: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap mau sac meo: ");
            mausac = Console.ReadLine();
            Console.WriteLine("Nhap co biet boi khong? (true/false): ");
            Swim = System.Convert.ToBoolean(Console.ReadLine());
          
        }
        public void ouput()
        {
            Console.WriteLine($"Ten meo: {ten}, Mau sac: {mausac}, Boi: {Swim}");
            an();
        }
    }
        public class vidu1
        {
            
            public static void Main(string[] args)
            {
                cat meotrang = new cat();
                meotrang.input();
                meotrang.ouput();
            }

    }
    
}