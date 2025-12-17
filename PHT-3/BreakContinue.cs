using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: In các số lẻ từ 1 đến 20 (dùng continue)
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Bỏ qua số chẵn
                }

                Console.Write(i + " ");
            }

            Console.WriteLine("\n"); // Xuống dòng

            // TODO: Tìm số 7 trong mảng
            int[] numbers = { 2, 5, 7, 1, 9, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 7)
                {
                    Console.WriteLine($"Tim thay so 7 tai vi tri {i}");
                    break; // Dừng khi gặp số 7 đầu tiên
                }
            }
        }
    }
}
