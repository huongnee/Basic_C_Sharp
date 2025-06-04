using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    using System;
    using System.Collections.Generic;

    class SinhVien
    {
        public string HoTen;
        public int Tuoi;
        public float DiemTB;
        public bool DangHoc;
    }

    class Program
    {
        static void Main()
        {
            // Tạo danh sách sinh viên
            List<SinhVien> danhSach = new List<SinhVien>()
        {
            new SinhVien { HoTen = "Nguyễn Văn A", Tuoi = 20, DiemTB = 7.5f, DangHoc = true },
            new SinhVien { HoTen = "Trần Thị B", Tuoi = 21, DiemTB = 8.2f, DangHoc = true },
            new SinhVien { HoTen = "Lê Văn C", Tuoi = 22, DiemTB = 6.8f, DangHoc = false }
        };

            // In tiêu đề bảng
            Console.WriteLine("{0,-20} {1,-5} {2,-10} {3}", "Họ Tên", "Tuổi", "Điểm TB", "Đang học");

            // In từng dòng sinh viên
            foreach (var sv in danhSach)
            {
                Console.WriteLine("{0,-20} {1,-5} {2,-10} {3}", sv.HoTen, sv.Tuoi, sv.DiemTB, sv.DangHoc ? "Có" : "Không");
            }
        }
    }

}
//C# - cấu trúc chương trình
/*
Một chương trình C# cơ bản gồm các thành phần chính sau:
    1- using: Khai báo các namespace cần thiết để sử dụng các lớp, phương thức có sẵn.
    2- namespace: Nhóm các lớp liên quan lại với nhau, giúp tổ chức mã nguồn tốt hơn.
    3- class: Mọi mã lệnh C# đều nằm trong một hoặc nhiều lớp.
    4- Main(): Là phương thức điểm bắt đầu của chương trình, nơi chương trình bắt đầu thực thi.
       Các câu lệnh: Được viết bên trong phương thức Main() hoặc các phương thức khác.
*/
//C# - Cú pháp cơ bản
/*
1- Phân biệt chữ hoa/thường: C# phân biệt chữ hoa và chữ thường (Age khác age).
2- Kết thúc câu lệnh bằng dấu chấm phẩy (;).
3- Khối lệnh dùng dấu ngoặc nhọn {} để nhóm các câu lệnh.
4- Khai báo biến: Cần khai báo kiểu dữ liệu trước tên biến.
Ghi chú (comment): Dùng // cho ghi chú một dòng, /* ... cho nhiều dòng.
Định danh: Tên biến, lớp, phương thức nên đặt có ý nghĩa, tuân thủ quy tắc đặt tên (PascalCase cho lớp, camelCase cho biến)
*/

