using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
/*
Serializable – Cho phép lớp được ghi ra file (serialization)
✔️ Ý nghĩa:
Cho phép chuyển đối tượng thành dạng nhị phân hoặc chuỗi để lưu file hoặc truyền qua mạng.
 */
namespace Day1.Advance.attribute
{
    [Serializable]
    public class Student
    {
        public string Name;
        public int Age;
    }
    public class pt_Serializable
    {
        public static void Main(string[] args)
        {
                // Tạo một đối tượng Student với Name là "Huong" và Age là 20
                Student s = new Student { Name = "Huong", Age = 20 };

                // Ghi đối tượng ra file

                // Tạo một FileStream để ghi dữ liệu vào file @"E:\Downloads\ikk.txt"
                // FileMode.Create: nếu file đã tồn tại thì ghi đè, nếu chưa có thì tạo mới
                FileStream fs = new FileStream(@"E:\Downloads\ikk.txt", FileMode.Create);
                //trước vd là đường dẫn student.dat
                /*
                 * 👉 Tạo đối tượng BinaryFormatter để:
                       Chuyển đối tượng thành dạng nhị phân (binary).
                       Dùng để serialize (ghi) hoặc deserialize (đọc) đối tượng.
                 */
                BinaryFormatter bf = new BinaryFormatter();
                /*
                👉 Ghi đối tượng s xuống file thông qua luồng fs.
                    Dữ liệu của đối tượng sẽ được chuyển sang dạng nhị phân và ghi vào "student.dat".
                 */
                bf.Serialize(fs, s);
                // Đóng FileStream để giải phóng tài nguyên,👉 Đóng file sau khi ghi xong. Giải phóng bộ nhớ, tránh lỗi.
                fs.Close();
                // Thông báo ra màn hình là ghi file thành công
                Console.WriteLine("Ghi file thành công!");
            
        }
    }
}
