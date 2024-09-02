<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaListele.aspx.cs" Inherits="Pro_Lab2_Proje3.HastaListele" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        
        .auto-style17 {
            border: 2px solid #000;
            padding: 10px;
            height: auto;
            margin-top: 26px;
            width: auto;
            background-color: lightpink;
            text-align: center;
        }
        
        .auto-style1 {
            width: 100%;
        }

        .auto-style28 {
            text-align: center;
            text-decoration: underline;
            width: 166px;
        }
        .auto-style20 {
            width: 12px;
            text-align: center;
        }
        
        .auto-style6 {
            width: 100px;
            text-align: center;
            text-decoration: underline;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style23 {
            text-align: center;
            text-decoration: underline;
            width: 144px;
        }
                
        .auto-style18 {
            width: 334px;
            text-align: center;
            text-decoration: underline;
        }
        .auto-style14 {
            text-align: center;
            text-decoration: underline;
            width: 45px;
        }
        .auto-style24 {
            width: 140px;
            text-align: center;
            text-decoration: underline;
        }
        .auto-style5 {
            text-align: center;
            text-decoration: underline;
        }
        .auto-style11 {
            text-align: center;
            text-decoration: underline;
            width: 141px;
        }
                
        .auto-style27 {
            width: 166px;
        }
        .auto-style7 {
            width: 100px;
            text-align: center;
        }
        .auto-style22 {
            width: 144px;
            text-align: center;
        }
        .auto-style19 {
            width: 334px;
            text-align: center;
        }
        .auto-style15 {
            width: 45px;
        }

        .auto-style25 {
            width: 140px;
            text-align: center;
        }
        
        .auto-style12 {
            width: 141px;
        }
        
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                 <div class="auto-style17","datalist-container">
                    <asp:DataList ID="DataList1" runat="server" BorderColor="Black" GridLines="Horizontal">
                        <ItemTemplate>
                            <table class="auto-style1" align="center">
                                <tr>
                                    <td class="auto-style28">HastaTC</td>
                                    <td class="auto-style20" rowspan="2">&nbsp;</td>
                                    <td class="auto-style6">Ad</td>
                                    <td class="auto-style8" rowspan="2">&nbsp;</td>
                                    <td class="auto-style23">Soyad</td>
                                    <td class="auto-style8" rowspan="2">&nbsp;</td>
                                    <td class="auto-style18">Doğum Tarihi</td>
                                    <td class="auto-style8" rowspan="2">&nbsp;</td>
                                    <td class="auto-style14">Cinsiyet</td>
                                    <td class="auto-style24">Telefon</td>
                                    <td class="auto-style8" rowspan="2">&nbsp;</td>
                                    <td class="auto-style5">Adres</td>
                                    <td class="auto-style8" rowspan="2">&nbsp;</td>
                                    <td class="auto-style11">Şifre</td>
                                </tr>
                                <tr>
                                    <td class="auto-style27">
                                        <asp:Label ID="Label26" runat="server" Text='<%# Eval("HastaTC") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label20" runat="server" Text='<%# Eval("HastaAd") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style22">
                                        <asp:Label ID="Label21" runat="server" Text='<%# Eval("HastaSoyad") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style19">
                                        <asp:Label ID="Label22" runat="server" Text='<%# Eval("DogumTarihi") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style15">
                                        <asp:Label ID="Label23" runat="server" Text='<%# Eval("HastaCinsiyet") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style25">
                                        <asp:Label ID="Label24" runat="server" Text='<%# Eval("HastaTel") %>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label25" runat="server" Text='<%# Eval("HastaAdres") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style12">
                                        <asp:Label ID="Label27" runat="server" Text='<%# Eval("HastaSifre") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    </div>
        </div>
    </form>
</body>
</html>
