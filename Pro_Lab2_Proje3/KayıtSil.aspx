<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayıtSil.aspx.cs" Inherits="Pro_Lab2_Proje3.KayıtSil" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hasta Giris</title>
    <link href="tasarim.css" rel="stylesheet" />
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: lightpink;

        }
        .login-container {
            width: 500px;
            height:auto;
            margin: 0 auto;
            margin-top: 100px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f9f9f9;
        }
        .auto-style2 {
            margin-left: 4px;
        }
        </style>

</head>
<body class="login-container">
    <form id="form1" runat="server">
        <div class="center">
            <asp:Label ID="Label1" runat="server" Text="Hasta TC:" CssClass="title"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </div><div>&nbsp;</div>
        <div class="center">&nbsp;<asp:Label ID="Label2" runat="server" Text="Hasta Şifre:" CssClass="center"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="auto-style2" Width="204px"></asp:TextBox>
        &nbsp; </div><div>&nbsp;</div>
        <div class="center">
           <asp:Button ID="Btn" runat="server" Text="Üyeliğimi Sil" O CssClass="button2" Height="50px" Width="260px" OnClick="Btn_Click" />
        </div>
        <div>
            
        </div>
    </form>
</body>
</html>