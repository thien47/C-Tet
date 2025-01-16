//1.Kieu du lieu
//using System;
//class Progam
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so thanh phan cua mang ");
//        int n = int.Parse(Console.ReadLine());
//        object[] arr = new object[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Nhap phan tu thu " + (i+1));
//            string item = Console.ReadLine();

//            if (int.TryParse(item, out int a))
//            {
//                arr[i] = a;
//            }
//            else if (double.TryParse(item, out double db))
//            {
//                arr[i] = db;
//            }
//            else if (bool.TryParse(item, out bool bo))
//            {
//                arr[i] = bo;
//            }
//            else
//            {
//                arr[i] = item;
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] is int)
//            {
//                Console.WriteLine("Phan tu thu " + i + 1 + " la so nguyen " + arr[i]);
//            }
//            else if (arr[i] is double)
//            {
//                Console.WriteLine("Phan tu thu " + i + 1 + " la so thuc " + arr[i]);
//            }
//            else if (arr[i] is bool)
//            {
//                Console.WriteLine("Phan tu thu " + i + 1 + " la gia tri logic " + arr[i]);
//            }
//            else
//            {
//                Console.WriteLine("Phan tu thu " + i + 1 + " la chuoi " + arr[i]);
//            }
//        }
//    }
//}

//2.Tong thanh phan cua mang so nguyen
//using System;
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so thanh phan cua mang ");
//        int n = int.Parse(Console.ReadLine());
//        var arr = new int[n];
//        int sum = 0;

//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Nhap phan tu thu " + (i + 1));
//            arr[i] = int.Parse(Console.ReadLine());
//            sum += arr[i];
//        }
//        Console.WriteLine("Tong cac phan tu cua mang la " + sum);
//    }
//}

//Tinh tong phan tu cua mang bat ky
//using System;
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so thanh phan cua mang ");
//        int n = int.Parse(Console.ReadLine());
//        object[] arr = new object[n];
//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Nhap phan tu thu " + (i + 1));
//            string str = Console.ReadLine();
//            if (int.TryParse(str, out int a))
//            {
//                arr[i] = a;
//            }
//            else
//            {
//                arr[i] = str;
//            }
//        }
//        foreach (var item in arr)
//        {
//            if (item is int)
//            {
//                sum += (int)item;
//            }
//        }
//        Console.WriteLine("Tong cac phan tu so nguyen cua mang la " + sum);
//    }
//}