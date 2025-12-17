using System;

namespace MethodOverloading
{
    class Program
    {
        // Phiên bản 1: Print(int x) - in một số
        static void Print(int x)
        {
            Console.WriteLine("So nguyen: " + x);
        }

        // Phiên bản 2: Print(string text) - in một chuỗi
        static void Print(string text)
        {
            Console.WriteLine("Chuoi: " + text);
        }

        // Phiên bản 1: Add(int a, int b) - cộng 2 số nguyên
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Phiên bản 2: Add(double a, double b) - cộng 2 số thực
        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Gọi Print với int
            Print(10);

            // Gọi Print với string
            Print("Hello C#");

            // Gọi Add(int, int)
            int sumInt = Add(3, 5);
            Console.WriteLine("Tong int = " + sumInt);

            // Gọi Add(double, double)
            double sumDouble = Add(2.5, 4.2);
            Console.WriteLine("Tong double = " + sumDouble);
        }
    }
}
