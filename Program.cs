using System;
using System.Collections.Generic;
using System.Text;
using DLL;
namespace CS_testdll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đối tượng từ DLL
            Class1 calculator = new Class1();

            // Nhập điểm thi
            Console.Write("Nhập điểm thi (0 - 10): ");
            double examScore = Convert.ToDouble(Console.ReadLine());

            // Nhập điểm trên lớp
            Console.Write("Nhập điểm trên lớp (0 - 10): ");
            double classScore = Convert.ToDouble(Console.ReadLine());

            try
            {
                // Sử dụng DLL để tính điểm học kỳ
                double finalScore = calculator.CalculateFinalScore(examScore, classScore);

                // In ra kết quả
                Console.WriteLine($"Điểm học kỳ là: {finalScore}");
            }
            catch (ArgumentException ex)
            {
                // Bắt lỗi nếu điểm không hợp lệ
                Console.WriteLine(ex.Message);
            }
        }
    }
}
