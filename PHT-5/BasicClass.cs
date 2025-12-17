using System;

namespace BasicClass
{
    // Tạo lớp Student
    class Student
    {
        public int StudentId;
        public string Name;
        public double GPA;

        public void Display()
        {
            Console.WriteLine($"ID: {StudentId}, Name: {Name}, GPA: {GPA}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 2 đối tượng
            Student s1 = new Student();
            Student s2 = new Student();

            // Gán giá trị
            s1.StudentId = 1;
            s1.Name = "Nguyen Viet Hoang Vu";
            s1.GPA = 3.2;

            s2.StudentId = 2;
            s2.Name = "Ngo Thanh Ha";
            s2.GPA = 3.8;

            // Gọi phương thức Display()
            s1.Display();
            s2.Display();
        }
    }
}
