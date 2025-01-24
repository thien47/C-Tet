//1.Xoa phan tu cua mang
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so phan tu: ");
//        int n = int.Parse(Console.ReadLine());
//        string[] arr = new string[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Nhap phan tu thu {i + 1}");
//            arr[i] = Console.ReadLine();
//        }

//        Console.WriteLine("Mang sau khi loc phan tu la: ");
//        delete(arr);
//    }

//    static void delete(string[] a)
//    {
//        int count = 0;
//        int i = 0;
//        foreach (string item in a)
//        {
//            if (int.TryParse(item, out int num))
//            { count++; }
//        }
//        int[] Num = new int[count];

//        foreach (string item in a)
//        {
//            if (int.TryParse(item, out int num))
//            {
//                Num[i] = num;
//                i++;
//            }
//        }

//        foreach (int item in Num)
//        {
//            Console.Write(item + " ");
//        }
//    }
//}


//2.Tim so 
//using System;
//class Programs
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so thanh phan cua mang: ");
//        int[] Mang = new int[int.Parse(Console.ReadLine())];

//        for (int i = 0; i < Mang.Length; i++)
//        {
//            Console.WriteLine($"Nhap phan tu thu {i + 1}");
//            Mang[i] = int.Parse(Console.ReadLine());
//        }

//        int b = 0;
//        foreach (int a in Mang)
//        {
//            if (a % 2 == 0)
//                b++;
//        }
//        Console.WriteLine($"Co {b} so chan va {Mang.Length - b} so le");

//    }
//}


//3.Tim gia tri lon thu hai
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so thanh phan cua mang: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int Max = 0, max = 0;
        foreach (int item in arr)
        {
            if (item > Max)
            { Max = item; }
        }

        foreach(int item in arr)
        {
            if(item < Max && item > max)
            { max = item; }
        }

        Console.WriteLine("Gia tri lon thu hai cua mang la " + max);
    }

}