<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayForm.aspx.cs" Inherits="Test20220225.DisplayForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>99乘法對照表產生器 - 顯示介面</title>
    <style>
        table {
            width: 100%;
        }
        .bodyTable{
            width:25%;
            height:200px;
            padding:20px 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0">
            <tr>
                <th>
                    <h2>乘法對照表產生器</h2>
                </th>
            </tr>
            <tr>
                <asp:Literal ID="ltlNum" runat="server"></asp:Literal>
            </tr>
        </table>
        <asp:Literal ID="ltlNum2" runat="server"></asp:Literal>
    </form>
</body>
</html>
