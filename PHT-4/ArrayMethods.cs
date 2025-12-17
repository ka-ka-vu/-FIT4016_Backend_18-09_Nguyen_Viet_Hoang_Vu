using System;

namespace ArrayMethods
{
    class Program
    {
        // Phương thức tính tổng các phần tử trong mảng
        static int SumArray(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        // Phương thức tìm số lớn nhất trong mảng
        static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] scores = { 85, 92, 78, 90, 88 };

            // Gọi SumArray và in kết quả
            int total = SumArray(scores);
            Console.WriteLine("Tong cac phan tu = " + total);

            // Gọi FindMax và in kết quả
            int maxScore = FindMax(scores);
            Console.WriteLine("So lon nhat = " + maxScore);
        }
    }
}
