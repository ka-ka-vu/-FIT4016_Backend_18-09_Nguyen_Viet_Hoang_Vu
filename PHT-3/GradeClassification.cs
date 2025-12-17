using System;

namespace GradeClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Nhập điểm (giả sử: 75)
            int score = 50; // Thay đổi giá trị để test khác

            string grade;

            // TODO: Phân loại điểm
            if (score >= 90 && score <= 100)
            {
                grade = "A (Xuat sac)";
            }
            else if (score >= 80)
            {
                grade = "B (Kha)";
            }
            else if (score >= 70)
            {
                grade = "C (Trung binh)";
            }
            else if (score >= 60)
            {
                grade = "D (Yeu)";
            }
            else
            {
                grade = "F (Khong dat)";
            }

            // TODO: In kết quả
            Console.WriteLine($"Diem cua ban: {score}, Xep loai: {grade}");
        }
    }
}
