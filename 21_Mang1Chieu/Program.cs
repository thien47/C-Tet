//1.Tim cap so 
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so thanh phan cua mang: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Nhap so muon tim cap tong: ");
//        int sum = int.Parse(Console.ReadLine());

//        int count = 0;

//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = i + 1; j < n; j++)
//            {
//                if (arr[i] + arr[j] == sum)
//                {
//                    Console.WriteLine($"Co cap so thu {i+1} va {j+1} co tong bang {sum} ");
//                    count++;
//                }
//            }
//        }
//        if (count == 0)
//        {
//            Console.WriteLine("Khong co cap so nao co tong la {0}", sum);
//        }
//    }
//}


//2. kiem tra mang con
//using System;
//class Program
//{
//    public static void Test(int[] ARR, int[] arr)
//    {
//        int count = 0;
//        for (int i = 0; i <= ARR.Length - arr.Length; i++)
//        {
//            if (ARR[i] == arr[count] && count <arr.Length)
//            {
//                do
//                {
//                    i++;
//                    count++;
//                }
//                while (count < arr.Length && ARR[i] == arr[count]);
//            }
//            if (count < arr.Length && count > 0) { count = 0; }
//        }
//        if (count == arr.Length)
//        {
//            Console.WriteLine("Day la mang con cua mang me ");
//        }
//        else
//        {
//            Console.WriteLine("Day khong phai la mang con cua mang me");
//        }

//    }
//static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so thanh phan cua mang me: ");
//        int N = int.Parse(Console.ReadLine());

//        Console.WriteLine("Nhap so thanh phan cua mang can kiem tra: ");
//        int n = int.Parse(Console.ReadLine());

//        if (n < N)
//        {
//            int[] ARR = new int[N];
//            int[] arr = new int[n];
//            for (int i = 0; i < N; i++)
//            {
//                Console.Write($"Nhap phan tu thu {i + 1} cua mang me: ");
//                ARR[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("***********************************");

//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"Nhap phan tu thu {j + 1} cua mang can kiem tra: ");
//                arr[j] = int.Parse(Console.ReadLine());
//            }

//            Test(ARR, arr);
//        }
//        else
//        {
//            Console.WriteLine("So phan tu cua mang con phai be hon mang me!");
//            return;
//        }

//    }
//}