//1.Tim so lon nhat trong mang
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so phan tu");
//        int n = int.Parse(Console.ReadLine());

//        int[] nums = new int[n];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            nums[i] = int.Parse(Console.ReadLine());
//        }

//        int max = nums[0];
//        for (int i = 1;i < nums.Length; i++)
//        {
//            while (nums[i] > max)
//            {
//                max = nums[i];
//            }
//        }
//        Console.WriteLine($"So lon nhat cua mang la {max}");
//    }
//}


//2. Tinh giai thua
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so muon tinh giai thua");
//        int n = int.Parse(Console.ReadLine());
//        int factorial = 1;
//        Console.Write($"{n} giai thua = ");

//        while (n > 0)
//        {
//            factorial *= n;
//            n--;
//        }
//        Console.WriteLine(factorial);
//    }
//}

//3. Dao nguoc so nguyen
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so muon dao nguoc: ");
//            int n = int.Parse(Console.ReadLine());
//        int u = 0;

//        while(n>0)
//        {
//            u = u*10 + (n % 10);
//            n = n / 10;
//        }
//        Console.WriteLine($"So dao nguoc la {u}");
//    }
//}