//1.sap xep mang 
//using System;
//class Program
//{
//    public static int[] ascending(int[] a)
//    {
//        Array.Sort(a);
//        return a;
//    }

//    public static int[] decreasing(int[] a)
//    {
//        Array.Sort(a);
//        Array.Reverse(a);
//        return a;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so ptu cua mang");
//        int n = int.Parse(Console.ReadLine());
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
//            a[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("1.Mang tang dan\n" +
//            "2.Mang giam dan\n" +
//            "Nhap lua chon(1/2).");
//        char c = Console.ReadKey().KeyChar;
//        if (c == '1')
//        {
//            ascending(a);
//        }
//        else { decreasing(a); }
//        Console.Write("Mang sau khi sap xep: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(a[i] + " ");
//        }
//    }
//}


//2.tim phan tu thu n trong day fibonacci
//using System;
//class Program
//{
//    public static int[] find(int[] a)
//    {
//        a[0] = 0;
//        a[1] = 1;
//        for (int i = 2; i < a.Length; i++)
//        {
//            a[i] = a[i - 1] + a[i - 2];
//        }
//        return a;

//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap phan tu thu n trong day fibonacci");
//        int n = int.Parse(Console.ReadLine())+1;
//        int[] F = new int[n];

//        if (n > 1)
//        {
//            find(F);
//            Console.WriteLine($"phan tu thu {n - 1} trong day fibonacci la {F[n - 1]}");
//        }
//        else { Console.WriteLine($"Phan tu dau tien trong day fibonacci la {F[0]}"); }
//    }
//}


//3.So Hoan Hao 
//using System;
//class Program
//{
//    public static bool isperfect(int a)
//    {
//        int sum = 0;
//        for (int i = 1; i <= a / 2; i++)
//        {
//            if (a % i == 0)
//            { sum += i; }
//        }
//        if (sum == a) { return true; }
//        else { return false; }
//    }

//    public static void Main(string[] args)
//    {
//        Console.Write("Nhap so can kiem tra: ");
//        int n = int.Parse(Console.ReadLine());

//        if (isperfect(n))
//        {
//            Console.WriteLine("Day la so hoan hao");
//        }
//        else
//        {
//            Console.WriteLine("Day khog phai so hoan hao");
//        }

//    }
//}