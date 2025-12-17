using System;

namespace StudentManagementSystem
{
    // =======================
    // TODO 6.1: LỚP STUDENT
    // =======================
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public Student(string id, string name, double score)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("StudentId khong duoc rong");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ten khong duoc rong");

            if (score < 0 || score > 10)
                throw new ArgumentException("Diem phai tu 0 den 10");

            StudentId = id;
            Name = name;
            Score = score;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {StudentId} | Ten: {Name} | Diem: {Score}");
        }
    }

    // ============================
    // TODO 6.2: STUDENT MANAGER
    // ============================
    public class StudentManager
    {
        private Student[] students = new Student[50];
        private int count = 0;

        public void AddStudent(string id, string name, double score)
        {
            if (count >= 50)
                throw new Exception("Danh sach sinh vien da day");

            if (FindStudentById(id) != null)
                throw new Exception("ID sinh vien da ton tai");

            students[count++] = new Student(id, name, score);
            Console.WriteLine(" Them sinh vien thanh cong");
        }

        public void RemoveStudent(string id)
        {
            for (int i = 0; i < count; i++)
            {
                if (students[i].StudentId == id)
                {
                    for (int j = i; j < count - 1; j++)
                        students[j] = students[j + 1];

                    students[count - 1] = null;
                    count--;
                    Console.WriteLine(" Da xoa sinh vien");
                    return;
                }
            }
            Console.WriteLine(" Khong tim thay sinh vien");
        }

        public void UpdateScore(string id, double newScore)
        {
            Student s = FindStudentById(id);
            if (s == null)
                throw new Exception("Khong tim thay sinh vien");

            if (newScore < 0 || newScore > 10)
                throw new Exception("Diem phai tu 0 den 10");

            s.Score = newScore;
            Console.WriteLine(" Cap nhat diem thanh cong");
        }

        public double GetAverageScore()
        {
            if (count == 0) return 0;

            double sum = 0;
            for (int i = 0; i < count; i++)
                sum += students[i].Score;

            return sum / count;
        }

        public double GetMaxScore()
        {
            if (count == 0) return 0;

            double max = students[0].Score;
            for (int i = 1; i < count; i++)
                if (students[i].Score > max)
                    max = students[i].Score;

            return max;
        }

        public Student FindStudentById(string id)
        {
            for (int i = 0; i < count; i++)
                if (students[i].StudentId == id)
                    return students[i];

            return null;
        }

        public void DisplayAllStudents()
        {
            if (count == 0)
            {
                Console.WriteLine("Danh sach trong");
                return;
            }

            for (int i = 0; i < count; i++)
                students[i].Display();
        }
    }

    // ============================
    // TODO 6.3: MAIN PROGRAM
    // ============================
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. XOa sinh vien");
                Console.WriteLine("3. Cp nhat diem");
                Console.WriteLine("4. In danh dach");
                Console.WriteLine("5. Tinh diem trung binh");
                Console.WriteLine("6. Tim diem cao nhat");
                Console.WriteLine("7. Tim sinh vien theo ID");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==========================");
                Console.Write("Chon: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("ID: ");
                            string id = Console.ReadLine();

                            Console.Write("Ten: ");
                            string name = Console.ReadLine();

                            Console.Write("Diem: ");
                            double score = double.Parse(Console.ReadLine());

                            manager.AddStudent(id, name, score);
                            break;

                        case 2:
                            Console.Write("Nhap ID can xoa: ");
                            manager.RemoveStudent(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Nhap ID: ");
                            string uid = Console.ReadLine();

                            Console.Write("Diem moi: ");
                            double newScore = double.Parse(Console.ReadLine());

                            manager.UpdateScore(uid, newScore);
                            break;

                        case 4:
                            manager.DisplayAllStudents();
                            break;

                        case 5:
                            Console.WriteLine("Diem trung binh: " + manager.GetAverageScore());
                            break;

                        case 6:
                            Console.WriteLine("Diem cao nhat: " + manager.GetMaxScore());
                            break;

                        case 7:
                            Console.Write("Nhap ID: ");
                            Student s = manager.FindStudentById(Console.ReadLine());

                            if (s != null)
                                s.Display();
                            else
                                Console.WriteLine("Khong tim thay sinh vien");
                            break;

                        case 0:
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Lua chon khong hop le");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Loi: " + ex.Message);
                }
            }
        }
    }
}
