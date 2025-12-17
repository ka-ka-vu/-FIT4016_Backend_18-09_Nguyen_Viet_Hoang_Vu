using System;

namespace VoidMethods
{
    class Program
    {
        // Phương thức in hộp trang trí
        static void PrintBox(string text)
        {
            int length = text.Length + 4;

            Console.WriteLine(new string('*', length));
            Console.WriteLine("* " + text + " *");
            Console.WriteLine(new string('*', length));
        }

        static void Main(string[] args)
        {
            // Gọi phương thức PrintBox với các giá trị khác nhau
            PrintBox("Hello");
            PrintBox("C#");
            PrintBox("Void Method");
        }
    }
}
