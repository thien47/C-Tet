//1_Tinh so ngay trong thang
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


//Tuoi am
//using System;
//class Program
//{
//    enum Can
//    {
//        Canh,
//        Tan,
//        Nham,
//        Quy,
//        Giap,
//        At,
//        Binh,
//        Dinh,
//        Mau,
//        Ky
//    }

//    enum Chi
//    {
//        Than,
//        Dau,
//        Tuat,
//        Hoi,
//        Tys,
//        Suu,
//        Dan,
//        Mao,
//        Thin,
//        Tyj,
//        Ngo,
//        Mui
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap nam sinhh cua ban: ");
//        int tuoi = int.Parse(Console.ReadLine());
//        int can = tuoi % 10;
//        int chi = tuoi % 12;

//        switch (can)
//        {
//            case 0:
//                Console.Write((Can)0 + " ");
//                break;
//            case 1:
//                Console.Write((Can)1 + " ");
//                break;
//            case 2:
//                Console.Write((Can)2 + " ");
//                break;
//            case 3:
//                Console.Write((Can)3 + " ");
//                break;
//            case 4:
//                Console.Write((Can)4 + " ");
//                break;
//            case 5:
//                Console.Write((Can)5 + " ");
//                break;
//            case 6:
//                Console.Write((Can)6 + " ");
//                break;
//            case 7:
//                Console.Write((Can)7 + " ");
//                break;
//            case 8:
//                Console.Write((Can)8 + " ");
//                break;
//            case 9:
//                Console.Write((Can)9 + " ");
//                break;
//        }

//        switch (chi)
//        {
//            case 0:
//                Console.WriteLine((Chi)0);
//                break;
//            case 1:
//                Console.WriteLine((Chi)1);
//                break;
//            case 2:
//                Console.WriteLine((Chi)2);
//                break;
//            case 3:
//                Console.WriteLine((Chi)3);
//                break;
//            case 4:
//                Console.WriteLine((Chi)4);
//                break;
//            case 5:
//                Console.WriteLine((Chi)5);
//                break;
//            case 6:
//                Console.WriteLine((Chi)6);
//                break;
//            case 7:
//                Console.WriteLine((Chi)7);
//                break;
//            case 8:
//                Console.WriteLine((Chi)8);
//                break;
//            case 9:
//                Console.WriteLine((Chi)9);
//                break;
//            case 10:
//                Console.WriteLine((Chi)10);
//                break;
//            case 11:
//                Console.WriteLine((Chi)11);
//                break;
//        }
//    }
//}


//3.Dich thang thanh chu
using System;
class Program
{

    enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap thang ban muon dich: ");
        int month = int.Parse(Console.ReadLine());
        switch (month)
        {
            case (int)Month.January:
                Console.WriteLine((Month)1);
                break;
            case (int)Month.February:
                Console.WriteLine((Month)2);
                break;
            case (int)Month.March:
                Console.WriteLine((Month)3);
                break;
            case (int)Month.April:
                Console.WriteLine((Month)4);
                break;
            case (int)Month.May:
                Console.WriteLine((Month)5);
                break;
            case (int)Month.June:
                Console.WriteLine((Month)6);
                break;
            case (int)Month.July:
                Console.WriteLine((Month)7);
                break;
            case (int)Month.August:
                Console.WriteLine((Month)8);
                break;
            case (int)Month.September:
                Console.WriteLine((Month)9);
                break;
            case (int)Month.October:
                Console.WriteLine((Month)10);
                break;
            case (int)Month.November:
                Console.WriteLine((Month)11);
                break;
            case (int)Month.December:
                Console.WriteLine((Month)12);
                break;
            default:
                Console.WriteLine("Thang khong hop le");
                break;
        }
    }
}