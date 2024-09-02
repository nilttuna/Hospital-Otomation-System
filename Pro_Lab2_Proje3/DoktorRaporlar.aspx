<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorRaporlar.aspx.cs" Inherits="Pro_Lab2_Proje3.DoktorRaporlar" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hasta Tıbbi Raporlar</title>
    <style>
        /* Basit bir CSS kullanarak görünümü düzenleme */
        body {
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
    margin: 0;
    background-color: #f0f0f0; /* optional: just for better visibility */
}

.upload-container {
    width: 80%;
    max-width: 500px;
    margin: 50px auto;
    padding: 20px;
    border: 1px solid #ccc;
    border-radius: 5px;
    background-color: lightpink;
}

.upload-form {
    display: flex;
    flex-direction: column;
}

.form-group {
    margin-bottom: 20px;
}

.form-group label {
    font-weight: bold;
}

.form-group input[type="file"] {
    margin-top: 5px;
}

.form-group button[type="submit"] {
    padding: 10px 20px;
    background-color: #007bff;
    color: #fff;
    border: none;
    border-radius: 3px;
    cursor: pointer;
}

.form-group button[type="submit"]:hover {
    background-color: #0056b3;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="upload-container">
            <h2>Tıbbi Rapor Yükle</h2>
            <div class="upload-form">
                <div class="form-group">
                    <label for="fileUpload">Dosya Seçin:</label>
                    <asp:FileUpload ID="fileUpload" runat="server" CssClass="custom-file-input" />
                </div>
                <div class="form-group">
                    <strong>
                    <asp:Label ID="lblDoktor" runat="server" Text="Hasta İsimleri:"></asp:Label>
                    </strong>
                    <asp:DropDownList ID="ddlHastalar" runat="server" CssClass="form-control">
                      
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <strong>
                    <asp:Label ID="lblTarih" runat="server" Text="Tarih:"></asp:Label>
                    </strong>
                    <asp:TextBox ID="txtTarih" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <strong>
                    <asp:Button ID="Button1" runat="server" Text="Yükle" CssClass="btn btn-primary" OnClick="Button1_Click" style="color: #FFFFFF; font-weight: bold; background-color: #000000" Width="238px" />
                    </strong>
                </div>
            </div>
        </div>
        <div class="upload-container">
            <h2>Tıbbi Rapor Sil</h2>
            <div class="upload-form">
                <div class="form-group">
                    <strong>
                    <asp:Label ID="lblSilRapor" runat="server" Text="Rapor Seçin:"></asp:Label>
                    </strong>
                    <asp:DropDownList ID="ddlSil" runat="server" CssClass="form-control">
                      
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <strong>
                    <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn-danger" OnClick="btnSil_Click" style="font-weight: bold; color: #FFFFFF; background-color: #000000" Width="218px" />
                    </strong>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
