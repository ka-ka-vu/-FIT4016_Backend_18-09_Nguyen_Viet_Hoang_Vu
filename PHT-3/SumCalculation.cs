using System;

namespace SumCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tính tổng các số từ 1 đến 100
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            // TODO: In kết quả
            Console.WriteLine($"Tong cac so tu 1 den 100: {sum}");
        }
    }
}
