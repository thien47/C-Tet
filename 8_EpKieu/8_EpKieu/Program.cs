//1. Cac kieu ep kieu
//string str = "123";
//int num = 123;

//double a = num; //epp kieu ngam dinh
//double b = (double)num; //ep kieu tuong minh
//int c = int.Parse(str); //ep kieu su dung phuong thuc ho tro san
// ep kieu nguoi dung tu dinh nghia(vd5)

//2. Kiem tra kieu du lieu
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhapp bat cu thu gi");
//        var a = Console.ReadLine();
//        if (int.TryParse(a, out int b))
//        {
//            Console.WriteLine("day la so nguyen");
//        }
//        else if (double.TryParse(a, out double c))
//        {
//            Console.WriteLine("day la so thuc");
//        }
//        else if (bool.TryParse(a, out bool d))
//        {
//            Console.WriteLine("day la kieu boolean");
//        }
//        else
//        {
//            Console.WriteLine("day la kieu chuoi");
//        }
//    }
//}


//3. Tach so tu chuoi
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap chuoi so bat ky");
//        Start:
//        string a = Console.ReadLine();
//        if (int.TryParse(a, out int b))
//        {
//            int[] Num = new int[a.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                Num[i] = b % 10;
//                b = b / 10;
//            }
//            for (int i = a.Length - 1; i >= 0; i--)
//            {
//                Console.Write(Num[i] + " ");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Vui long nhap dung kieu du lieu");
//            goto Start;
//        }
//    }
//}

//4. Ma ASCII
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap mot ky tu bat ky");
//        char a = Console.ReadKey().KeyChar;
//        int b = (int)a;
//        Console.WriteLine("\nMa ASCII cua ky tu {0} la {1}", a, b);
//    }
//}

//5. Mau sac
//using System;
//class Program
//{
//    enum Color
//    { 
//        Do = 1,
//        Cam = 2,
//        Vang = 3,
//        Luc = 4,
//        Lam = 5,
//        Cham = 6,
//        Tim = 7,

//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so tu 1 den 7");
//    Start:
//        int a = int.Parse(Console.ReadLine());
//        if (a >= 1 && a <= 7)
//        {
//            Console.WriteLine("Mau sac tuong ung la: {0}", (Color)a);
//        }
//        else
//        {
//            Console.WriteLine("Vui long nhap dung kieu du lieu");
//            goto Start;
//        }
//    }
//}
