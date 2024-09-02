<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaSayfasi.aspx.cs" Inherits="Pro_Lab2_Proje3.HastaSayfasi" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hasta Paneli</title>

    <link href="tasarim.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            margin-top: 0px;
            height: auto;
        }
        .auto-style2 {
            width: 121px;
            font-size: small;
            text-decoration: underline;
            text-align: left;
        }
    </style>
</head>
<body style="height: 315px; margin-top: 120px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-color: lightpink;">

            <div class="auto-style2">
                <strong><a href="KayıtSil.aspx" >Kayıt Sil</a></strong></div>

            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Hasta Kontrol Paneli" Font-Bold="True" Font-Size="45px"></asp:Label>
            <br />
            <br />
            <div>
                <asp:Button ID="Button1" runat="server" Text="Bilgilerimi Görüntüle" BorderStyle="Groove" CssClass="button2" Width="643px" BorderColor="Black" OnClick="Button1_Click"  />
            </div>
            <br />
            <div>
                <asp:Button ID="Button2" runat="server" Text="Bilgilerimi Güncele" BorderStyle="Groove" CssClass="button2" Width="644px" BorderColor="Black" OnClick="Button2_Click"  />
            </div>
            <br />
            <div>
                <asp:Button ID="Button3" runat="server" Text="Randevu Al" Width="638px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button3_Click"  />
            </div>
            <br />
            <div>
                <div>
                    <asp:Button ID="Button4" runat="server" Text="Randevularım" Width="639px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button4_Click"  />
                </div>
                
            </div>
            
            <div>
                &nbsp;</div>
            
            <div>
                    <asp:Button ID="Button7" runat="server" Text="Geçmiş Randevular" Width="639px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button7_Click"   />
            </div>
            
            <br />
            <div>
                <div>
                    <asp:Button ID="Button5" runat="server" Text="Raporlarım" Width="639px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button5_Click"  />
                </div>
                <div>

                    &nbsp;</div>
                
            </div>
            <div>
    <div>
        <asp:Button ID="Button6" runat="server" Text="Çıkış Yap" Width="639px" BorderColor="Black" BorderStyle="Groove" CssClass="button2" OnClick="Button6_Click"  />
    </div>
    
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


