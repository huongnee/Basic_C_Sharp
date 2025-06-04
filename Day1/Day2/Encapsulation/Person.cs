using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2.Encapsulation
{
    public class Person
    {
        //private String name { get; set; }
       
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private string _name; // Trường private

        // Phương thức public để thiết lập giá trị
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                _name = name;
        }

        // Phương thức public để lấy giá trị
        public string GetName()
        {
            return _name;
        }
    }
}
