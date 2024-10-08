﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorSil.aspx.cs" Inherits="Pro_Lab2_Proje3.DoktorSil" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Doktor Sil</title>
    <link href="tasarim.css" rel="stylesheet" />
    <style>
        .kenarlikli-div {
            border: 2px solid #000;
            padding: 10px;
            height: auto;
            margin-top: 26px;
            width: auto;
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

        .datalist-container {
    border: 1px solid #ccc; /* Kenarlık rengi ve kalınlığı */
    padding: 10px; /* İçeriğin kenarlardan uzaklığı */
}

        .auto-style6 {
            width: 100px;
            text-align: center;
            text-decoration: underline;
        }
        .auto-style7 {
            width: 100px;
            text-align: center;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            text-decoration: underline;
            width: 371px;
        }
        .auto-style11 {
            text-align: center;
            text-decoration: underline;
            width: 141px;
        }
        
        .auto-style12 {
            width: 141px;
        }
        
        .auto-style16 {
            width: 1285px;
            text-align: center;
        }
        
        .auto-style17 {
            border: 2px solid #000;
            padding: 10px;
            height: auto;
            margin-top: 26px;
            width: auto;
            background-color: lightpink;
            text-align: center;
        }
        
        .auto-style13 {
            text-align: center;
        }
        
        .auto-style19 {
            text-align: center;
            width: 136px;
        }
        .auto-style20 {
            text-align: center;
            text-decoration: underline;
            width: 136px;
        }
        .auto-style22 {
            text-align: center;
            width: 224px;
        }
        .auto-style23 {
            text-align: center;
            text-decoration: underline;
            width: 224px;
        }
        .auto-style25 {
            width: 36px;
            text-align: center;
        }
        .auto-style26 {
            text-align: center;
            width: 2px;
        }
        .auto-style27 {
            text-align: center;
            width: 371px;
        }
        
    </style>
</head>
<body>
    <table class="auto-style1">
        <tr>
            <td>
    <div class="kenarlikli-div">
        <form id="form1" runat="server">
            <div class="auto-style16">
                <asp:Label ID="Label1" runat="server" Text="Doktor ID:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 62px" Width="181px"></asp:TextBox>
            </div>
            
            <div>&nbsp;</div>
            <div class="auto-style8">
                <asp:Button ID="Button1" runat="server" Text="Doktor Sil" Width="464px" Height="34px" BackColor="Black" CssClass="button2" ForeColor="White" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
            </td>
        </tr>
        <tr>
            <td>
                 <div class="auto-style17","datalist-container">
                <div class="auto-style17","datalist-container">
                    <asp:DataList ID="DataList1" runat="server" Width="1237px">
                        <ItemTemplate>
                            <table class="auto-style1" align="center">
                                <tr>
                                    <td class="auto-style6">DoktorID</td>
                                    <td class="auto-style25" rowspan="2">&nbsp;</td>
                                    <td class="auto-style6">Ad</td>
                                    <td class="auto-style13" rowspan="2">&nbsp;</td>
                                    <td class="auto-style20">Soyad</td>
                                    <td class="auto-style13" rowspan="2">&nbsp;</td>
                                    <td class="auto-style23">Uzmanlı Alanı</td>
                                    <td class="auto-style26" rowspan="2">&nbsp;</td>
                                    <td class="auto-style5">Hastane</td>
                                    <td class="auto-style13" rowspan="2">&nbsp;</td>
                                    <td class="auto-style11">Şifre</td>
                                </tr>
                                <tr>
                                    <td class="auto-style13">
                                        <asp:Label ID="Label19" runat="server" Text='<%# Eval("DoktorID") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label20" runat="server" Text='<%# Eval("DoktorAd") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style19">
                                        <asp:Label ID="Label21" runat="server" Text='<%# Eval("DoktorSoyad") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style22">
                                        <asp:Label ID="Label24" runat="server" Text='<%# Eval("Brans") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style27">
                                        <asp:Label ID="Label25" runat="server" Text='<%# Eval("HastaneAdı") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style12">
                                        <asp:Label ID="Label27" runat="server" Text='<%# Eval("DoktorSifre") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
                    </div>
                </td>
        </tr>
    </table>
</body>
</html>