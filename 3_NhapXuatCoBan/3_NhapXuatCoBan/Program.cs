//Có 5 lệnh dùng để nhập xuất đó là:
//Console.Write(); in ra màn hình mà không xuống dòng
//Console.WriteLine(); in ra màn hình và xuống dòng
//Console.Read(); đọc một ký tự từ bàn phím và trả về mã ASCII của ký tự đó
//Console.ReadLine(); đọc một chuỗi từ bàn phím
//Console.ReadKey(); đọc một ký tự từ bàn phím và trả về ký tự đó
//vd: 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhan phim:");
        Console.WriteLine("1. Xem thong tin");
        Console.WriteLine("2. Thoat");

        var keyInfo = Console.ReadKey();
        Console.WriteLine(); 

        if (keyInfo.KeyChar == '1')
        {
            Console.WriteLine("Nguyen Thien, 18 tuoi, dep trai, da bong hay");
        }
        else if (keyInfo.KeyChar == '2')
        {
            Console.WriteLine("END");
        }
        else
        {
            Console.WriteLine("Ko hop le");
        }
    }
}