//C# - Kiểu dữ liệu
/*
 1. object
    - object là kiểu cơ sở của mọi kiểu dữ liệu trong C# (bao gồm cả kiểu giá trị và kiểu tham chiếu).
    - Có thể lưu trữ bất kỳ giá trị nào.
    - Khi muốn sử dụng giá trị đúng kiểu ban đầu, cần ép kiểu (cast) về kiểu cụ thể.
    - Kiểu của biến object được kiểm tra tại runtime.
    - Example
        object obj1 = "Hello";
        object obj2 = 123;
        object obj3 = true;

        // Muốn sử dụng như int phải ép kiểu:
        int number = (int)obj2;
2. var
    - var dùng để khai báo biến với kiểu ngầm định (implicit typing).
    - Kiểu dữ liệu của biến sẽ được xác định bởi giá trị gán đầu tiên, và là kiểu tĩnh (static) tại thời điểm biên dịch (compile-time).
    - Bắt buộc phải khởi tạo giá trị khi khai báo.
    - Chỉ dùng được trong thân phương thức (không dùng làm kiểu trả về hoặc thuộc tính lớp).
    - Example
        var x = 10;          // int
        var y = "Hello";     // string
        var z = 3.14;        // double

        Không hợp lệ:
        var a;        // Lỗi: phải khởi tạo giá trị
        var b = null; // Lỗi: không xác định được kiểu

3. dynamic
 /*
    - dynamic là kiểu dữ liệu động, được xác định tại runtime (thời gian chạy).
    - Biến dynamic có thể thay đổi kiểu dữ liệu trong quá trình chạy chương trình.
    - Các lỗi liên quan đến kiểu chỉ được phát hiện khi chạy chương trình, không phải khi biên dịch.
    - Thường dùng khi làm việc với dữ liệu không xác định trước kiểu, ví dụ: dữ liệu từ COM, reflection, hoặc các API động.
    - Example
        dynamic d = "Hello";
        Console.WriteLine(d); // string
    
        d = 123;
        Console.WriteLine(d); // int

        // Nếu gọi phương thức không tồn tại trên d, lỗi chỉ xuất hiện khi chạy chương trình
 --> Tóm lại:
object: Dùng khi cần lưu trữ nhiều loại dữ liệu, nhưng phải ép kiểu khi sử dụng.
var: Dùng khi muốn khai báo biến ngắn gọn, nhưng kiểu dữ liệu vẫn xác định tại biên dịch.
dynamic: Dùng khi cần xử lý dữ liệu động, kiểu chỉ xác định khi chạy, phù hợp cho các trường hợp đặc biệt như làm việc với COM, reflection, hoặc dữ liệu không xác định trước
object: Kiểu cơ sở, lưu được mọi loại giá trị, phải ép kiểu khi dùng.
var: Khai báo biến ngắn gọn, kiểu xác định ngay khi biên dịch, không đổi được kiểu sau đó.
dynamic: Kiểu động, xác định tại runtime, có thể thay đổi kiểu trong quá trình chạy, phát hiện lỗi kiểu khi chạy chương trình.
 */
// c# chuyển đổi kiểu
/*
Chuyển đổi kiểu là việc chuyển một giá trị từ kiểu dữ liệu này sang kiểu dữ liệu khác.
    - Implicit (ngầm định): Không mất dữ liệu (ví dụ: int → double)
    - Explicit (tường minh): Có thể mất dữ liệu, cần ép kiểu (cast)
    - Example
        // Implicit conversion
        int a = 10;
        double b = a; // tự động chuyển int sang double
        // Explicit conversion
        double x = 9.7;
        int y = (int)x; // ép kiểu từ double sang int, kết quả là 9
 */
// c# biến (variables)
/*
    - Biến là nơi lưu trữ dữ liệu trong chương trình
    - Example
        Bool kt = true
 */
// C# - Hằng (Constant/Literal)
/*
  - Hằng số là giá trị không thể thay đổi khi khai báo
  - Example:  const double PI = 3.14159;
 */

// c# Toán tử(operators)
/*

    Toán tử số học:	+ - * / %	
    Gán:	= += -=	
    So sánh:	== != > < >= <=	
    Logic:	`&&  
    - Example
        int a = 5, b = 3;
        bool ketQua = (a > b) && (a != 0); // true

 */
