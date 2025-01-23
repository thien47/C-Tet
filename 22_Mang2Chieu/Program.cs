//1. Dinh thuc ma tran bac 2/3
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ban muon tinh dinh thuc ma tran bac may (2/3)");
//        int n = int.Parse(Console.ReadLine());
//        int[,] arr = new int[n, n];

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"Nhap phan tu thu [{i},{j}] :");
//                arr[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        if (2 == n)
//        {
//            det2(arr);
//        }
//        if (3 == n)
//        {
//            det3(arr);
//        }
//    }

//        public static void det2(int[,] a)
//    {
//        int det2 = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
//        Console.WriteLine("Din thuc cua ma tran bang {0}", det2);
//    }

//    public static void det3(int[,] a)
//    {
//        int det3 = a[0, 0] * (a[1, 1] * a[2, 2] - a[1, 2] * a[2, 1]) 
//            - a[0, 1]*(a[1, 0] * a[2, 2] - a[1, 2] * a[2, 0]) 
//            + a[0, 2]*(a[1, 0] * a[2, 1] - a[1, 1] * a[2, 0]);
//        Console.WriteLine("Din thuc cua ma tran bang {0}", det3);
//    }

//}


//2.Hang co tong lon nhat
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so hang:");
//        int h = int.Parse(Console.ReadLine());
//        Console.WriteLine("nhap so cot: ");
//        int c = int.Parse(Console.ReadLine());
//        int[,] arr = new int[h, c];

//        for (int i = 0; i < h; i++)
//        {
//            for (int j = 0; j < c; j++)
//            {
//                Console.Write($"Nhap phan tu thu [{i+1},{j+1}]:");
//                arr[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        hangmax(arr);
//    }

//    static void hangmax(int[,] a)
//    {
//        int max = 0;
//        int sum = 0;
//        int hangmax = 0;

//        for (int i = 0; i < a.GetLength(0); i++)
//        {
//            sum = 0;
//            for (int j = 0; j < a.GetLength(1); j++)
//            {
//                sum += a[i, j];
//                if (sum > max)
//                {
//                    max = sum;
//                    hangmax = i + 1;
//                }
//            }
//        }
//        Console.WriteLine($"hang co tong lon nhat la hang {hangmax} voi tong = {max}");
//    }
//}


//3 songuyento
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hang");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so cot");
        int c = int.Parse(Console.ReadLine());
        int[,] table = new int[h, c];

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write($"Nhap phan tu thu [{i + 1},{j + 1}]: ");
                table[i, j] = int.Parse(Console.ReadLine());
            }
        }
        songuyento(table);
    }

    static void songuyento(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {

                if (a[i,j]>1)
                {
                    int cout = 0;
                    for(int k =1; k <= a[i,j]; k++)
                    {
                        if (a[i,j] % k == 0)
                        {
                            cout++;
                        }
                    }
                    if (cout == 2)
                    {
                        Console.WriteLine($"Phan tu [{i + 1}, {j + 1}] la so nguyen to");
                    }
                    
                }
            }
        }
    }
}