<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorSayfa.aspx.cs" Inherits="Pro_Lab2_Proje3.DoktorSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Doktor Paneli</title>

    <link href="tasarim.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            margin-top: 0px;
            height: 411px;
        }
    </style>
</head>
<body style="height: 315px; margin-top: 138px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-color: lightpink;">

            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Doktor Kontrol Paneli" Font-Bold="True" Font-Size="45px"></asp:Label>
            <br />
            <br />
            <div>
                <asp:Button ID="Button1" runat="server" Text="Bilgilerimi Görüntüle" BorderStyle="Groove" CssClass="button2" Width="643px" BorderColor="Black" OnClick="Button1_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="Button2" runat="server" Text="Bilgilerimi Güncele" BorderStyle="Groove" CssClass="button2" Width="644px" BorderColor="Black" OnClick="Button2_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="Button3" runat="server" Text="Hastalarım" Width="638px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button3_Click" />
            </div>
            <br />
            <div>
                <div>
                    <asp:Button ID="Button4" runat="server" Text="Raporlar" Width="639px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button4_Click" />
                </div>

                
            </div>
            
            <br />
            <asp:Button ID="Button5" runat="server" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button5_Click" Text="Çıkış Yap" Width="638px" />
            <div>
            </div>
            
            <br />
            <br />

        </div>
       
            
    </form>
    <p>
        &nbsp;&nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>

