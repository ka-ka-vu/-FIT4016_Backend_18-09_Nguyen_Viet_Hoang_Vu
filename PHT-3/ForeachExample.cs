using System;

namespace ForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tạo mảng tên các bạn
            string[] friends = { "Mai", "Bình", "Chi", "Danh" };

            // TODO: In danh sách bạn bè
            int index = 1;
            foreach (string name in friends)
            {
                Console.WriteLine($"{index}. {name}");
                index++;
            }
        }
    }
}