//  C# Câu lệnh điều kiện(if else, switch) - conditional statements
/*
    - Example If-else
        int diem = 85;
        if (diem >= 90)
            Console.WriteLine("Giỏi");
        else if (diem >= 70)
            Console.WriteLine("Khá");
        else
            Console.WriteLine("Trung bình");
    - Example Switch
        int lc = Convert.ToInt32(Console.Readline())
        Switch(lc)
        {
            Case 1: 
                Console.writeLine("giỏi");
                break;
            Case 2: 
                Console.writeLine("khá");
                break;
            default: 
                Console.writeLine("Ok");
                break;
        };

*/
// C# Vòng lặp(Loop)
/*
    - Dùng để lặp đi lặp lại 1 khối lệnh
    1:For
        for(int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i)
        }
    2:While
    int n = 100 , m = 0
    While(m<=n)
    {
        Console.writeLine(m)
        m++
    }
`   3:Do-while
    int n = 100 , m = 0
    Do
    {
        Console.writeLine(m)
        m++
    }While(m<n);
*/
// C# Tính đóng gói(Encapsulation)
/*
    - Khái niệm: là kỹ thuật gói gọn dữ liệu và phương thức liên quan vào một đơn vị (class), 
      đồng thời kiểm soát quyền truy cập thông qua các phạm vi như private, public 
    - Mục đích: Bảo vệ dữ liệu khỏi truy cập trực tiếp từ bên ngoài
       ,chỉ cho phép thao tác thông qua các phương thức công khai (public methods/properties)
    - Cơ chế: Sử dụng access modifiers (phạm vi truy cập) để quy định mức độ hiển thị của thành phần trong class:
                private: Chỉ truy cập được trong class chứa nó.
                public: Truy cập tự do từ bất kỳ đâu.
                protected: Truy cập trong class và class kế thừa
    - Example:
        
 */
// C# - Phương thức (Method)
/*
   - Phương thức là khối lệnh thực hiện một tác vụ cụ thể.
 */
// C# - Nullable (Kiểu có thể null)
/*
  - Trong C#, các kiểu dữ liệu giá trị như int, double, bool, DateTime... không thể nhận giá trị null theo mặc định.
  - Tuy nhiên, trong thực tế, đôi khi bạn muốn cho phép một biến không có giá trị ban đầu
    (ví dụ: chưa biết tuổi, chưa xác định ngày sinh...).
  - Example 
        int? tuoi = null;   // OK
        int tuoi = null;    // ❌ Sai: int mặc định không cho null
 */
//C# - Mảng (Array)
/*
    Mảng là một tập hợp các giá trị cùng kiểu dữ liệu, được lưu trữ liên tiếp trong bộ nhớ.
    Mỗi phần tử trong mảng có chỉ số (index) bắt đầu từ 0.
    - Cách khai báo + khởi tạo mảng:  int[] mangSo = new int[5]
    - Mảng 2 chiều
        Mảng 2 chiều là một bảng gồm nhiều hàng và cột (giống như ma trận).
        Cú pháp khai báo: <kiểu dữ liệu>[,] tênMảng = new <kiểu dữ liệu>[sốHàng, sốCột];
        VD: int[,] maTran = new int[2, 3]; // 2 hàng, 3 cột
            maTran[0, 0] = 1;
            maTran[0, 1] = 2;
            maTran[0, 2] = 3;
            maTran[1, 0] = 4;
            maTran[1, 1] = 5;
            maTran[1, 2] = 6;
        VD1: 
            int[,] maTran = {
                                {1, 2, 3},
                                {4, 5, 6}
                            };
        --> Console.WriteLine(maTran[1, 2]); // In ra phần tử hàng 1, cột 2 → kết quả: 6
        VD2: Duyệt mảng 2 chiều bằng vòng lặp
                for (int i = 0; i < maTran.GetLength(0); i++) // số hàng
                {
                    for (int j = 0; j < maTran.GetLength(1); j++) // số cột
                    {
                        Console.Write(maTran[i, j] + " ");
                    }
                    Console.WriteLine(); // Xuống dòng sau mỗi hàng
                }
    - Tính năng nâng cao với mảng 1 chiều
        Array.Sort(arr) – Sắp xếp mảng tăng dần
            VD:
                int[] so = { 5, 1, 4, 2, 3 };
                Array.Sort(so); // sắp xếp tăng dần

                foreach (int i in so)
                {
                    Console.Write(i + " "); // Kết quả: 1 2 3 4 5
                }

        Array.Reverse(arr) – Đảo ngược mảng
            VD:
                int[] so = { 1, 2, 3, 4, 5 };
                Array.Reverse(so); // đảo ngược

                foreach (int i in so)
                {
                    Console.Write(i + " "); // Kết quả: 5 4 3 2 1
                }

        arr.Length – Lấy độ dài (số phần tử trong mảng)
            VD:
                int[] so = { 10, 20, 30, 40 };
                Console.WriteLine("Số phần tử trong mảng là: " + so.Length); // Kết quả: 4
    
    - Tính năng nâng cao với mảng 2 chiều
        maTran.GetLength(0) → số hàng
        maTran.GetLength(1) → số cột
        maTran.Length → tổng số phần tử (hàng × cột)
    - Example
        
 */
