<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookies.aspx.cs" Inherits="Pract5_072.cookies" %>

<!DOCTYPE html>
<%--hello this is Rithend's Cookie.aspx file :---%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Select Brand Preferences"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="apple" runat="server" Text="Apple" />
        <br />
        <asp:CheckBox ID="dell" runat="server" Text="Dell" />
        <br />
        <asp:CheckBox ID="hp" runat="server" Text="HP" />
        <br />
        <asp:CheckBox ID="acer" runat="server" Text="Acer" />
        <br />
        <asp:CheckBox ID="lenevo" runat="server" Text="Lenevo" />
        <br />
        <asp:CheckBox ID="asus" runat="server" Text="Asus" />
        <br />
        <asp:CheckBox ID="sony" runat="server" Text="Sony" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" ></asp:Label>
        <br />
    </form>
</body>
</html>
