<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayıtOl.aspx.cs" Inherits="Pro_Lab2_Proje3.KayıtOl" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kayıt Ol</title>
    <link href="tasarim.css" rel="stylesheet" />
    <style>
        .kenarlikli-div {
            border: 2px solid #000;
            padding: 10px;
            height: auto;
            margin-top: 26px;
            width: 464px;
            background-color: lightpink;
        }
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            margin: 0;
            height: auto; 
            width: auto
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 238px;
        }

        .auto-style3 {
            margin-left: 27px;
        }

    </style>
</head>
<body>
    <table class="auto-style1">
        <tr>
            <td>
    <div class="kenarlikli-div">
        <form id="form1" runat="server">
            <div style="width: 449px; text-align: left;">
                <asp:Label ID="Label1" runat="server" Text="Hasta TC:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 62px" Width="181px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="width: 450px">
                <asp:Label ID="Label2" runat="server" Text="Hasta Ad:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 64px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Label ID="Label3" runat="server" Text="Hasta Soyad:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 31px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="height: auto; text-align: left;">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Dogum Tarihi:</td>
                        <td>
                            <input id="Text1" type="date" runat="server"/></td>
                    </tr>
                   
                </table>
                 <div>

                     &nbsp;</div>
            </div>
            <div style="text-align: left">
                <label for="ddlCinsiyet">Cinsiyet:</label>
            <select id="ddlCinsiyet" name="ddlCinsiyet" runat="server" class="auto-style3">
                <option value="Erkek">Erkek</option>
                <option value="Kadın">Kadın</option>
                <option value="Diğer">Diğer</option>
            </select><br /></div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Label ID="Label5" runat="server" Text="Telefon Numarası:" style="text-align: right"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 21px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Label ID="Label6" runat="server" Text="Adres: " style="text-align: right"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 10px" Width="303px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Şifre:"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 26px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" Width="464px" Height="34px" BackColor="Black" CssClass="button2" ForeColor="White" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>