//C# - Chuỗi (String)
/*
    - Chuỗi (string) là tập hợp các ký tự Unicode, được đặt trong dấu nháy kép " ".
    - Kiểu dữ liệu string trong C# là một lớp (class) đặc biệt trong .NET.
    - 1 số thao tác phổ biến với chuỗi
        Length – Lấy độ dài chuỗi
        ToUpper() – Viết hoa tất cả
        ToLower() – Viết thường tất cả
        Contains() – Kiểm tra chứa chuỗi con
        IndexOf() – Vị trí xuất hiện chuỗi con
        Substring(start, length) – Cắt chuỗi con
        Replace(old, new) – Thay thế chuỗi
        Split() – Tách chuỗi
        Trim() – Loại bỏ khoảng trắng đầu & cuối chuỗi
     - Lưu ý nối chuỗi
        Cách 1: Dùng + --> string ho = "Nguyen";string ten = "Hoa";string hoTen = ho + " " + ten;
        Cách 2: Cách 2: Dùng String.Concat() --> string fullName = String.Concat("Nguyen", " ", "Hoa"); Console.WriteLine(fullName);  // Nguyen Hoa
     - Lưu ý Chèn chuỗi (String Interpolation) - dùng $ trước dấu " để chèn biến trực tiếp trong chuỗi.
        VD:string ten = "Hoa";int tuoi = 21; Console.WriteLine($"Chào {ten}, bạn {tuoi} tuổi.");  // Chào Hoa, bạn 21 tuổi.
     - So sánh chuỗi
        string a = "abc";
        string b = "ABC";
        Console.WriteLine(a == b);                      // false
        Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true
    -   Lưu ý chuỗi rỗng và null:  "" → chuỗi rỗng còn null → không có giá trị
        VD: string a = "";
            string b = null;
            Console.WriteLine(string.IsNullOrEmpty(a));  // true
            Console.WriteLine(string.IsNullOrEmpty(b));  // true

 */
//C# - Structure
/*
 
  - Structure (struct) trong C# là một kiểu dữ liệu do người dùng định nghĩa (user-defined type),
  gần giống với class, nhưng có một số điểm khác biệt. Nó thường dùng để đại diện cho những đối tượng nhỏ,
  đơn giản, như một tọa độ, màu sắc, ngày tháng, v.v.
  - Struct (cấu trúc) là một kiểu dữ liệu do bạn tự định nghĩa, giống như một cái “hộp” chứa nhiều giá trị khác nhau (biến),
    nhưng thuộc cùng một đối tượng.
    👉 Bạn có thể hiểu struct giống như class đơn giản, nhưng dùng cho dữ liệu nhẹ, 
        không cần kế thừa và không cần xử lý phức tạp.
   - Cấu trúc của 1 struct
       struct TenStruct
        {
            // Các biến (fields)
            // Constructor (hàm tạo)
            // Các phương thức (methods)
        }
        

 */
//C# - Enum
/*
    - enum (viết tắt của enumeration) là một kiểu dữ liệu đặc biệt trong C# để định nghĩa tập hợp các hằng số có tên.
    - Enum giống như bảng danh sách các lựa chọn cố định.
    - Bạn tạo ra một tập hợp các tên gọi có ý nghĩa, mỗi tên tương ứng với một con số phía sau 
    (mà bạn có thể dùng trong chương trình).
 */