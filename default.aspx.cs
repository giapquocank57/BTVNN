using System;
using System.Collections.Generic;
using DLL;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_v1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy điểm thi và điểm trên lớp từ TextBox
                double examScore = Convert.ToDouble(TextBox1.Text);
                double classScore = Convert.ToDouble(TextBox2.Text);

                // Kiểm tra nếu điểm hợp lệ (từ 0 đến 10)
                if (examScore >= 0 && examScore <= 10 && classScore >= 0 && classScore <= 10)
                {
                    // Tính điểm học kỳ
                    double finalScore = examScore * 0.6 + classScore * 0.4;

                    // Hiển thị kết quả lên Label
                    Label1.Text = $"Điểm học kỳ của bạn là: {finalScore}";
                }
                else
                {
                    Label1.Text = "Điểm phải nằm trong khoảng từ 0 đến 10.";
                }
            }
            catch (FormatException)
            {
                Label1.Text = "Vui lòng nhập đúng định dạng số cho điểm thi và điểm trên lớp.";
            }
        }
    }
}