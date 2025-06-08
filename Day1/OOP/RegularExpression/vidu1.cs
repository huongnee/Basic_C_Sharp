using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day1.OOP.RegularExpression
{
    public class vidu1
    {
       public static void Main()
        {
            string text = "Số 1, số 2, số 345, và số 6789";
            string pattern = @"\d+";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("Tìm thấy số: " + match.Value);
            }
        }
    }
}
