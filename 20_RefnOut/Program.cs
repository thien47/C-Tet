//ref: Thay doi du lieu
//out: khoi tao du lieu


//1.Kiem tra kieu du lieu
//using System;
//class Program
//{
//    static void Test(string a)
//    {
//        if (int.TryParse(a, out int i))
//        {
//            Console.WriteLine("Day la kieu so nguyen");
//        }
//        else if(double.TryParse(a, out double d))
//        {
//            Console.WriteLine("Day la kieu so thuc");
//        }
//        else if (bool.TryParse(a, out bool b))
//        {
//            Console.WriteLine("Day la kieu so logic");
//        }
//        else
//        {
//            Console.WriteLine("Day la kieu chuoi");
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap bat ky");
//        var data = Console.ReadLine();
//        Test(data);
//    }
//}


//2.Tong cac chu so trong 1 so
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so can tinh");
//        int n;
//        if (int.TryParse(Console.ReadLine(), out n))
//            {
//            int sum = 0;
//            while (n > 0)
//            {
//                sum += n % 10;
//                n /= 10;
//            }
//            Console.WriteLine("Tong cac chu so bang {0}", sum);
//        }
//        else { Console.WriteLine("Vui long nhap dung kieu du lieu"); }
//    }
//}


//Dao nguoc chuoi
//using System;
//class Program
//{
//    static void Reverse(ref string a)
//    {
//        a = new string(a.Reverse().ToArray());
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap chuoi bat ky");
//        string arr = Console.ReadLine();

//        Reverse(ref arr);
//        Console.WriteLine("Chuoi sau khi dao nguoc: {0}", arr);
//    }
//}
