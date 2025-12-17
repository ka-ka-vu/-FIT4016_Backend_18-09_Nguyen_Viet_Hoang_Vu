using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = 50; // số bí mật

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Lan doan {i}: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess < secret)
                {
                    Console.WriteLine("Qua thap\n");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Qua cao\n");
                }
                else
                {
                    Console.WriteLine("Chinh xac!");
                    break; // Thoát khi đoán đúng
                }
            }
        }
    }
}
