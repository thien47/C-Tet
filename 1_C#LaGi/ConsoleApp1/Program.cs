using System;
using System.Text;

class program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("1. C# la gi?");
        Console.WriteLine("2. Dac Diem cua C#/");
        Console.WriteLine("3. Uu/Nhuoc diem cua C#/");
        Console.WriteLine("Nhap yeu cau (1, 2, 3) ");

        int yeucau = int.Parse(Console.ReadLine());

        if (yeucau == 1)
        {
            Console.WriteLine("La một ngôn ngữ thuần hướng đối tượng.\n " +
                "Được xây dựng dựa trên nền tảng của 2 ngôn ngữ lập trình mạnh nhất đó là C++ và Java."); 


        }
        else if (yeucau == 2)
        {
            Console.WriteLine(
            " C# có bộ Garbage Collector sẽ tự động thu gom vùng nhớ khi không còn sử dụng nữa.\n" +
                " Tích hợp mạnh mẽ với .NET: Cho phép sử dụng thư viện phong phú của .NET Framework hoặc .NET Core. \n " +
                "Hỗ trợ LINQ và Lambda: Cung cấp các cú pháp mạnh mẽ cho việc truy vấn dữ liệu và xử lý luồng dữ liệu.");

        }
        else if (yeucau == 3)
        {
            Console.WriteLine("Học dễ dàng: Cú pháp tương tự như Java và C++, phù hợp cho người mới học lập trình.\n" +
                "Cộng đồng lớn: Có nhiều tài liệu, diễn đàn hỗ trợ và nguồn học tập phong phú.\n" +
                "Gắn bó với Microsoft: Mặc dù C# đã đa nền tảng, nhưng nó vẫn được phát triển mạnh mẽ nhất trong hệ sinh thái của Microsoft.\n" +
                "Yêu cầu cao hơn về tài nguyên: Các ứng dụng .NET Framework thường nặng hơn so với các ứng dụng viết bằng một số ngôn ngữ khác.");
        }
    }
}
       
