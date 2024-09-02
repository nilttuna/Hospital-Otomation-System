<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Pro_Lab2_Proje3.AnaSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>AnaSayfa</title>
<link href="tasarim.css" rel="stylesheet" />
</head>
<body>
    <h1 class="title">Randevu Sistemi</h1> <!-- Randevu Sistemi başlığı -->
    <form id="form1" runat="server">

        <div class="center">
            <asp:Button ID="Hasta" runat="server" Text="Hasta Giriş"  CssClass="button" OnClick="Hasta_Click"  />
            <asp:Button ID="Doktor" runat="server" Text="Doktor Giriş" CssClass="button" OnClick="Doktor_Click"  />
            <asp:Button ID="Yonetici" runat="server" Text="Yönetici Giriş"  CssClass="button" OnClick="Yonetici_Click" />
        </div>

    </form>
</body>
</html>
