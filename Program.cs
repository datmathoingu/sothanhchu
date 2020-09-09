using System;
using System.Text;
namespace sothanhchu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, c, d;

            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập số bất kì (0-999): ");
                n = int.Parse(Console.ReadLine());
                t = n / 100;
                c = (n % 100) / 10;
                d = (n % 100) % 10;
                switch (t)
                {
                    case 1:
                        Console.Write("một trăm ");
                        break;
                    case 2:
                        Console.Write("hai trăm ");
                        break;
                    case 3:
                        Console.Write("ba trăm ");
                        break;
                    case 4:
                        Console.Write("bốn trăm ");
                        break;
                    case 5:
                        Console.Write("năm trăm ");
                        break;
                    case 6:
                        Console.Write("sáu trăm ");
                        break;
                    case 7:
                        Console.Write("bảy trăm ");
                        break;
                    case 8:
                        Console.Write("tám trăm ");
                        break;
                    case 9:
                        Console.Write("chín trăm ");
                        break;
                }
                switch (c)
                {
                    case 0:
                        if (d == 0) Console.Write("Không ");
                        else
                            Console.Write(" lẻ ");
                        break;
                    case 1:
                        Console.Write("mười");
                        break;
                    case 2: 
                        Console.Write("hai mươi ");
                        break;
                    case 3:
                        Console.Write("ba mươi ");
                        break;
                    case 4:
                        Console.Write("bốn mươi ");
                        break;
                    case 5:
                        Console.Write("năm mươi ");
                        break;
                    case 6:
                        Console.Write("sáu mươi ");
                        break;
                    case 7:
                        Console.Write("bảy mươi ");
                        break;
                    case 8:
                        Console.Write("tám mươi ");
                        break;
                    case 9:
                        Console.Write("chín mươi ");
                        break;
                }
                switch (d)
                {
                    case 1:
                        Console.Write("một");
                        break;
                    case 2:
                        Console.Write("hai");
                        break;
                    case 3:
                        Console.Write("ba");
                        break;
                    case 4:
                        Console.Write("bốn");
                        break;
                    case 5:
                        Console.Write("năm");
                        break;
                    case 6:
                        Console.Write("sáu");
                        break;
                    case 7:
                        Console.Write("bảy");
                        break;
                    case 8:
                        Console.Write("tám");
                        break;
                    case 9:
                        Console.Write("chín");
                        break;
                }
            }
        }
    }
}
