<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaGuncelle.aspx.cs" Inherits="Pro_Lab2_Proje3.HastaGuncelle" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Hasta Güncelle</title>
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

        .auto-style17 {
            border: 2px solid #000;
            padding: 10px;
            height: auto;
            margin-top: 26px;
            width: auto;
            background-color: lightpink;
            text-align: center;
        }
        
        .datalist-container {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(200px, 1fr)); /* Otomatik genişlik ayarı, 200 pikselden az olmamak üzere, eşit genişlikte sütunlar */
    gap: 10px; /* Sütunlar arası boşluk */
}
        
        .auto-style28 {
            width: 100px;
            text-decoration: underline;
            text-align: left;
            height: 31px;
        }
        
        </style>
</head>
<body>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
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
                        <td >Dogum Tarihi:</td>
                        <td>
                            <input id="Text1" type="date" runat="server"/></td>
                    </tr>
                </table>
            </div>
            <div>

                &nbsp;</div>
            <div style="text-align: left">
                <label for="ddlCinsiyet">Cinsiyet:</label>
            <select id="ddlCinsiyet" name="ddlCinsiyet" runat="server">
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
    <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style16" Width="206px"></asp:TextBox>
</div>
            <div>&nbsp;</div>
            <div style="text-align: left">
                <asp:Button ID="Button1" runat="server" Text="Hasta Güncelle" Width="464px" Height="34px" BackColor="Black" CssClass="button2" ForeColor="White" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
            </td>
        </tr>
        <tr>
            <td>
                 <div class="auto-style17","datalist-container">
                    <asp:DataList ID="DataList1" runat="server" BorderColor="Black" GridLines="Both">
                        <ItemTemplate>
                            <table align="center">
                                <tr>
                                    <td class="auto-style28">HastaTC</td>
                                    <td class="auto-style28" rowspan="2"></td>
                                    <td class="auto-style28">Ad</td>
                                    <td rowspan="2" class="auto-style28"></td>
                                    <td class="auto-style28">Soyad</td>
                                    <td rowspan="2" class="auto-style28"></td>
                                    <td class="auto-style30">Doğum Tarihi</td>
                                    <td rowspan="2" class="auto-style28"></td>
                                    <td class="auto-style28">Cinsiyet</td>
                                    <td class="auto-style28" rowspan="2"></td>
                                    <td class="auto-style28">Telefon</td>
                                    <td rowspan="2" class="auto-style28"></td>
                                    <td class="auto-style28">Adres</td>
                                    <td rowspan="2" class="auto-style28"></td>
                                    <td class="auto-style28">Şifre</td>
                                </tr>
                                <tr>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label26" runat="server" Text='<%# Eval("HastaTC") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label20" runat="server" Text='<%# Eval("HastaAd") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label21" runat="server" Text='<%# Eval("HastaSoyad") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style30">
                                        <asp:Label ID="Label22" runat="server" Text='<%# Eval("DogumTarihi") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label23" runat="server" Text='<%# Eval("HastaCinsiyet") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label24" runat="server" Text='<%# Eval("HastaTel") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label25" runat="server" Text='<%# Eval("HastaAdres") %>'></asp:Label>
                                    </td>
                                    <td class="auto-style28">
                                        <asp:Label ID="Label27" runat="server" Text='<%# Eval("HastaSifre") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    </div>
                </td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
    </table>
</body>
</html>

