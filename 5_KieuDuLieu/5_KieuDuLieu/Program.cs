//Kiểu dữ liệu:
//Là tập hợp các nhóm dữ liệu có cùng đặc tính, cách lưu trữ và thao tác xử lý trên trường dữ liệu đó.
//Là một tín hiệu để trình biên dịch nhận biết kích thước của một biến và khả năng của nó.
//Có 2 loại kiểu dữ liệu:
//    -Kiểu dữ liệu nguyên thủy: int, string, double, char, bool,...
//    -Kiểu dữ liệu do người dùng định nghĩa: Struct, Class, Enum,...

//1.Tinh tuoi
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap nam sinh cua ban: ");
//        int namSinh = int.Parse(Console.ReadLine());
//        int tuoi = 2025 - namSinh;
//        Console.WriteLine($"Tuoi cua ban la: {tuoi}");
//    }
//}

//2. Mat Khau
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Moi ban tao tai khoan: ");
//        string taiKhoan = Console.ReadLine();
//        Console.Write("Moi ban tao mat khau: ");
//        string matKhau = Console.ReadLine();

//    Start1 :
//        Console.WriteLine("Moi ban xac nhan lai tai khoan");
//        if (taiKhoan == Console.ReadLine())
//        {
//            Start2:
//            Console.WriteLine("Moi ban xac nhan lai mat khau");
//            if (matKhau == Console.ReadLine())
//            {
//                Console.WriteLine("Ban da tao tai khoan thanh cong");
//            }
//            else
//            {
//                Console.WriteLine("Mat khau khong trung khop, moi ban nhap lai: ");
//                goto Start2;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Tai khoan khong trung khop ");
//            goto Start1;
//        }
//    }
//}

//3.Tong gia tri trong mang
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//            sum += arr[i];
//        }
//        Console.WriteLine($"Tong gia tri cua mang la: {sum}");
//    }
//}

//4. Toa do trung diem

//using System;
//class Program
//{
//    struct ToaDo
//{
//    public double x;
//    public double y;
//}
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


