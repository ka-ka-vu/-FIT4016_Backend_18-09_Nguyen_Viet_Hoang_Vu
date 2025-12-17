using System;

namespace Recursion
{
    class Program
    {
        // Phương thức tính giai thừa (đệ quy)
        static long Factorial(int n)
        {
            // Điều kiện dừng
            if (n == 0)
            {
                return 1;
            }

            // Gọi đệ quy
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            // Tính 5!
            long result5 = Factorial(5);
            Console.WriteLine("5! = " + result5);

            // Tính 10!
            long result10 = Factorial(10);
            Console.WriteLine("10! = " + result10);
        }
    }
}
