<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiSayfası.aspx.cs" Inherits="Pro_Lab2_Proje3.YoneticiSayfası" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Yönetici Paneli</title>
    <link href="tasarim.css" rel="stylesheet" />
</head>
<body style="height: 565px; margin-top: 100px">
    <form id="form1" runat="server">
        <div class="center" style="height: 168px; background-color: lightpink;">

            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Hasta İşlemleri" Font-Bold="True" Font-Size="45px"></asp:Label>
            <br />
            <br />
            <a href="HastaSil.aspx">Hasta Sil</a><br />
            <a href="HastaEkle.aspx" >Hasta Ekle</a> <br />
            <a href="HastaGuncelle.aspx">Hasta Güncelle</a>
            <br />
            <a href="HastaListele.aspx">Hastaları Listele</a><br />
           
            <br />
            <br />
            <div>
                &nbsp;</div>
            <div style="height: 172px; margin-top: 0px; background-color: lightpink; margin-bottom:20px" class="center">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="45px" Text="Doktor İşlemleri"></asp:Label>
                <br />
                <br />
                <a href="DoktorSil.aspx">Doktor Sil </a><br />
                <a href="DoktorEkle.aspx">Doktor Ekle</a><br />
                <a href="DoktorGuncelle.aspx">Doktor Güncelle</a><br />
                <a href="DoktorListele.aspx">Doktorları Listele</a><br />
                <br />
            </div>
            <br />
            <div>
                <asp:Button ID="Button1" runat="server" CssClass="button2" OnClick="Button1_Click" Text="Çıkış Yap" />
            </div>
            <br />

        </div>
       
            
    </form>
    <p>
        &nbsp;&nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>
