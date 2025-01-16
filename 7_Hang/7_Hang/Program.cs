//1.chu vi dien tich hinh tron
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        const double pi = 3.14;
//        Console.WriteLine("Nhap ban kinh hinh tron: ");
//        double r = double.Parse(Console.ReadLine());
//        double chuvi = 2 * r * pi;
//        double dientich = r * r * pi;
//        Console.WriteLine("Chu vi hinh tron la: " + chuvi);
//        Console.WriteLine("Dien tich hinh tron la: " + dientich);
//    }
//}

//2.doi tien
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        const double Menhgia = 24000;
//        Console.WriteLine("1. Doi tien VND -> USD");
//        Console.WriteLine("2. Doi tien USD -> VND");
//        Console.WriteLine("Nhap lua chon cua ban: ");
//        int choice = int.Parse(Console.ReadLine());

//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("Nhap so tien VND: ");
//                double VND = double.Parse(Console.ReadLine());
//                double USD = VND / Menhgia;
//                Console.WriteLine("So tien USD tuong ung la: " + USD);
//                break;
//            case 2:
//                Console.WriteLine("Nhap so tien USD: ");
//                double usd = double.Parse(Console.ReadLine());
//                double vnd = usd * Menhgia;
//                Console.WriteLine("So tien VND tuong ung la: " + vnd);
//                break;
//            default:
//                Console.WriteLine("Lua chon khong hop le");
//                break;
//        }
//    }
//}

//3.Xep loai hoc sinh
//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//class Program
//{
//    static void Main(string[] strings)
//    {
//        const double TB = 5.0;
//        const double Kha = 6.5;
//        const double Gioi = 8.0;

//        Console.WriteLine("Nhap diem mon Toan: ");
//        double Toan = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap diem mon Van: ");
//        double Van = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap diem mon Anh: ");
//        double Anh = double.Parse(Console.ReadLine());

//        double DTB = (Toan + Van + Anh) / 3;
//        Console.WriteLine("Diem trung binh cua hoc sinh la: " + Math.Round(DTB, 2));
//        if (DTB >= Gioi)
//        {
//            Console.WriteLine("Hoc sinh xep loai Gioi");
//        }
//        else if (DTB >= Kha)
//        {
//            Console.WriteLine("Hoc sinh xep loai Kha");
//        }
//        else if (DTB >= TB)
//        {
//            Console.WriteLine("Hoc sinh xep loai Trung binh");
//        }
//        else
//        {
//            Console.WriteLine("Hoc sinh xep loai Yeu");
//        }
//    }
//}


//4_Dich thang thanh chu
//using System;
//class Program
//{

//        enum Month
//    { 
//        January = 1,
//        February = 2,
//        March = 3,
//        April = 4,
//        May = 5,
//        June = 6,
//        July = 7,
//        August = 8,
//        September = 9,
//        October = 10,
//        November = 11,
//        December = 12
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap thang ban muon dich: ");
//        int month = int.Parse(Console.ReadLine());
//        switch (month)
//        {
//            case (int)Month.January:
//                Console.WriteLine((Month)1);
//                break;
//            case (int)Month.February:
//                Console.WriteLine((Month)2);
//                break;
//            case (int)Month.March:
//                Console.WriteLine((Month)3);
//                break;
//            case (int)Month.April:
//                Console.WriteLine((Month)4);
//                break;
//            case (int)Month.May:
//                Console.WriteLine((Month)5);
//                break;
//            case (int)Month.June:
//                Console.WriteLine((Month)6);
//                break;
//            case (int)Month.July:
//                Console.WriteLine((Month)7);
//                break;
//            case (int)Month.August:
//                Console.WriteLine((Month)8);
//                break;
//            case (int)Month.September:
//                Console.WriteLine((Month)9);
//                break;
//            case (int)Month.October:
//                Console.WriteLine((Month)10);
//                break;
//            case (int)Month.November:
//                Console.WriteLine((Month)11);
//                break;
//            case (int)Month.December:
//                Console.WriteLine((Month)12);
//                break;
//            default:
//                Console.WriteLine("Thang khong hop le");
//                break;
//        }
//    }
//}

//5_Tinh so ngay trong thang
//using System;
//class Program
//{
//    enum Month
//    {
//        January = 1,
//        February = 2,
//        March = 3,
//        April = 4,
//        May = 5,
//        June = 6,
//        July = 7,
//        August = 8,
//        September = 9,
//        October = 10,
//        November = 11,
//        December = 12
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap thang ban muon tinh: ");
//        int month = int.Parse(Console.ReadLine());
//        switch (month)
//        {
//            case (int)Month.January:
//                Console.WriteLine("Thang 1 co 31 ngay");
//                break;
//            case (int)Month.February:
//                Console.WriteLine("Nhap nam ban muon kiem tra: ");
//                int y = int.Parse(Console.ReadLine());
//                if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
//                {
//                    Console.WriteLine($"Thang 2 nam {y} co 29 ngay");
//                }
//                else
//                {
//                    Console.WriteLine($"thang 2 nam {y} co 28 ngay");
//                }
//                break;
//            case (int)Month.March:
//                Console.WriteLine("Thang 3 co 31 ngay");
//                break;
//            case (int)Month.April:
//                Console.WriteLine("Thang 4 co 30 ngay");
//                break;
//            case (int)Month.May:
//                Console.WriteLine("Thang 5 co 31 ngay");
//                break;
//            case (int)Month.June:
//                Console.WriteLine("Thang 6 co 30 ngay");
//                break;
//            case (int)Month.July:
//                Console.WriteLine("Thang 7 co 31 ngay");
//                break;
//            case (int)Month.August:
//                Console.WriteLine("Thang 8 co 31 ngay");
//                break;
//            case (int)Month.September:
//                Console.WriteLine("Thang 9 co 30 ngay");
//                break;
//            case (int)Month.October:
//                Console.WriteLine("Thang 10 co 31 ngay");
//                break;
//            case (int)Month.November:
//                Console.WriteLine("Thang 11 co 30 ngay");
//                break;
//            case (int)Month.December:
//                Console.WriteLine("Thang 12 co 31 ngay");
//                break;
//            default:
//                Console.WriteLine("Thang khong hop le");
//                break;
//        }
       
//    }
//}