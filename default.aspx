<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_v1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính điểm Học kỳ</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            padding: 20px;
        }

        form {
            background-color: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            margin: auto;
        }

        div, p {
            margin-bottom: 15px;
        }

        input[type=text] {
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 16px;
        }

        label {
            font-size: 14px;
            color: #555;
        }

        button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
        }

        button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Nhập điểm thi" Width="292px"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Nhập điểm trên lớp" Width="292px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Kết quả sẽ hiện tại đây"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Tính điểm học kỳ" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
