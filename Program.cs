using System;
using System.Collections.Generic;
using System.Text;

namespace tinhdiemhkcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập điểm thi
            Console.Write("Nhập điểm thi (0 - 10): ");
            double examScore = Convert.ToDouble(Console.ReadLine());

            // Nhập điểm trên lớp
            Console.Write("Nhập điểm trên lớp (0 - 10): ");
            double classScore = Convert.ToDouble(Console.ReadLine());

            // Kiểm tra xem điểm có hợp lệ không (phải trong khoảng từ 0 đến 10)
            if (examScore >= 0 && examScore <= 10 && classScore >= 0 && classScore <= 10)
            {
                // Tính điểm học kỳ
                double finalScore = examScore * 0.6 + classScore * 0.4;

                // In ra kết quả
                Console.WriteLine($"Điểm học kỳ của bạn là: {finalScore}");
            }
            else
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
            }
            Console.ReadKey();
        }
    }
}
