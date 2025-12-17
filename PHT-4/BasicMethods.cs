using System;

namespace BasicMethods
{
    class Program
    {
        // Phương thức tính tổng 2 số
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Phương thức tính tích 2 số
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            // Gọi phương thức Add và in kết quả
            int sum = Add(3, 5);
            Console.WriteLine("Tong = " + sum);

            // Gọi phương thức Multiply và in kết quả
            double product = Multiply(2.5, 4);
            Console.WriteLine("Tich = " + product);
        }
    }
}
