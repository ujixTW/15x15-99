<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InputFrom.aspx.cs" Inherits="Test20220225.InputFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>99乘法對照表產生器 - 輸入介面</title>
    <style>
        
        div{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>乘法對照表產生器</h1>
            基數
            <asp:TextBox ID="txtBaseNumber" runat="server" TextMode="Number"></asp:TextBox><br />
            係數
            <asp:TextBox ID="txtCoefficientNumber" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="btnSend" runat="server" Text="產生" OnClick="btnSend_Click" />
            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>


        </div>

    </form>
</body>
</html>
