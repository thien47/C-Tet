//1.Doan so ngau nhien tu 1 den 100
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//    Start:
//        Random random = new Random();
//        int number = random.Next(1, 101);
//        Console.WriteLine("Doan so ngau nhien tu 1 den 100");
//    guess:
//        Console.Write("Nhap so ban doan: ");
//        int guess = int.Parse(Console.ReadLine());

//        if (guess > number)
//        {
//            Console.WriteLine("So ban doan lon hon so ngau nhien");
//            goto guess;
//        }
//        else if (guess < number)
//        {
//            Console.WriteLine("So ban doan nho hon so ngau nhien");
//            goto guess;
//        }
//        else
//        {
//            Console.WriteLine("Chuc mung! Ban da doan dung");
//            Console.WriteLine("Ban co muon choi tiep khong? (Y/N)");
//            string answer = Console.ReadLine();
//            if (answer == "Y" || answer == "y")
//            {
//                goto Start;
//            }
//        }
//    }
//}


//2.kiem tra so nguyen to
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so can kiem tra: ");
//        int number = int.Parse(Console.ReadLine());
//        if (number < 2)
//        {
//            Console.WriteLine("Khong phai so nguyen to");
//        }
//        else
//        {
//            for (int i = 2; i <= number / 2; i++)
//            {
//                if (number % i == 0)
//                {
//                    Console.WriteLine("Khong phai so nguyen to");
//                    goto end;
//                }
//            }
//            Console.WriteLine("La so nguyen to");
//        end:
//            Console.ReadKey();
//        }
//    }
//}

//3.May tinh 
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so thu nhat: ");
//        double number1 = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap so thu hai: ");
//        double number2 = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap phep tinh (+, -, *, /): ");
//        char operation = Console.ReadKey().KeyChar;
//        Console.WriteLine();

//        if (operation == '+')
//        {
//            goto plus;
//        }
//        else if (operation == '-')
//        {
//            goto minus;
//        }
//        else if (operation == '*')
//        {
//            goto time;
//        }
//        else if (operation == '/')
//        {
//            goto dividedBy;
//        }
//        else
//        {
//            Console.WriteLine("Phep tinh khong hop le");
//        }

//    plus:
//        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
//        goto end;
//        minus:
//        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
//        goto end;
//        time:
//        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
//        goto end;
//        dividedBy:
//        if (number2 == 0)
//        {
//            Console.WriteLine("Khong the chia cho 0");
//        }
//        else
//        {
//            Console.WriteLine($"{number1} / {number2} = {number1 / number2:F2}");
//        }
//        end:
//        Console.ReadKey();
//    }
//}