using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.OOP.Exception
{
    public class vidu1

    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhập 1 số bất kỳ ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập 1 số bất kỳ ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Thương của 2 số là " + (number1 / number2));

            }
            catch(DivideByZeroException e) 
            {
                Console.WriteLine("Không được phép chia cho 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lỗi định dạng.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Lỗi khác: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Khối finally luôn được chạy.");
            }





        }
    }
}
