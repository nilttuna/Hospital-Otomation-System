<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaBilgisi.aspx.cs" Inherits="Pro_Lab2_Proje3.HastaBilgisi" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hasta Bilgileri</title>
    <style type="text/css">
        .auto-style1 {
            height: auto;
            width: auto;
            margin-right: 0px;
            margin-top: 45px;
            background-color: lightpink;
        }
        .auto-style2 {
            width: 97%;
        }
        .auto-style3 {
            text-align: center;
        }

        .auto-style4 {
            text-decoration: underline;
            font-size: xx-large;
            text-align: center;
            background-color: lightpink;
        }
        .auto-style5 {
            margin-left: 486px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">


            <strong>Hasta Bilgileri</strong></div>
        <div>
            <div class="auto-style1">
                <asp:DataList ID="DataList1" runat="server" CssClass="auto-style5" Height="243px" Width="430px">
                    <ItemTemplate>
                        <table class="auto-style2">
                            <tr>
                                <td>TC:</td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("HastaTC") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Ad:</td>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("HastaAd") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Soyad:</td>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("HastaSoyad") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Doğum Tarihi:</td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("DogumTarihi") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Cinsiyet:</td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("HastaCinsiyet") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Telefon:</td>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("HastaTel") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Adres:</td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("HastaAdres") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Şifre:</td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("HastaSifre") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </form>
    <p class="auto-style3">
        &nbsp;</p>
</body>
</html>

