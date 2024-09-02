<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorBilgiGuncelle.aspx.cs" Inherits="Pro_Lab2_Proje3.DoktorBilgiGuncelle" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Doktor Bilgi Güncelle</title>
    <link href="tasarim.css" rel="stylesheet" />
    <style>
        .kenarlikli-div {
            border: 2px solid #000;
            padding: 10px;
            height: auto;
            margin-top: 26px;
            width: 464px;
            background-color: lightpink;
            margin: auto;
        }
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            margin: 0;
            height: auto; 
            width: auto;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style4 {
            text-align: center;
            font-size: x-large;
        }

        .auto-style15 {
            margin-left: 30px;
        }

        .auto-style2 {
            width: 169px;
            margin-left: 32px;
        }
        
    </style>
</head>
<body>
    <table class="auto-style1">
        <tr>
            <td>
    <div class="kenarlikli-div">
        <form id="form1" runat="server">
            <div class="auto-style4">
                <strong>Bilgilerimi Güncelle</strong></div>
            <div>&nbsp;</div>
            <div>

                <asp:Label ID="Label28" runat="server" Text="Doktor ID:"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style15" Width="201px" Enabled="False"></asp:TextBox>

            </div>
            <div>&nbsp;</div>
            <div style="width: 449px; text-align: left;">
                <asp:Label ID="Label1" runat="server" Text="Doktor Adı:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 62px" Width="251px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="width: 450px">
                <asp:Label ID="Label2" runat="server" Text="Doktor Soyadı:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Width="255px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Label ID="Label3" runat="server" Text="Uzmanlık Alanı: "></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="333px">
                </asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div style="height: auto; text-align: left;">
                <table class="auto-style1">
                    <tr>
                        <td>Hastane: 
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="360px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
          <div>&nbsp;</div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Şifre:"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 26px" Width="348px"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Button ID="Button1" runat="server" Text="Bilgilerimi Güncelle" Width="457px" Height="34px" BackColor="Black" CssClass="button2" ForeColor="White" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>

