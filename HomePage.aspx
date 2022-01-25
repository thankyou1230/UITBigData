<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BIGDATAUIT.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <h1 style="text-align:center; font-weight:bold; margin-top:150px; margin-bottom:50; color:dodgerblue">LƯỢNG NGƯỜI ĐI QUA KHU VỰC SAU 1 TIẾNG NỮA</h1>
            <asp:Label runat="server" ID="number" Text="345" Font-Size="100px" ForeColor="Orange"></asp:Label>
            <p style="text-align:center; margin-top:100px; font-style:italic">Số liệu sẽ được cập nhật mỗi tiếng 1 lần</p>
        </div>
    </form>
</body>
</html>
