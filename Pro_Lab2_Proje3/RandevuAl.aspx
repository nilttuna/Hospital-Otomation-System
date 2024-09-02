<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandevuAl.aspx.cs" Inherits="Pro_Lab2_Proje3.RandevuAl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Randevu Alma</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center; /* Sayfanın yatay olarak ortalanması */
        }
        .auto-style1 {
            background-color: lightpink;
            padding: 20px; /* Boşluklar için iç içe alanlar */
            border-radius: 10px; /* Kenar yuvarlama */
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); /* Gölgelendirme */
            display: inline-block; /* İçeriğin ortalanması */
            text-align: left; /* İçerik metninin sol hizalanması */
        }
        .form-group {
            margin-bottom: 20px;
        }
        .form-group label {
            display: inline-block;
            width: 150px; /* Etiket genişliği */
            text-align: left; /* Etiketlerin sağa hizalanması */
        }
        .form-group input[type=text],
        .form-group input[type=datetime-local],
        .form-group textarea,
        .form-group select {
            width: 300px; /* Giriş alanı genişliği */
            padding: 5px; /* Giriş alanı için iç boşluk */
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .form-group textarea {
            height: 100px; /* Metin alanı yüksekliği */
        }
        .form-group button {
            padding: 10px 20px;
            background-color: dodgerblue;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .form-group button:hover {
            background-color: #007bff;
        }
        .auto-style2 {
            color: #FFFFFF;
            background-color: #000000;
        }
        .auto-style3 {
            text-align: center;
            text-decoration: underline;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style3">

            <strong>Randevu Al</strong></div>
        <div>

            &nbsp;</div>
        <div class="form-group">
            <label for="ddlHastane">Hastane Adı:</label>
            <asp:DropDownList ID="ddlHastane" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHastane_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="ddlBrans">Branş:</label>
            <asp:DropDownList ID="ddlBrans" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBrans_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="ddlDoktor">Doktor:</label>
            <asp:DropDownList ID="ddlDoktor" runat="server" AutoPostBack="False" ></asp:DropDownList>
        </div>
       <div class="form-group">
    <label for="txtTarih">Tarih:</label>
    <asp:TextBox ID="txtTarih" runat="server" type="date" ></asp:TextBox>
</div>

        <div class="form-group">
            <label for="txtSaat">Saat:</label>
            <asp:TextBox ID="txtSaat" runat="server" type="time" ></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtNot">Not:</label>
            <asp:TextBox ID="txtNot" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnRandevuAl" runat="server" Text="Randevu Al" OnClick="btnRandevuAl_Click" CssClass="auto-style2" Width="462px" />
        </div>
    </form>
</body>
</html>
