<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Randevularım.aspx.cs" Inherits="Pro_Lab2_Proje3.Randevularım" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Hasta Aktif Randevular</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            height: auto;
            text-align: center; 
        }
        .container {
            margin-top: 20px;
        }
        table {
            width: 90%; 
            max-width: 800px; 
            border-collapse: collapse;
            margin: 0 auto; 
            font-size: 16px;
        }
        th, td {
            padding: 15px;
            border: 1px solid #ddd;
            font-size: 14px;
            text-align: center;
        }
        th {
            background-color: lightpink;
            color: black;
        }
        td {
            background-color: #f2f2f2;
        }
        .auto-style1 {
            color: black;
            text-decoration: underline;
        }
        .auto-style2 {
            margin-top: 20px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <h2>Hasta Aktif Randevular</h2>
            <asp:Label ID="Label1" runat="server">Hasta ID:</asp:Label>
            <div>

                &nbsp;</div>
            <asp:Table ID="Table1" runat="server"></asp:Table>

            <table id="TableRandevular" runat="server">
                <tr>
                    <th class="auto-style1">Hastane Adı</th>
                    <th class="auto-style1">Branş</th>
                    <th class="auto-style1">Doktor</th>
                    <th class="auto-style1">Tarih</th>
                    <th class="auto-style1">Saat</th>
                    <th class="auto-style1">Notlar</th>
                    <th class="auto-style1"></th> 
                    <th class="auto-style1"></th>
                </tr>
               
            </table>
        </div>
    </form>
</body>
</html>
