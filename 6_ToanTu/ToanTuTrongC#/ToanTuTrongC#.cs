using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

//1.hoan doi so
//class program
//{
//    static void Main(string[] args)
//    {
//        int a = int.Parse(Console.ReadLine());
//        int b = int.Parse(Console.ReadLine());
//        Console.WriteLine($"truoc khi doi: a = {a}, b = {b}");

//        int c = a;
//        a = b;
//        b = c;
//        Console.WriteLine($"sau khi doi: a = {a}, b = {b}");
//    }
//}


//2.so chan so le
//class Program
//{
//    static void Main(string[] args)
//    {
//        int a = int.Parse(Console.ReadLine());
//        if (a % 2 == 0)
//        {
//            Console.WriteLine("So chan");
//        }
//        else
//        {
//            Console.WriteLine("So le");
//        }
//    }
//}


//3.kiem tra so nguyen to
//class Program
//{
//    static void Main(string[] args)
//    {
//        int a = int.Parse(Console.ReadLine());
//        if (a < 2)
//        {
//            Console.WriteLine("ko p so nguyen to");
//        }
//        else
//        {
//            for (int i = 2; i <= a; i++)
//            {
//                if (a == i)
//                {
//                    Console.WriteLine("a la so nguyen to");
//                    break;
//                }
//                else if (a % i == 0)
//                {
//                    Console.WriteLine("ko p so nguyen to");
//                    break;
//                }

//            }

//        }
//    }
//}


//4.kiem tra nam nhuan
//class program
//{
//    static void Main(string[] args)
//    {
//        int a = int.Parse(Console.ReadLine());
//        if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
//        {
//            Console.WriteLine($"{a} la nam nhuan");
//        }
//        else
//        {
//            Console.WriteLine($"{a} ko la nam nhuan");
//        }
//    }
//}


//5.chuoi so doi xung
//class program
//{
//    static void Main(string[] args)
//    {
//    Start:
//        string a = Console.ReadLine();
//        string b = new string(a.Reverse().ToArray());

//        if (int.TryParse(a, out int result))
//        {
//            if (a == b)
//            {
//                Console.WriteLine("chuoi doi xung");
//            }
//            else
//            {
//                Console.WriteLine("chuoi ko doi xung");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Nhap sai kieu du lieu, vui long nhap lai");
//            goto Start;
//        }
//    }
//}
