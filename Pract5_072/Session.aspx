<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="Pract5_072.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div>
            <asp:Label ID="uname" runat="server" Text="User name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tuname" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="psswd" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tpsswd" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="login" runat="server" OnClick="Login_Click" Text="Login" Width="78px" />
        <p>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </p>
        <asp:Label ID="session" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
