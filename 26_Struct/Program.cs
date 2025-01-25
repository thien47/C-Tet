//4. Toa do trung diem

//using System;
//class Program
//{
//    struct ToaDo
//    {
//        public double x;
//        public double y;
//    }
//    static void NhapToaDo(out ToaDo A)
//    {
//        Console.Write("Nhap toa do x: ");
//        A.x = double.Parse(Console.ReadLine());
//        Console.Write("Nhap toa do y: ");
//        A.y = double.Parse(Console.ReadLine());
//    }


//    static void Main()
//    {
//        ToaDo A = new ToaDo();
//        ToaDo B = new ToaDo();

//        Console.WriteLine("Nhap toa do diem A: ");
//        NhapToaDo(out A);
//        Console.WriteLine("Nhap toa do diem B: ");
//        NhapToaDo(out B);
//        Console.WriteLine("*************************");

//        ToaDo C = new ToaDo();
//        C.x = (A.x + B.x) / 2;
//        C.y = (A.y + B.y) / 2;
//        Console.WriteLine($"Toa do trung diem la: ({C.x}, {C.y})");
//    }
//}


//2.Thong tin sinh vien
//using System;
//class Program
//{
//    struct SinhVien
//    {
//        public string name;
//        public string MaSo;
//        public double DiemHP1;
//        public double DiemHP2;
//        public double DiemHP3;
//    }

//    static void NhapThongTin(out SinhVien SV)
//    {
//        Console.WriteLine("Nhap ten sinh vien: ");
//        SV.name = Console.ReadLine();
//        Console.WriteLine("Nhap ma so sinh vien: ");
//        SV.MaSo = Console.ReadLine();
//        Console.WriteLine("Nhap diem hp1: ");
//        SV.DiemHP1 = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap diem hp2: ");
//        SV.DiemHP2 = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap diem hp3: ");
//        SV.DiemHP3 = double.Parse(Console.ReadLine());
//    }

//    static void XepLoai(SinhVien SV)
//    {
//        Console.WriteLine($"Sinh vien: {SV.name}");
//        Console.WriteLine($"Ma so: {SV.MaSo}");
//        double DTB = (SV.DiemHP1 + SV.DiemHP2 + SV.DiemHP3) / 3;
//        if (DTB >= 8) { Console.WriteLine("Xep loai: Gioi"); }
//        else if (6.5 <= DTB && DTB < 8) { Console.WriteLine("Xep loai: Kha"); }
//        else { Console.WriteLine("Xep loai: Yeu"); }
//    }

//    static void Main(string[] args)
//    {
//        SinhVien SV = new SinhVien();
//        NhapThongTin(out SV);
//        XepLoai(SV);
//    }
//}


//Bill
using System;
class Program
{
    struct Bill
    {
        public string[] Mon;
        public int[] GiaThanh;
        public Bill(int size)
        {
            Mon = new string[size];
            GiaThanh = new int[size];
        }
    }
    static void NhapDonHang(ref Bill bill,int size)
    {
        for (int i = 0; i < size ; i++)
        {
            Console.WriteLine("Nhap ten mon ");
            bill.Mon[i] = Console.ReadLine();
            Console.WriteLine("Gia Thanh: ");
            bill.GiaThanh[i] = int.Parse(Console.ReadLine());
        }
    }
    static void XuatDonHang(Bill bill, int size)
    {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(bill.Mon[i] + "     "+ bill.GiaThanh[i]);
            sum += bill.GiaThanh[i];
        }
        Console.WriteLine("******************");
        Console.WriteLine($"Tong so tien can tra la {sum}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Don hang co bao nhieu mon: ");
        int n = int.Parse(Console.ReadLine());
        Bill bill1 = new Bill(n);
        NhapDonHang(ref bill1, n);
        Console.WriteLine("******************");
        XuatDonHang(bill1 , n);
    }
}