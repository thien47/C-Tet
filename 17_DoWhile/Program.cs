//1.BingGo
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int COT = 5, cot=0, dong = 0, DONG = 5;
//        do
//        {
//            cot = 0;
//            while (cot < COT)
//            {
//                Random random = new Random();
//                int number = random.Next(1, 100);
//                Console.Write($"{number} ");
//                cot++;
//            }
//            Console.WriteLine();
//            dong++;
//        }while (dong<DONG);
//    }
//}


//2.Bang cuu chuong
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int m = 1, M = 10;
//        Console.WriteLine("Bang cuu chuong so: ");
//        int t = int.Parse(Console.ReadLine());

//        do
//        {
//            Console.WriteLine($"{t} * {m} = {t * m}");
//            m++;
//        }while( m <= M );
//    }
//}


//3.Nhap mat khau dung
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int password = 191206;
//        do
//        {
//            Console.WriteLine("Hay nhap mat khau dung");
//            int input = int.Parse(Console.ReadLine());

//            if (password == input)
//            {
//                Console.WriteLine("Mat khau dung");
//                break;
//            }
//            else
//            { Console.WriteLine("Mat khau sai!"); }
//        } while (true);
//    }
//}