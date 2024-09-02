<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaGiris.aspx.cs" Inherits="Pro_Lab2_Proje3.HastaGiris" %>

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
        .auto-style3 {
            font-size: x-small;
            text-decoration: underline;
        }
    </style>

</head>
<body class="login-container">
    <form id="form1" runat="server">
        <div class="center">
            <asp:Label ID="Label1" runat="server" Text="Hasta TC:" CssClass="title"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div><div>&nbsp;</div>
        <div class="center">&nbsp;<asp:Label ID="Label2" runat="server" Text="Hasta Şifre:" CssClass="center"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="auto-style2" Width="204px"></asp:TextBox>
        &nbsp; <span class="auto-style3"><a href="KayıtOl.aspx">Kayıt Ol</a></span></div><div>&nbsp;</div>
        <div class="center">
           <asp:Button ID="BtnGiris" runat="server" Text="Giriş Yap" O CssClass="button2" Height="50px" Width="260px" OnClick="BtnGiris_Click1" />
        </div>
        <div>
            
        </div>
    </form>
</body>
</html>