//1.Tam hiac vuong can
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap chieu cao tam giac: ");
//        int h = int.Parse(Console.ReadLine());
//        for ( int i = 1; i<=h; i++)
//        {
//            for (int j = 1; j<=i; j++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}


//2. Hinh chu nhat rong
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap chieu dai hinh chu nhat: ");
//        int dai = int.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap chieu rong hinh chu nhat: ");
//        int rong = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= rong; i++)
//        {
//            for (int j = 1; j <= dai; j++)
//            {
//                if (i == 1 || i == rong || j == 1 || j == dai)
//                {
//                    Console.Write("*");
//                }
//                else
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}


//3.tam giac can
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap chieu cao tam giac: ");
//        int h = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= h; i++)
//        {
//            for (int j = h - 1; j >= i; j--)
//            {
//                Console.Write(" ");
//            }
//            for (int k = 1; k <= 2 * i - 1; k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}