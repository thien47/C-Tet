//1.May tinh
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap so thu nhat: ");
//        double a = int.Parse(Console.ReadLine());
//        Console.Write("Nhap so thu hai: ");
//        double b = int.Parse(Console.ReadLine());
//        Console.Write("Nhap phep toan: ");
//        char pheptoan = Console.ReadKey().KeyChar;
//        Console.WriteLine();
//        switch (pheptoan)
//        {
//            case '+':
//                Console.WriteLine($"{a} + {b} = {a + b}");
//                break;
//            case '-':
//                Console.WriteLine($"{a} - {b} = {a - b}");
//                break;
//            case '*':
//                Console.WriteLine($"{a} * {b} = {a * b}");
//                break;
//            case '/':
//                if (b == 0)
//                {
//                    Console.WriteLine("Khong the chia cho 0");
//                }
//                else
//                {
//                    Console.WriteLine($"{a} / {b} = {a / b:F2}");
//                }
//                break;
//            default:
//                Console.WriteLine("Phep toan khong hop le");
//                break;
//        }
//    }
//}


//2.Tinh tuoi
//using System;
//using System.Text;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write("Nhap nam sinh: ");
//        int year = int.Parse(Console.ReadLine());
//        int Can = year % 10;
//        int Chi = year % 12;

//        switch (Can)
//        {
//            case 0:
//                Console.Write("Canh");
//                break;
//            case 1:
//                Console.Write("Tân");
//                break;
//            case 2:
//                Console.Write("Nhâm");
//                break;
//            case 3:
//                Console.Write("Quý");
//                break;
//            case 4:
//                Console.Write("Giáp");
//                break;
//            case 5:
//                Console.Write("Ất");
//                break;
//            case 6:
//                Console.Write("Bính");
//                break;
//            case 7:
//                Console.Write("Đinh");
//                break;
//            case 8:
//                Console.Write("Mậu");
//                break;
//            case 9:
//                Console.Write("Kỷ");
//                break;
//        }

//        switch (Chi)
//        {
//            case 0:
//                Console.WriteLine(" Thân");
//                break;
//            case 1:
//                Console.WriteLine(" Dậu");
//                break;
//            case 2:
//                Console.WriteLine(" Tuất");
//                break;
//            case 3:
//                Console.WriteLine(" Hợi");
//                break;
//            case 4:
//                Console.WriteLine(" Tý");
//                break;
//            case 5:
//                Console.WriteLine(" Sửu");
//                break;
//            case 6:
//                Console.WriteLine(" Dần");
//                break;
//            case 7:
//                Console.WriteLine(" Mão");
//                break;
//            case 8:
//                Console.WriteLine(" Thìn");
//                break;
//            case 9:
//                Console.WriteLine(" Tỵ");
//                break;
//            case 10:
//                Console.WriteLine(" Ngọ");
//                break;
//            case 11:
//                Console.WriteLine(" Mùi");
//                break;
//        }
//    }
//}

//3. ATM
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int sodu = 500000;
//        Console.WriteLine("Welcom to DaDenBank");
//        Console.WriteLine("1. rut tien");
//        Console.WriteLine("2. chuyen khoan");
//        Console.WriteLine("3. kiem tra so du");
//        Console.WriteLine("4. Thoat");
//        Console.Write("Chon chuc nang(1. 2. 3. 4.): ");
//    Start:
//        int chucnang = int.Parse(Console.ReadLine());
//        switch (chucnang)
//        {
//            case 1:
//                Console.Write("Nhap so tien can rut: ");
//                int sotienrut = int.Parse(Console.ReadLine());
//                if (sotienrut > sodu)
//                {
//                    Console.WriteLine("So du khong du");
//                    goto case 1;
//                }
//                else
//                {
//                    sodu -= sotienrut;
//                    Console.WriteLine($"Rut tien thanh cong. So du con lai: {sodu}");
//                    goto case 4;
//                }
//                break;
//            case 2:
//                Console.Write("Nhap so tai khoan: ");
//                string sotaikhoan = Console.ReadLine();
//                Console.Write("Nhap so tien can chuyen: ");
//                int sotienchuyen = int.Parse(Console.ReadLine());
//                if (sotienchuyen > sodu)
//                {
//                    Console.WriteLine("So du khong du");
//                    goto case 2;
//                }
//                else
//                {
//                    sodu -= sotienchuyen;
//                    Console.WriteLine($"Chuyen tien thanh cong. So du con lai: {sodu}");
//                    goto Start;
//                }
//                break;
//            case 3:
//                Console.WriteLine($"So du cua ban la: {sodu}");
//                goto case 4;
//                break;
//            case 4:
//                Console.WriteLine("Cam on ban vi da den");
//                break;
//            default:
//                Console.WriteLine("Chuc nang khong hop le");
//                break;
//        }
//    }
//}